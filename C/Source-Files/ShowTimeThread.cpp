// ShowTimeThread.cpp : implementation file
//

#include "stdafx.h"
#include "ShowTimeThread.h"
#include "Multi_Para Monitor.h"
#include "Multi_Para MonitorDlg.h"
#include "MainDlg.h"


// CShowTimeThread

IMPLEMENT_DYNCREATE(CShowTimeThread, CWinThread)

CShowTimeThread::CShowTimeThread()
{
	m_bStopFlag = false;
}

CShowTimeThread::~CShowTimeThread()
{
}

BOOL CShowTimeThread::InitInstance()
{
	// TODO:  perform and per-thread initialization here
	m_bStopFlag = false;

	Sleep(500);

	while ( false == m_bStopFlag ) {
		SYSTEMTIME stLocal;
		GetLocalTime(&stLocal);

		CString strTime;
		strTime.Format(_T("%4d-%02d-%02d %02d:%02d:%02d"), stLocal.wYear, stLocal.wMonth, stLocal.wDay, stLocal.wHour, stLocal.wMinute, stLocal.wSecond);
		m_pMonitorDlg->SetCurrentTime(strTime);

		Sleep(500);
	}

	return TRUE;
}

int CShowTimeThread::ExitInstance()
{
	// TODO:  perform any per-thread cleanup here
	return CWinThread::ExitInstance();
}

BEGIN_MESSAGE_MAP(CShowTimeThread, CWinThread)
END_MESSAGE_MAP()


// CShowTimeThread message handlers
CShowTimeThread::CShowTimeThread(CMainDlg * pcMonitorDlg)
{
	m_pMonitorDlg = pcMonitorDlg;
}

void CShowTimeThread::SetStopFlag(bool bFlag)
{
	m_bStopFlag = bFlag;
}
