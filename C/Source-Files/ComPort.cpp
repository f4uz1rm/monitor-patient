// ComPort.cpp: implementation of the CComPort class.
//
//////////////////////////////////////////////////////////////////////

#include "stdafx.h"
#include "ComPort.h"


#ifdef _DEBUG
#undef THIS_FILE
static char THIS_FILE[]=__FILE__;
#define new DEBUG_NEW
#endif

//////////////////////////////////////////////////////////////////////
// Construction/Destruction
//////////////////////////////////////////////////////////////////////

CComPort::CComPort()
{
	m_nCom = 1;
}

CComPort::CComPort(int nCom)
{
	m_nCom = nCom;	
}

CComPort::~CComPort()
{
    if (m_olRecv.hEvent)
        CloseHandle(m_olRecv.hEvent);
    if (m_olSend.hEvent)
        CloseHandle(m_olSend.hEvent);
    if (m_hComHandle != INVALID_HANDLE_VALUE)
        CloseHandle(m_hComHandle);
}

//
BOOL CComPort::Initialize()
{
    COMMTIMEOUTS commtimeouts;
    DCB   dcb;

    memset(&m_olRecv, 0, sizeof(OVERLAPPED));
    m_olRecv.hEvent     = CreateEvent(NULL, TRUE, FALSE, NULL);
    if (NULL == m_olRecv.hEvent)
        return FALSE;

    memset(&m_olSend, 0, sizeof(OVERLAPPED));
    m_olSend.hEvent     = CreateEvent(NULL, TRUE, FALSE, NULL);
    if (NULL == m_olSend.hEvent)
    {
        CloseHandle(m_olRecv.hEvent);
        return FALSE;
    }
//	ddddd

    // create com file
	TCHAR szCom[16];
	switch ( m_nCom ) {
		case 0:
			_sntprintf(szCom, 15, _T("%s"), _T("COM1"));
			break;
		case 1:
			_sntprintf(szCom, 15, _T("%s"), _T("COM2"));
			break;
		case 2:
			_sntprintf(szCom, 15, _T("%s"), _T("COM3"));
			break;
		case 3:
			_sntprintf(szCom, 15, _T("%s"), _T("COM4"));
			break;
		case 4:
			_sntprintf(szCom, 15, _T("%s"), _T("COM5"));
			break;
		case 5:
			_sntprintf(szCom, 15, _T("%s"), _T("COM6"));
			break;
		case 6:
			_sntprintf(szCom, 15, _T("%s"), _T("COM7"));
			break;
		default:
			_sntprintf(szCom, 15, _T("%s"), _T("COM1"));
			break;
	}

    m_hComHandle = CreateFile(szCom,
                    GENERIC_READ | GENERIC_WRITE,
                    0,                              // exclusive access
                    NULL,                           // no security attrs
                    OPEN_EXISTING,
                    FILE_ATTRIBUTE_NORMAL |
                    FILE_FLAG_OVERLAPPED,           // overlapped I/O
                    NULL);
	if (m_hComHandle == INVALID_HANDLE_VALUE) {
		return FALSE;
	}

    // get any early notifications
    SetCommMask(m_hComHandle, EV_RXCHAR);

    // setup device buffers
    SetupComm(m_hComHandle, 4800, 4800);

    // purge any information in the buffer
    PurgeComm(m_hComHandle, PURGE_TXABORT | PURGE_RXABORT | PURGE_TXCLEAR | PURGE_RXCLEAR);

    // set up for overlapped I/O
    commtimeouts.ReadIntervalTimeout        = MAXDWORD;
    commtimeouts.ReadTotalTimeoutMultiplier = 0;
    commtimeouts.ReadTotalTimeoutConstant   = 0;

    commtimeouts.WriteTotalTimeoutMultiplier = 0;
    commtimeouts.WriteTotalTimeoutConstant   = 0;
    SetCommTimeouts(m_hComHandle, &commtimeouts);

    GetCommState(m_hComHandle, &dcb);

    dcb.DCBlength = sizeof(DCB);
	
	
	dcb.BaudRate  = CBR_115200;
	
   // dcb.fBinary   = TRUE;
	dcb.fParity   = FALSE;			
//	dcb.fParity   = TRUE;			
    dcb.ByteSize  = 8;
	dcb.Parity    = NOPARITY;	//
//	dcb.Parity    = EVENPARITY;	//old
    dcb.StopBits  = ONESTOPBIT;          

    // setup hardware flow control
    dcb.fOutxDsrFlow = FALSE;
    dcb.fDtrControl  = DTR_CONTROL_DISABLE;

    dcb.fOutxCtsFlow = FALSE;
    dcb.fRtsControl  = RTS_CONTROL_DISABLE;

    dcb.fDsrSensitivity = FALSE;
    dcb.fOutX = FALSE;
    dcb.fInX  = FALSE;
    dcb.fNull = FALSE;

    // other various settings
    SetCommState(m_hComHandle, &dcb);

    return TRUE;
}

