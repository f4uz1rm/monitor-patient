// ComWatchThread.cpp : implementation file
//

#include "stdafx.h"
#include "ComWatchThread.h"
#include "Multi_Para Monitor.h"
#include "Multi_Para MonitorDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CComWatchThread

IMPLEMENT_DYNCREATE(CComWatchThread, CWinThread)

FILE * gpfResultFile = NULL;

CComWatchThread::CComWatchThread()
{
	gtZugMedComm.u32ReadIndex = 0;
	gtZugMedComm.u32WriteIndex = 0;

	if ( NULL == gpfResultFile )
	{
		gpfResultFile = fopen("rcvdata.dat", "wb");
	}
}

CComWatchThread::CComWatchThread(CComPort * pcComPort, CMulti_ParaMonitorDlg* pcMonitorDlg)
{
	m_pcComPort = pcComPort;
	m_pcMonitorDlg = pcMonitorDlg;

	gtZugMedComm.u32ReadIndex = 0;
	gtZugMedComm.u32WriteIndex = 0;

	m_bStopFlag = false;
	m_bModeflag = false;
	if ( NULL == gpfResultFile )
	{
		gpfResultFile = fopen("rcvdata.dat", "wb");
	}
}

CComWatchThread::~CComWatchThread()
{
	if ( NULL != gpfResultFile )
	{
		fclose(gpfResultFile);
	}
}

BOOL CComWatchThread::InitInstance()                
{
	// TODO:  perform and per-thread initialization here
	m_bStopFlag = false;

	BYTE  pBuf[512];
	DWORD size;

	memset(pBuf, 0, 512);
	while( (m_pcComPort != NULL) && (false == m_bStopFlag) ) 
	{
		// 如果没有受到数据，该Recv函数将阻塞
		if(!m_pcComPort->Recv(pBuf, 512, size)) 
			// 发生了什么错误，休息一会，接着来.
		{
			Sleep(3);
			continue;
		}

		for ( UINT i = 0;  i < size; i ++ ) 
		{
			gtZugMedComm.pu8Buff[gtZugMedComm.u32WriteIndex] = pBuf[i];
			gtZugMedComm.u32WriteIndex++;
			if ( gtZugMedComm.u32WriteIndex >= ZUGMED_UART_BUFF_LEN ) 
			{
				gtZugMedComm.u32WriteIndex = 0;
			}
			//fwrite(&(pBuf[i]), 1, 1, gpfResultFile);
			//fflush(gpfResultFile);
		}

		ZugMedRcvCmd();
		Sleep(1);
	}

    return TRUE;
}

int CComWatchThread::ExitInstance()
{
	// TODO:  perform any per-thread cleanup here
	return CWinThread::ExitInstance();
}

BEGIN_MESSAGE_MAP(CComWatchThread, CWinThread)
	//{{AFX_MSG_MAP(CComWatchThread)
		// NOTE - the ClassWizard will add and remove mapping macros here.
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()


unsigned int CComWatchThread::ZugMedGetUartRxBuffLen()
{
	unsigned int u32Len;

	if ( gtZugMedComm.u32WriteIndex >= gtZugMedComm.u32ReadIndex )
	{
		u32Len = gtZugMedComm.u32WriteIndex - gtZugMedComm.u32ReadIndex;
	}
	else
	{
		u32Len = ZUGMED_UART_BUFF_LEN - gtZugMedComm.u32ReadIndex + gtZugMedComm.u32WriteIndex;
	}

	return u32Len;
}

unsigned int CComWatchThread::ZugMedGetUartRxStr(unsigned char * pu8DestBuff, unsigned int u32Len)	 // 读取缓冲区数据内容
{
	unsigned int u32RealLen;
	unsigned int u32Index;

	u32RealLen = 0;

	for ( u32Index = 0; u32Index < u32Len; u32Index ++ )
	{
		if ( gtZugMedComm.u32ReadIndex == gtZugMedComm.u32WriteIndex )
		{
			return u32RealLen;
		}
		pu8DestBuff[u32Index] = gtZugMedComm.pu8Buff[gtZugMedComm.u32ReadIndex];

		gtZugMedComm.u32ReadIndex ++;
		u32RealLen ++;

		if ( ZUGMED_UART_BUFF_LEN <= gtZugMedComm.u32ReadIndex )
		{
			gtZugMedComm.u32ReadIndex = 0;
		}
	}

	return u32Len;
}

