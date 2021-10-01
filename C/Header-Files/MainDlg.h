#pragma once

#include "LAYOUT.h"
#include "ShowTimeThread.h"
#include "transparentbutton.h"
#include "afxwin.h"

class CMulti_ParaMonitorDlg;

// CMainDlg 对话框

class CMainDlg : public CDialog
{
	DECLARE_DYNAMIC(CMainDlg)

public:
	CMainDlg(CWnd* pParent = NULL);   // 标准构造函数
	virtual ~CMainDlg();

// 对话框数据
	enum { IDD = IDD_MAIN_DIALOG };

protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV 支持

	DECLARE_MESSAGE_MAP()
public:
	virtual BOOL OnInitDialog();
	afx_msg void OnLButtonDown(UINT nFlags, CPoint point);
	afx_msg BOOL OnEraseBkgnd(CDC* pDC);

public:
	CMulti_ParaMonitorDlg *m_pMultiParaDlg;
	CBitmap m_SleepMainBk;
	CShowTimeThread *m_pcShowTimeThread;

public:
	void InitTheWin();
	void SetCurrentTime(CString strTime);

	afx_msg void OnBnClickedButtonSetpatient();
	afx_msg void OnBnClickedButtonSetmenu();
	afx_msg void OnBnClickedButtonNbp();
	afx_msg void OnBnClickedButtonSpo2();
	afx_msg void OnBnClickedButtonDebuginfo();
	void FindCommPort(CComboBox *pComboBox);

	CTransParentButton m_ECGButton;
	CTransParentButton m_NIBPButton;
	CTransParentButton m_SpO2Button;
	CTransParentButton m_PTyeButton;
	CTransParentButton m_QuitButton;
	CTransParentButton m_DebugButton;
	CTransParentButton m_TimeButton;
	CComboBox m_ComboBoxPortList;
	afx_msg void OnCbnSelchangeComPort();
	afx_msg void OnCbnSetfocusComPort();
};