// Arguments:
//      buf - ��Ŵ������ݵĻ�����
//      maxsize - �ܹ�����������ֽ���
//      size - ʵ�ʶ������ֽ���
//  Return:
//      TURE-���ճɹ���FALSE-ʧ��
//  Description:
//    ʹ���첽��ʽ��̨�������ݣ�ReadFile �����̷��أ�ͨ��
//    ��ѯ�첽����״̬�жϷ����Ƿ�ɹ���GetOverlappedResult ����Ĺ�
//    ����ʽ��ֱ�����ճɹ�������������ŷ��أ��ú������ص��ֽڸ�����
//    �����ģ�����֡���ж���Ӧ�ó�����
BOOL CComPort::Recv(BYTE *buf, DWORD maxsize, DWORD &size)
{
    if (buf == NULL || maxsize == 0)
        return FALSE;
        
	DWORD event, error, ecode, readbytes;
	COMSTAT cs;

	ClearCommError(m_hComHandle, &error, &cs);

	// �ȴ������¼�����
	if (!WaitCommEvent(m_hComHandle, &event, &m_olRecv))
    {
        ecode = GetLastError();
		if (ecode != ERROR_IO_PENDING) // �ȴ������¼��Ƿ����첽����
        {
			ClearCommError(m_hComHandle, &error, &cs);
			return FALSE;
        }
        while (!GetOverlappedResult(m_hComHandle, &m_olRecv, &size, FALSE))
        {
            ecode = GetLastError();
			if (ecode != ERROR_IO_INCOMPLETE)
            {
                ClearCommError(m_hComHandle, &error, &cs);
				return FALSE;
            }
        }
	}

	//�������������ݵ���
	if ((event&EV_RXCHAR) != EV_RXCHAR)
//	{
 //       Beep(2000,1000)  ;
		return FALSE;
//	}
	ClearCommError(m_hComHandle, &error, &cs);
    readbytes = cs.cbInQue; // ���������ֽ���

    if (readbytes == 0) // û������
        return FALSE;

    // ��������������
    if (readbytes > maxsize)
        readbytes = maxsize;

	if (!ReadFile(m_hComHandle, buf, readbytes, &size, &m_olRecv))
    {
        // �����첽��ȡ����
        ecode = GetLastError();
        if (ecode != ERROR_IO_PENDING)
        {
            ClearCommError(m_hComHandle, &error, &cs);
            return FALSE;
        }
        while (!GetOverlappedResult(m_hComHandle, &m_olRecv, &size, FALSE))
        {
            if (GetLastError() != ERROR_IO_INCOMPLETE)
            {
                ClearCommError(m_hComHandle, &error, &cs);
                return FALSE;
            }
        }
	}

    return TRUE;
}

// Arguments:
//      buf - ���ͻ�����
//      size - �����ֽ��� 
BOOL CComPort::Send(BYTE *buf, DWORD size)
{
    if (buf == NULL || size == 0)
        return FALSE;

    DWORD error, ecode, writebytes;
    COMSTAT cs;

    if (!WriteFile(m_hComHandle, buf, size, &writebytes, &m_olSend))
    {
        ecode = GetLastError();
        if (ecode != ERROR_IO_PENDING)
        {
            ClearCommError(m_hComHandle, &error, &cs);
            return FALSE;
        }
        while (!GetOverlappedResult(m_hComHandle, &m_olSend, &writebytes, TRUE))
        {
            ecode = GetLastError();
            if (ecode != ERROR_IO_INCOMPLETE)
            {
                ClearCommError(m_hComHandle, &error, &cs);
                return FALSE;
            }
        }
    }
    return TRUE;
}

bool CComPort::WaitRevEvent()
{
	DWORD event, error, ecode ;
	COMSTAT cs;
	ResetEvent(m_olRecv.hEvent);
	// �ȴ������¼�����
	if (!WaitCommEvent(m_hComHandle, &event, &m_olRecv))
        {
        ecode = GetLastError();
        if (ecode != ERROR_IO_PENDING) // �ȴ������¼��Ƿ����첽����
        {
            ClearCommError(m_hComHandle, &error, &cs);
            return FALSE;
        }
 /*       while (!GetOverlappedResult(m_hComHandle, &m_olRecv, &size, FALSE))
        {
            ecode = GetLastError();
            if (ecode != ERROR_IO_INCOMPLETE)
            {
                ClearCommError(m_hComHandle, &error, &cs);
                return FALSE;
            }
        }     */
	}
  //      if ((event&EV_RXCHAR) != EV_RXCHAR)
   //         return FALSE;
        return TRUE;

}