void CComWatchThread::ZugMedRestoreUartRxStr(unsigned int u32Len)
{
	if ( gtZugMedComm.u32ReadIndex >= u32Len )
	{
		gtZugMedComm.u32ReadIndex = gtZugMedComm.u32ReadIndex - u32Len;
	}
	else
	{
		gtZugMedComm.u32ReadIndex = ZUGMED_UART_BUFF_LEN + gtZugMedComm.u32ReadIndex - u32Len;
	}
}

unsigned char CComWatchThread::ZugMedUnpackUartData(unsigned char * pu8Buff, unsigned int u32BuffLen, ZUGMED_PACKET * ptPacket, unsigned int * pu32RemainLen)
{
	ZUGMED_SEARCH_PACKET_STATUS_LIST tSearchPacketStatus;

	unsigned char u8CurrentByte;
	unsigned char pu8No[4];
	unsigned char u8Checksum = 0;

	unsigned int u32Len;
	unsigned int u32HeadIndex = 0;
	unsigned int u32Index;

	int i = 0;

	tSearchPacketStatus = ZUGMED_SEARCH_PACKET_STATUS_HEAD;

	u32Len = u32BuffLen;
	u32Index = 0;

	while ( u32Len > 0) 
	{        
		u8CurrentByte = pu8Buff[u32Index ++];
		u32Len --;

		switch ( tSearchPacketStatus )
		{
		case ZUGMED_SEARCH_PACKET_STATUS_HEAD:
			if ( ZUGMED_PACKET_HEAD == u8CurrentByte )
			{
				tSearchPacketStatus = ZUGMED_SEARCH_PACKET_STATUS_LEN;
				u32HeadIndex = (u32Index - 1);
			}
			else if ( u32Len < ZUGMED_MIN_FRAME_LEN )
			{
				(* pu32RemainLen) = u32Len + 1;
				return 0;
			}
			break;

		case ZUGMED_SEARCH_PACKET_STATUS_LEN:
			ptPacket->u8Len = u8CurrentByte;
			if ( ZUGMED_MAX_FRAME_DATA_LEN < ptPacket->u8Len ) 
			{
				u32Index = u32HeadIndex + 1;
				u32Len = u32BuffLen - u32Index;
				tSearchPacketStatus = ZUGMED_SEARCH_PACKET_STATUS_HEAD;                         
			}/*
			else if ( (ptPacket->u8Len - 2) <= u32Len )
			{
				tSearchPacketStatus = ZUGMED_SEARCH_PACKET_STATUS_PARA_TYPE;
			}
			else
			{
				(* pu32RemainLen) = u32Len + 2;
				return 0;
			}  */
			else //屏蔽上面，以下黄老师，要求加的
			{
				int iLen = ptPacket->u8Len - 2;
				int i32Len = u32Len;
				if ( iLen <= i32Len )
				{
					tSearchPacketStatus = ZUGMED_SEARCH_PACKET_STATUS_PARA_TYPE;
				}
				else
				{
					(* pu32RemainLen) = u32Len + 2;
					return 0;
				}
			}//到此处

			break;

		case ZUGMED_SEARCH_PACKET_STATUS_PARA_TYPE:
			ptPacket->u8ParaType = u8CurrentByte;
			tSearchPacketStatus = ZUGMED_SEARCH_PACKET_STATUS_TYPE;
			break;

		case ZUGMED_SEARCH_PACKET_STATUS_TYPE:
			ptPacket->u8Type = u8CurrentByte;
			tSearchPacketStatus = ZUGMED_SEARCH_PACKET_STATUS_ID;
			break;

		case ZUGMED_SEARCH_PACKET_STATUS_ID:
			ptPacket->u8Id = u8CurrentByte;
			tSearchPacketStatus = ZUGMED_SEARCH_PACKET_STATUS_NO_0;
			break;

		case ZUGMED_SEARCH_PACKET_STATUS_NO_0:
			pu8No[0] = u8CurrentByte;
			ptPacket->u32No = u8CurrentByte;
			tSearchPacketStatus = ZUGMED_SEARCH_PACKET_STATUS_NO_1;
			break;

		case ZUGMED_SEARCH_PACKET_STATUS_NO_1:
			pu8No[1] = u8CurrentByte;
			ptPacket->u32No += u8CurrentByte << 8;
			tSearchPacketStatus = ZUGMED_SEARCH_PACKET_STATUS_NO_2;
			break;

		case ZUGMED_SEARCH_PACKET_STATUS_NO_2:
			pu8No[2] = u8CurrentByte;
			ptPacket->u32No += u8CurrentByte << 16;
			tSearchPacketStatus = ZUGMED_SEARCH_PACKET_STATUS_NO_3;
			break;

		case ZUGMED_SEARCH_PACKET_STATUS_NO_3:
			pu8No[3] = u8CurrentByte;
			ptPacket->u32No += u8CurrentByte << 24;
			tSearchPacketStatus = ZUGMED_SEARCH_PACKET_STATUS_DATA;

		case ZUGMED_SEARCH_PACKET_STATUS_DATA:
			u8Checksum = ptPacket->u8Len;
			u8Checksum += ptPacket->u8ParaType;
			u8Checksum += ptPacket->u8Type;
			u8Checksum += ptPacket->u8Id;
			u8Checksum += pu8No[0];
			u8Checksum += pu8No[1];
			u8Checksum += pu8No[2];
			u8Checksum += pu8No[3];
			for ( i = 0; i < (ptPacket->u8Len - 10); i ++ )
			{
				ptPacket->pu8Data[i] = pu8Buff[u32Index ++];
				u8Checksum += ptPacket->pu8Data[i];
				u32Len --;
			}
			tSearchPacketStatus = ZUGMED_SEARCH_PACKET_STATUS_CHECKSUM;
			break;

		case ZUGMED_SEARCH_PACKET_STATUS_CHECKSUM:
			if ( u8Checksum == u8CurrentByte )
			{
				ptPacket->u8Checksum = u8CurrentByte;
				(* pu32RemainLen) = u32BuffLen - u32Index;
				return 1;
			}
			else
			{
				tSearchPacketStatus = ZUGMED_SEARCH_PACKET_STATUS_HEAD;
				u32Index = u32HeadIndex + 1;
				u32Len = u32BuffLen - u32Index;
			}
			break;

		default:
			tSearchPacketStatus = ZUGMED_SEARCH_PACKET_STATUS_HEAD;
			u32Index = 0;
			break;
		}   
	}

	return 0;
}

