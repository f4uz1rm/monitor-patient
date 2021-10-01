// MainDlg.cpp : 实现文件
//

#include "stdafx.h"
#include "Multi_Para Monitor.h"
#include "MainDlg.h"
#include "LAYOUT.h"
#include "SetPatientDlg.h"
#include "Multi_Para MonitorDlg.h"

// CMainDlg 对话框

IMPLEMENT_DYNAMIC(CMainDlg, CDialog)

CMainDlg::CMainDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CMainDlg::IDD, pParent)
{
	m_pMultiParaDlg = NULL;
	m_pcShowTimeThread = NULL;
}

CMainDlg::~CMainDlg()
{
}

void CMainDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	DDX_Control(pDX, IDC_BUTTON_SETMENU, m_ECGButton);
	DDX_Control(pDX, IDC_BUTTON_NBP, m_NIBPButton);
	DDX_Control(pDX, IDC_BUTTON_SPO2, m_SpO2Button);
	DDX_Control(pDX, IDC_BUTTON_SETPATIENT, m_PTyeButton);
	DDX_Control(pDX, IDCANCEL, m_QuitButton);
	DDX_Control(pDX, IDC_BUTTON_DEBUGINFO, m_DebugButton);
	DDX_Control(pDX, IDC_BUTTON_TIME, m_TimeButton);
	DDX_Control(pDX, IDC_COM_PORT, m_ComboBoxPortList);
}


BEGIN_MESSAGE_MAP(CMainDlg, CDialog)
	ON_WM_LBUTTONDOWN()
	ON_WM_ERASEBKGND()
	ON_BN_CLICKED(IDC_BUTTON_SETPATIENT, &CMainDlg::OnBnClickedButtonSetpatient)
	ON_BN_CLICKED(IDC_BUTTON_SETMENU, &CMainDlg::OnBnClickedButtonSetmenu)
	ON_BN_CLICKED(IDC_BUTTON_NBP, &CMainDlg::OnBnClickedButtonNbp)
	ON_BN_CLICKED(IDC_BUTTON_SPO2, &CMainDlg::OnBnClickedButtonSpo2)
	ON_BN_CLICKED(IDC_BUTTON_DEBUGINFO, &CMainDlg::OnBnClickedButtonDebuginfo)
	ON_CBN_SELCHANGE(IDC_COM_PORT, &CMainDlg::OnCbnSelchangeComPort)
	ON_CBN_SETFOCUS(IDC_COM_PORT, &CMainDlg::OnCbnSetfocusComPort)
END_MESSAGE_MAP()


// CMainDlg 消息处理程序

BOOL CMainDlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	// TODO:  在此添加额外的初始化
	InitTheWin();
	
	FindCommPort(&m_ComboBoxPortList);

	return TRUE;  // return TRUE unless you set the focus to a control
	// 异常: OCX 属性页应返回 FALSE
}

void CMainDlg::OnLButtonDown(UINT nFlags, CPoint point)
{
	// TODO: 在此添加消息处理程序代码和/或调用默认值
	PostMessage(WM_NCLBUTTONDOWN,HTCAPTION,MAKELPARAM(point.x,point.y));

	CDialog::OnLButtonDown(nFlags, point);
}

