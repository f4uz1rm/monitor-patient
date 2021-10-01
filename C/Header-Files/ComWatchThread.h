#if !defined(AFX_COMWATCHTHREAD_H__540B53AF_DEAB_11D5_9061_0010885090EC__INCLUDED_)
#define AFX_COMWATCHTHREAD_H__540B53AF_DEAB_11D5_9061_0010885090EC__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// ComWatchThread.h : header file
//

#include "ComPort.h"

class CMulti_ParaMonitorDlg;
/////////////////////////////////////////////////////////////////////////////
// CComWatchThread thread

#define ZUGMED_UART_BUFF_LEN		1024
#define ZUGMED_MIN_FRAME_LEN		10
#define ZUGMED_MAX_FRAME_DATA_LEN	48
#define ZUGMED_MAX_FRAME_CACHE_LEN	100

#define ZUGMED_PACKET_HEAD	0xFA

//读取数据
typedef struct _ZUGMED_UARTCOMM
{
	unsigned char pu8Buff[ZUGMED_UART_BUFF_LEN];				// 串口数据接收缓冲区
	unsigned int u32WriteIndex;                   					// 串口数据接收缓冲区写入数据下标
	unsigned int u32ReadIndex;                    					// 串口数据接收缓冲区读出数据下标     
} ZUGMED_UARTCOMM;

typedef enum _ZUGMED_SEARCH_PACKET_STATUS_LIST
{
	ZUGMED_SEARCH_PACKET_STATUS_HEAD,
	ZUGMED_SEARCH_PACKET_STATUS_LEN,
	ZUGMED_SEARCH_PACKET_STATUS_PARA_TYPE,	 //eg:CCO,IBP
	ZUGMED_SEARCH_PACKET_STATUS_TYPE,		 //eg:DC,DR
	ZUGMED_SEARCH_PACKET_STATUS_ID,
	ZUGMED_SEARCH_PACKET_STATUS_NO_0,
	ZUGMED_SEARCH_PACKET_STATUS_NO_1,
	ZUGMED_SEARCH_PACKET_STATUS_NO_2,
	ZUGMED_SEARCH_PACKET_STATUS_NO_3,
	ZUGMED_SEARCH_PACKET_STATUS_DATA,	
	ZUGMED_SEARCH_PACKET_STATUS_CHECKSUM,

	ZUGMED_SEARCH_PACKET_STATUS_MAX
} ZUGMED_SEARCH_PACKET_STATUS_LIST;

//解析出来的包                                      
typedef struct _ZUGMED_PACKET
{
	unsigned char u8Len;
	unsigned char u8ParaType;
	unsigned char u8Type;
	unsigned char u8Id;
	unsigned int u32No;
	unsigned char pu8Data[ZUGMED_MAX_FRAME_DATA_LEN];
	unsigned char u8Checksum;
} ZUGMED_PACKET;

//数据包类型 
typedef enum _ZUGMED_PACKET_TYPE_LIST
{	
	ZUGMED_PACKET_TYPE_DC = 0x01,
	ZUGMED_PACKET_TYPE_DR = 0x02,
	ZUGMED_PACKET_TYPE_DA = 0x03,
	ZUGMED_PACKET_TYPE_DD = 0x04,

	ZUGMED_PACKET_TYPE_MAX
} ZUGMED_PACKET_TYPE_LIST;


class CComWatchThread : public CWinThread
{
	DECLARE_DYNCREATE(CComWatchThread)
protected:
	CComWatchThread();           // protected constructor used by dynamic creation
	

// Attributes
public:
	CComPort *m_pcComPort;
	CMulti_ParaMonitorDlg* m_pcMonitorDlg;

	ZUGMED_UARTCOMM gtZugMedComm;
	ZUGMED_PACKET gtZugMedPacket;

// Operations
public:
	CComWatchThread(CComPort *pcComPort, CMulti_ParaMonitorDlg *pcMonitorDlg); 

	virtual ~CComWatchThread();

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CComWatchThread)
	public:
	virtual BOOL InitInstance();
	virtual int ExitInstance();
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CComWatchThread)
		// NOTE - the ClassWizard will add and remove member functions here.
	//}}AFX_MSG

	DECLARE_MESSAGE_MAP()
private:
	unsigned char ZugMedUnpackUartData(unsigned char * pu8Buff, unsigned int u32BuffLen, ZUGMED_PACKET * ptPacket, unsigned int * pu32RemainLen);
	unsigned int ZugMedGetUartRxBuffLen();
	unsigned int ZugMedGetUartRxStr(unsigned char * pu8DestBuff, unsigned int u32Len);	 // 读取缓冲区数据内容
	void ZugMedRestoreUartRxStr(unsigned int u32Len);
	void ZugMedRcvCmd();//unsigned char * puchBuff, unsigned int u32Size)

public:
	void SetStopFlag(bool bFlag);
	BOOL m_bModeflag;
protected:
	bool m_bStopFlag;
};

/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_COMWATCHTHREAD_H__540B53AF_DEAB_11D5_9061_0010885090EC__INCLUDED_)