void CComWatchThread::ZugMedRcvCmd()//unsigned char * puchBuff, unsigned int u32Size)
{
	unsigned int u32RcvLen;
	unsigned int u32CacheLen;
	unsigned int u32RemainLen;
	unsigned int u32Index;

	bool bValidePack = TRUE;

	unsigned char pu8CacheBuff[ZUGMED_MAX_FRAME_CACHE_LEN];

	u32RcvLen = ZugMedGetUartRxBuffLen();

	if ( u32RcvLen < ZUGMED_MIN_FRAME_LEN )
	{
		return;
	}
	else if ( u32RcvLen > ZUGMED_MAX_FRAME_CACHE_LEN )
	{
		u32RcvLen = ZUGMED_MAX_FRAME_CACHE_LEN;
	}

	u32CacheLen = ZugMedGetUartRxStr(pu8CacheBuff, u32RcvLen);

	u32Index = 0;

	while ( (u32CacheLen >= ZUGMED_MIN_FRAME_LEN) && ( true == bValidePack))
	{
		bValidePack = ZugMedUnpackUartData(&pu8CacheBuff[u32Index], u32CacheLen, &gtZugMedPacket, &u32RemainLen);
		
		if ( bValidePack)
		{	
			m_pcMonitorDlg->RcvData(gtZugMedPacket);
		}

		u32Index = u32RcvLen - u32RemainLen;
		u32CacheLen = u32RemainLen;		
	}

	if ( 0 != u32CacheLen )
	{
		ZugMedRestoreUartRxStr(u32CacheLen);
	}
}

void CComWatchThread::SetStopFlag(bool bFlag)
{
	m_bStopFlag = bFlag;
}