void CMainDlg::InitTheWin()
{
	MoveWindow(0,0,MAININTERFACE_W,MAININTERFACE_H);
	CenterWindow();

	CRgn m_rgn; 
	RECT rc; 
	GetClientRect(&rc); 
	m_rgn.CreateRoundRectRgn(rc.left,rc.top,rc.right,rc.bottom,80,80); 
	SetWindowRgn(m_rgn,TRUE); 
	SetWindowText(_T("Multi-Para Monitoring"));
	
	m_SleepMainBk.LoadBitmap(IDB_MAINBK);
	BITMAP bm;
	m_SleepMainBk.GetObject(sizeof(BITMAP), &bm);
	
	GetDlgItem(IDC_BUTTON_TIME)->MoveWindow(40,MAININTERFACE_H-35,MULTIPARA_TIME_W,MULTIPARA_TIME_H);
//	GetDlgItem(IDC_STATIC_TIME)->MoveWindow(30,MAININTERFACE_H-30,MULTIPARA_TIME_W,MULTIPARA_TIME_H);
	GetDlgItem(IDC_STATIC_TIME)->ShowWindow(FALSE);

	m_ComboBoxPortList.MoveWindow(MULTIPARA_TIME_W+60,MAININTERFACE_H-38,MULTIPARA_TIME_W*0.6,MULTIPARA_TIME_H);

	m_pcShowTimeThread = new CShowTimeThread(this);
	m_pcShowTimeThread->CreateThread(CREATE_SUSPENDED);
	m_pcShowTimeThread->SetThreadPriority(THREAD_PRIORITY_LOWEST);
	m_pcShowTimeThread->ResumeThread();
	
	m_pMultiParaDlg = new CMulti_ParaMonitorDlg;
	m_pMultiParaDlg->Create(IDD_MULTI_PARAMONITOR_DIALOG,this);
	m_pMultiParaDlg->MoveWindow(MAINI_MULTISTART_W,MAINI_MULTISTART_H,MULTIPARA_INTERFACE_W+1,MULTIPARA_INTERFACE_H+2);
	m_pMultiParaDlg->ShowWindow(SW_SHOW);
	
	m_pMultiParaDlg->m_pDebugInfoDlg->ShowWindow(SW_HIDE);
//	GetDlgItem(IDC_BUTTON_SETMENU)->EnableWindow(FALSE);

	//按钮初始化
	int ButtonHeight = 55;
	int ButtonSW = 73;
	int StartH = MAININTERFACE_H/4;
	int PerButtonH = MAININTERFACE_H/11;

	GetDlgItem(IDC_BUTTON_SETMENU)->MoveWindow(MAININTERFACE_W-ButtonSW,StartH,ButtonHeight,ButtonHeight);
	GetDlgItem(IDC_BUTTON_SPO2)->MoveWindow(MAININTERFACE_W-ButtonSW,StartH+PerButtonH,ButtonHeight,ButtonHeight);
	GetDlgItem(IDC_BUTTON_NBP)->MoveWindow(MAININTERFACE_W-ButtonSW,StartH+PerButtonH*2,ButtonHeight,ButtonHeight);
	GetDlgItem(IDC_BUTTON_SETPATIENT)->MoveWindow(MAININTERFACE_W-ButtonSW,StartH+PerButtonH*3,ButtonHeight,ButtonHeight);
	GetDlgItem(IDC_BUTTON_DEBUGINFO)->MoveWindow(MAININTERFACE_W-ButtonSW,StartH+PerButtonH*4,ButtonHeight,ButtonHeight);
	GetDlgItem(IDCANCEL)->MoveWindow(MAININTERFACE_W-ButtonSW,StartH+PerButtonH*5,ButtonHeight,ButtonHeight);

	m_ECGButton.SetIcon(IDI_ICON1,IDI_ICON2);
	m_NIBPButton.SetIcon(IDI_ICON1,IDI_ICON2);
	m_SpO2Button.SetIcon(IDI_ICON1,IDI_ICON2);
	m_PTyeButton.SetIcon(IDI_ICON1,IDI_ICON2);
	m_QuitButton.SetIcon(IDI_ICON1,IDI_ICON2);
	m_DebugButton.SetIcon(IDI_ICON1,IDI_ICON2);
	m_ECGButton.SetAlign(AL_TOP);
	m_NIBPButton.SetAlign(AL_TOP);
	m_SpO2Button.SetAlign(AL_TOP);
	m_PTyeButton.SetAlign(AL_TOP);
	m_QuitButton.SetAlign(AL_TOP);
	m_DebugButton.SetAlign(AL_TOP);

	m_ECGButton.SetActiveTextColor (RGB(255,0,0));;
	m_NIBPButton.SetActiveTextColor (RGB(255,0,0));;
	m_SpO2Button.SetActiveTextColor (RGB(255,0,0));;
	m_PTyeButton.SetActiveTextColor (RGB(255,0,0));;
	m_QuitButton.SetActiveTextColor (RGB(255,0,0));;
	m_DebugButton.SetActiveTextColor (RGB(255,0,0));

	m_ECGButton.SetNormalTextColor(RGB(0,0,155));
	m_NIBPButton.SetNormalTextColor(RGB(0,0,155));
	m_SpO2Button.SetNormalTextColor(RGB(0,0,155));
	m_PTyeButton.SetNormalTextColor(RGB(0,0,155));
	m_QuitButton.SetNormalTextColor(RGB(0,0,155));
	m_DebugButton.SetNormalTextColor(RGB(0,0,155));

	m_TimeButton.SetNormalTextColor(RGB(255,0,255));
	m_TimeButton.SetDrawBorderFlag(FALSE);
}

BOOL CMainDlg::OnEraseBkgnd(CDC* pDC)
{
	// TODO: 在此添加消息处理程序代码和/或调用默认值
	CDC dcMem;
	dcMem.CreateCompatibleDC(pDC);
	CBitmap *pOldBitmap = dcMem.SelectObject(&m_SleepMainBk);

	CRect rcClient;
	GetClientRect(&rcClient);
	pDC->BitBlt(rcClient.left,  rcClient.top, rcClient.Width(), rcClient.Height(),
		&dcMem, 0, 0, SRCCOPY);
	dcMem.SelectObject(pOldBitmap);
	dcMem.DeleteDC();
	return TRUE;

	return CDialog::OnEraseBkgnd(pDC);
}

void CMainDlg::SetCurrentTime(CString strTime)
{
	GetDlgItem(IDC_STATIC_TIME)->SetWindowText(strTime);
	GetDlgItem(IDC_BUTTON_TIME)->SetWindowText(strTime);
}

