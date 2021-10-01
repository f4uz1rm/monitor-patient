#pragma once



// CShowTimeThread

class CMainDlg;

class CShowTimeThread : public CWinThread
{
	DECLARE_DYNCREATE(CShowTimeThread)

protected:
	CShowTimeThread();           // protected constructor used by dynamic creation
	virtual ~CShowTimeThread();

public:
	CShowTimeThread(CMainDlg * pcMonitorDlg);
	CMainDlg * m_pMonitorDlg;

	virtual BOOL InitInstance();
	virtual int ExitInstance();

protected:
	DECLARE_MESSAGE_MAP()
	bool m_bStopFlag;
public:
	void SetStopFlag(bool bFlag);
};