void CMainDlg::OnBnClickedButtonSetpatient()
{
	// TODO: 在此添加控件通知处理程序代码	
	CSetPatientDlg Dlg;
	Dlg.m_pDlg = m_pMultiParaDlg;
	Dlg.m_PatientTypeInfo = m_pMultiParaDlg->m_PatTypeInfo;

	if (Dlg.DoModal() == IDOK)
	{
		m_pMultiParaDlg->m_PatTypeInfo = Dlg.m_PatientTypeInfo;
	}
//////////////////////////////////////////////////////////////////////////
/*	CSetPatientDlg *pDlg;
	pDlg = new CSetPatientDlg(m_pMultiParaDlg);
	pDlg->Create(IDD_SETPATIENT_DIALOG,this);

	pDlg->ShowWindow(SW_SHOW);
	pDlg->CenterWindow();*/	
}

void CMainDlg::OnBnClickedButtonSetmenu()
{
	// TODO: 在此添加控件通知处理程序代码
	m_pMultiParaDlg->m_MenuNum = 0;

/*	GetDlgItem(IDC_BUTTON_SETMENU)->EnableWindow(FALSE);
	GetDlgItem(IDC_BUTTON_NBP)->EnableWindow(TRUE);
	GetDlgItem(IDC_BUTTON_SPO2)->EnableWindow(TRUE);*/
	m_ECGButton.SetNormalTextColor(RGB(0,155,0));
	m_NIBPButton.SetNormalTextColor(RGB(0,0,150));
	m_SpO2Button.SetNormalTextColor(RGB(0,0,150));

}

void CMainDlg::OnBnClickedButtonNbp()
{
	// TODO: 在此添加控件通知处理程序代码
	m_pMultiParaDlg->m_MenuNum = 1;
/*	GetDlgItem(IDC_BUTTON_NBP)->EnableWindow(FALSE);
	GetDlgItem(IDC_BUTTON_SETMENU)->EnableWindow(TRUE);
	GetDlgItem(IDC_BUTTON_SPO2)->EnableWindow(TRUE);*/

	m_ECGButton.SetNormalTextColor(RGB(0,0,150));
	m_NIBPButton.SetNormalTextColor(RGB(0,155,0));
	m_SpO2Button.SetNormalTextColor(RGB(0,0,150));

}

void CMainDlg::OnBnClickedButtonSpo2()
{
	// TODO: 在此添加控件通知处理程序代码
	m_pMultiParaDlg->m_MenuNum = 2;
/*	GetDlgItem(IDC_BUTTON_SPO2)->EnableWindow(FALSE);
	GetDlgItem(IDC_BUTTON_SETMENU)->EnableWindow(TRUE);
	GetDlgItem(IDC_BUTTON_NBP)->EnableWindow(TRUE);*/
	m_SpO2Button.SetNormalTextColor(RGB(0,155,0));
	m_NIBPButton.SetNormalTextColor(RGB(0,0,150));
	m_ECGButton.SetNormalTextColor(RGB(0,0,150));

}

void CMainDlg::OnBnClickedButtonDebuginfo()
{
	// TODO: 在此添加控件通知处理程序代码
	m_pMultiParaDlg->m_pDebugInfoDlg->ShowWindow(SW_SHOW);
}

void CMainDlg::FindCommPort(CComboBox *pComboBox)
{
	HKEY hKey;
#ifdef _DEBUG
	ASSERT( pComboBox != NULL );
	pComboBox->AssertValid();
#endif

	pComboBox->ResetContent();

	if( ::RegOpenKeyEx( HKEY_LOCAL_MACHINE,
		L"Hardware\\DeviceMap\\SerialComm",
		NULL,
		KEY_READ,
		&hKey) == ERROR_SUCCESS) // 打开串口注册表
	{
		int i=0;
		wchar_t portName[256],commName[256];
		DWORD dwLong,dwSize;
		while(1)
		{
			dwLong = dwSize = sizeof(portName);
			if( ::RegEnumValue( hKey,
				i,
				portName,
				&dwLong,
				NULL,
				NULL,
				(PUCHAR)commName,
				&dwSize ) == ERROR_NO_MORE_ITEMS ) // 枚举串口
				break;

			pComboBox->AddString( (CString)commName ); // commName就是串口名字
			i++;
		}
		RegCloseKey(hKey);

		if( pComboBox->GetCount() == 0 )
		{
			::AfxMessageBox(L"No valid COM-port!" );
		}
		else
		{
			pComboBox->SetCurSel(0);
		}
	}
}

void CMainDlg::OnCbnSelchangeComPort()
{
	// TODO: 在此添加控件通知处理程序代码
	CString str;
	m_ComboBoxPortList.GetWindowText(str);
	str.Delete(0,3);

	UCHAR Num = _ttoi(str);

	if (Num >=0)
	{
		m_pMultiParaDlg->SetCommPort(Num);
	}
}

void CMainDlg::OnCbnSetfocusComPort()
{
	// TODO: 在此添加控件通知处理程序代码
//	FindCommPort(&m_ComboBoxPortList);
}
