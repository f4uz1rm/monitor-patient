// DebugInfoDlg.cpp : 实现文件
//

#include "stdafx.h"
#include "Multi_Para Monitor.h"
#include "DebugInfoDlg.h"


// CDebugInfoDlg 对话框

IMPLEMENT_DYNAMIC(CDebugInfoDlg, CDialog)

CDebugInfoDlg::CDebugInfoDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CDebugInfoDlg::IDD, pParent)
{

}

CDebugInfoDlg::~CDebugInfoDlg()
{
}

void CDebugInfoDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	DDX_Control(pDX, IDC_STATIC_NIBP_CURRPRS, m_NbpRealPrs);
	DDX_Control(pDX, IDC_STATIC_NIBP_PATIENTTYPE, m_NBPPatientType);
	DDX_Control(pDX, IDC_STATIC_NIBP_MODE, m_NBPMode);
	DDX_Control(pDX, IDC_STATIC_NIBP_ERR, m_NBPErr);

	DDX_Control(pDX, IDC_STATIC_LEAD_SET_TXT, m_ctrlLeadSetTxt);
	DDX_Control(pDX, IDC_STATIC_LEAD_SET, m_ctrlLeadSet);

	DDX_Control(pDX, IDC_STATIC_ELECTRODE_TXT, m_ctrlElectrodeTxt);
	DDX_Control(pDX, IDC_STATIC_RA_OFF, m_ctrlRAOff);
	DDX_Control(pDX, IDC_STATIC_LA_OFF, m_ctrlLAOff);
	DDX_Control(pDX, IDC_STATIC_LL_OFF, m_ctrlLLOff);
	DDX_Control(pDX, IDC_STATIC_RL_OFF, m_ctrlRLOff);

	DDX_Control(pDX, IDC_STATIC_CHANNEL_EXIST_TXT, m_ctrlChannelExistTxt);
	DDX_Control(pDX, IDC_STATIC_CHI_EXIST, m_ctrlCHIExist);
	DDX_Control(pDX, IDC_STATIC_CHII_EXIST, m_ctrlCHIIExist);

	DDX_Control(pDX, IDC_STATIC_CHANNEL_OVLD_TXT, m_ctrlChannelOvldTxt);
	DDX_Control(pDX, IDC_STATIC_CHI_OVLD, m_ctrlCHIOvld);
	DDX_Control(pDX, IDC_STATIC_CHII_OVLD, m_ctrlCHIIOvld);
}


BEGIN_MESSAGE_MAP(CDebugInfoDlg, CDialog)
END_MESSAGE_MAP()


// CDebugInfoDlg 消息处理程序

BOOL CDebugInfoDlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	// TODO:  在此添加额外的初始化
	int WinRect_W = 600;
	int WinRect_H = 480;
	int start_H = 0;
	int PerContent_H = (WinRect_H-start_H)/4;
	MoveWindow(0,0,WinRect_W,WinRect_H);
	CenterWindow();

	int Nbp_W = WinRect_W/2;
	m_NbpRealPrs.MoveWindow(Nbp_W,0,Nbp_W,PerContent_H);
	m_NbpRealPrs.SetRegion(Nbp_W,PerContent_H);
	m_NbpRealPrs.SetTitle(L"Cuff Pressure");
	m_NbpRealPrs.SetContent(L"---");

	m_NBPPatientType.MoveWindow(Nbp_W,start_H+PerContent_H,Nbp_W,PerContent_H);
	m_NBPPatientType.SetRegion(Nbp_W,PerContent_H);
	m_NBPPatientType.SetTitle(L"Patient Type");
	m_NBPPatientType.SetContent(L"---");

	m_NBPMode.MoveWindow(Nbp_W,start_H+PerContent_H*2,Nbp_W,PerContent_H);
	m_NBPMode.SetRegion(Nbp_W,PerContent_H);
	m_NBPMode.SetTitle(L"Measuring Mode");
	m_NBPMode.SetContent(L"---");

	m_NBPErr.MoveWindow(Nbp_W,start_H+PerContent_H*3,Nbp_W,PerContent_H);
	m_NBPErr.SetRegion(Nbp_W,PerContent_H);
	m_NBPErr.SetTitle(L"Err Code");
	m_NBPErr.SetContent(L"---");
	
	//ECG

	int ECGPerContent_H = (WinRect_H-start_H)/9;
	int ECGWinRect_W = WinRect_W/2;
	// 导联模式
	GetDlgItem(IDC_STATIC_LEAD_SET_TXT)->MoveWindow(0, start_H, ECGWinRect_W, ECGPerContent_H);
	GetDlgItem(IDC_STATIC_LEAD_SET)->MoveWindow(0, start_H+ECGPerContent_H, ECGWinRect_W, ECGPerContent_H);

	// 电极状态
	GetDlgItem(IDC_STATIC_ELECTRODE_TXT)->MoveWindow(0, start_H + ECGPerContent_H*2, ECGWinRect_W, ECGPerContent_H);
	GetDlgItem(IDC_STATIC_RA_OFF)->MoveWindow(0, start_H+ ECGPerContent_H* 3, ECGWinRect_W/2, ECGPerContent_H);
	GetDlgItem(IDC_STATIC_LA_OFF)->MoveWindow(ECGWinRect_W/2, start_H+ ECGPerContent_H* 3, ECGWinRect_W/2, ECGPerContent_H);
	GetDlgItem(IDC_STATIC_LL_OFF)->MoveWindow(0, start_H+ ECGPerContent_H* 4, ECGWinRect_W/2, ECGPerContent_H);
	GetDlgItem(IDC_STATIC_RL_OFF)->MoveWindow(ECGWinRect_W/2, start_H+ ECGPerContent_H* 4, ECGWinRect_W/2, ECGPerContent_H);

	// 通道信号
	GetDlgItem(IDC_STATIC_CHANNEL_EXIST_TXT)->MoveWindow(0,start_H+ ECGPerContent_H* 5, ECGWinRect_W, ECGPerContent_H);
	GetDlgItem(IDC_STATIC_CHI_EXIST)->MoveWindow(0, start_H+ ECGPerContent_H* 6, ECGWinRect_W/2, ECGPerContent_H);
	GetDlgItem(IDC_STATIC_CHII_EXIST)->MoveWindow(ECGWinRect_W/2, start_H+ ECGPerContent_H* 6, ECGWinRect_W/2, ECGPerContent_H);

	// 通道饱和
	GetDlgItem(IDC_STATIC_CHANNEL_OVLD_TXT)->MoveWindow(0,start_H+ ECGPerContent_H* 7, ECGWinRect_W, ECGPerContent_H);
	GetDlgItem(IDC_STATIC_CHI_OVLD)->MoveWindow(0,start_H+ ECGPerContent_H* 8, ECGWinRect_W/2, ECGPerContent_H);
	GetDlgItem(IDC_STATIC_CHII_OVLD)->MoveWindow(ECGWinRect_W/2, start_H+ ECGPerContent_H* 8, ECGWinRect_W/2, ECGPerContent_H);

	// 导联模式
	m_ctrlLeadSetTxt.SetBkColor(RGB(0, 0, 0));
	m_ctrlLeadSetTxt.SetFont(_T("Waukegan LDO"), 16);
	m_ctrlLeadSetTxt.SetTextColor(RGB(0, 255, 0));
	m_ctrlLeadSetTxt.SetTextBkColor(RGB(0, 0, 0));

	m_ctrlLeadSet.SetBkColor(RGB(0, 0, 0));
	m_ctrlLeadSet.SetFont(_T("Waukegan LDO"), 14);
	m_ctrlLeadSet.SetTextColor(RGB(255, 255, 255));
	m_ctrlLeadSet.SetTextBkColor(RGB(0, 0, 0));

	// 电极状态
	m_ctrlElectrodeTxt.SetBkColor(RGB(0, 0, 0));
	m_ctrlElectrodeTxt.SetFont(_T("Waukegan LDO"), 16);
	m_ctrlElectrodeTxt.SetTextColor(RGB(0, 255, 0));
	m_ctrlElectrodeTxt.SetTextBkColor(RGB(0, 0, 0));

	m_ctrlRAOff.SetBkColor(RGB(0, 0, 0));
	m_ctrlRAOff.SetFont(_T("Waukegan LDO"), 14);
	m_ctrlRAOff.SetTextColor(RGB(255, 255, 255));
	m_ctrlRAOff.SetTextBkColor(RGB(0, 0, 0));
	m_ctrlRAOff.SetWindowTextW(_T("RA Unknown"));

	m_ctrlLAOff.SetBkColor(RGB(0, 0, 0));
	m_ctrlLAOff.SetFont(_T("Waukegan LDO"), 14);
	m_ctrlLAOff.SetTextColor(RGB(255, 255, 255));
	m_ctrlLAOff.SetTextBkColor(RGB(0, 0, 0));
	m_ctrlLAOff.SetWindowTextW(_T("LA Unknown"));

	m_ctrlLLOff.SetBkColor(RGB(0, 0, 0));
	m_ctrlLLOff.SetFont(_T("Waukegan LDO"), 14);
	m_ctrlLLOff.SetTextColor(RGB(255, 255, 255));
	m_ctrlLLOff.SetTextBkColor(RGB(0, 0, 0));
	m_ctrlLLOff.SetWindowTextW(_T("LL Unknown"));

	m_ctrlRLOff.SetBkColor(RGB(0, 0, 0));
	m_ctrlRLOff.SetFont(_T("Waukegan LDO"), 14);
	m_ctrlRLOff.SetTextColor(RGB(255, 255, 255));
	m_ctrlRLOff.SetTextBkColor(RGB(0, 0, 0));
	m_ctrlRLOff.SetWindowTextW(_T("RL Unknown"));

	// 通道信号状态
	m_ctrlChannelExistTxt.SetBkColor(RGB(0, 0, 0));
	m_ctrlChannelExistTxt.SetFont(_T("Waukegan LDO"), 16);
	m_ctrlChannelExistTxt.SetTextColor(RGB(0, 255, 0));
	m_ctrlChannelExistTxt.SetTextBkColor(RGB(0, 0, 0));

	m_ctrlCHIExist.SetBkColor(RGB(0, 0, 0));
	m_ctrlCHIExist.SetFont(_T("Waukegan LDO"), 14);
	m_ctrlCHIExist.SetTextColor(RGB(255, 255, 255));
	m_ctrlCHIExist.SetTextBkColor(RGB(0, 0, 0));
	m_ctrlCHIExist.SetWindowTextW(_T("CH I Unknown"));

	m_ctrlCHIIExist.SetBkColor(RGB(0, 0, 0));
	m_ctrlCHIIExist.SetFont(_T("Waukegan LDO"), 14);
	m_ctrlCHIIExist.SetTextColor(RGB(255, 255, 255));
	m_ctrlCHIIExist.SetTextBkColor(RGB(0, 0, 0));
	m_ctrlCHIIExist.SetWindowTextW(_T("CH II Unknown"));

	// 通道饱和状态
	m_ctrlChannelOvldTxt.SetBkColor(RGB(0, 0, 0));
	m_ctrlChannelOvldTxt.SetFont(_T("Waukegan LDO"), 16);
	m_ctrlChannelOvldTxt.SetTextColor(RGB(0, 255, 0));
	m_ctrlChannelOvldTxt.SetTextBkColor(RGB(0, 0, 0));

	m_ctrlCHIOvld.SetBkColor(RGB(0, 0, 0));
	m_ctrlCHIOvld.SetFont(_T("Waukegan LDO"), 14);
	m_ctrlCHIOvld.SetTextColor(RGB(255, 255, 255));
	m_ctrlCHIOvld.SetTextBkColor(RGB(0, 0, 0));
	m_ctrlCHIOvld.SetWindowTextW(_T("CH I Unknown"));

	m_ctrlCHIIOvld.SetBkColor(RGB(0, 0, 0));
	m_ctrlCHIIOvld.SetFont(_T("Waukegan LDO"), 14);
	m_ctrlCHIIOvld.SetTextColor(RGB(255, 255, 255));
	m_ctrlCHIIOvld.SetTextBkColor(RGB(0, 0, 0));
	m_ctrlCHIIOvld.SetWindowTextW(_T("CH II Unknown"));

	return TRUE;  // return TRUE unless you set the focus to a control
	// 异常: OCX 属性页应返回 FALSE
}

void CDebugInfoDlg::SetChannelOvldStatus(unsigned char uchOvldStatus)
{
	if ( uchOvldStatus & 0x01 ) {
		m_ctrlCHIOvld.SetWindowTextW(_T("CH I Overload"));
		m_ctrlCHIOvld.SetBkColor(RGB(0, 0, 0));
		m_ctrlCHIOvld.SetTextColor(RGB(255, 0, 0));
		m_ctrlCHIOvld.SetTextBkColor(RGB(0, 0, 0));
		m_ctrlCHIOvld.SetFont(_T("Waukegan LDO"), 14);
	}
	else {
		m_ctrlCHIOvld.SetWindowTextW(_T("CH I Normal"));
		m_ctrlCHIOvld.SetBkColor(RGB(0, 0, 0));
		m_ctrlCHIOvld.SetTextColor(RGB(0, 255, 0));
		m_ctrlCHIOvld.SetTextBkColor(RGB(0, 0, 0));
		m_ctrlCHIOvld.SetFont(_T("Waukegan LDO"), 14);
	}

	if ( uchOvldStatus & 0x02 ) {
		m_ctrlCHIIOvld.SetWindowTextW(_T("CH II Overload"));
		m_ctrlCHIIOvld.SetBkColor(RGB(0, 0, 0));
		m_ctrlCHIIOvld.SetTextColor(RGB(255, 0, 0));
		m_ctrlCHIIOvld.SetTextBkColor(RGB(0, 0, 0));
		m_ctrlCHIIOvld.SetFont(_T("Waukegan LDO"), 14);
	}
	else {
		m_ctrlCHIIOvld.SetWindowTextW(_T("CH II Normal"));
		m_ctrlCHIIOvld.SetBkColor(RGB(0, 0, 0));
		m_ctrlCHIIOvld.SetTextColor(RGB(0, 255, 0));
		m_ctrlCHIIOvld.SetTextBkColor(RGB(0, 0, 0));
		m_ctrlCHIIOvld.SetFont(_T("Waukegan LDO"), 14);
	}
}


void CDebugInfoDlg::SetLeadStatus(ECG_LEAD_MODE tLeadMode, unsigned char uchLeadRaLaLlOffFlag, unsigned char uchLeadVxOffFlag, unsigned char uchChannelExistFlag)
{
	switch ( tLeadMode ) {
	case ECG_LEAD_SYSTEM_SET_3:
		m_ctrlLeadSet.SetWindowTextW(_T("3 Lead Mode"));
		m_ctrlLeadSet.SetBkColor(RGB(0, 0, 0));
		m_ctrlLeadSet.SetTextColor(RGB(0, 255, 0));
		m_ctrlLeadSet.SetTextBkColor(RGB(0, 0, 0));
		m_ctrlLeadSet.SetFont(_T("Waukegan LDO"), 14);
		break;
	case ECG_LEAD_SYSTEM_SET_5:
		m_ctrlLeadSet.SetWindowTextW(_T("5 Lead Mode"));
		m_ctrlLeadSet.SetBkColor(RGB(0, 0, 0));
		m_ctrlLeadSet.SetTextColor(RGB(0, 255, 0));
		m_ctrlLeadSet.SetTextBkColor(RGB(0, 0, 0));
		m_ctrlLeadSet.SetFont(_T("Waukegan LDO"), 14);
		break;
	case ECG_LEAD_SYSTEM_SET_12:
		m_ctrlLeadSet.SetWindowTextW(_T("12 Lead Mode"));
		m_ctrlLeadSet.SetBkColor(RGB(0, 0, 0));
		m_ctrlLeadSet.SetTextColor(RGB(0, 255, 0));
		m_ctrlLeadSet.SetTextBkColor(RGB(0, 0, 0));
		m_ctrlLeadSet.SetFont(_T("Waukegan LDO"), 14);
		break;
	default:
		m_ctrlLeadSet.SetWindowTextW(_T("------"));
		m_ctrlLeadSet.SetBkColor(RGB(0, 0, 0));
		m_ctrlLeadSet.SetTextColor(RGB(255, 255, 255));
		m_ctrlLeadSet.SetTextBkColor(RGB(0, 0, 0));
		m_ctrlLeadSet.SetFont(_T("Waukegan LDO"), 14);
		break;
	}

	if ( uchLeadRaLaLlOffFlag & 0x01 ) {
		m_ctrlRAOff.SetWindowTextW(_T("RA ON"));
		m_ctrlRAOff.SetBkColor(RGB(0, 0, 0));
		m_ctrlRAOff.SetTextColor(RGB(0, 255, 0));
		m_ctrlRAOff.SetTextBkColor(RGB(0, 0, 0));
		m_ctrlRAOff.SetFont(_T("Waukegan LDO"), 14);
	}
	else {
		m_ctrlRAOff.SetWindowTextW(_T("RA OFF"));
		m_ctrlRAOff.SetBkColor(RGB(0, 0, 0));
		m_ctrlRAOff.SetTextColor(RGB(255, 0, 0));
		m_ctrlRAOff.SetTextBkColor(RGB(0, 0, 0));
		m_ctrlRAOff.SetFont(_T("Waukegan LDO"), 14);
	}

	if ( uchLeadRaLaLlOffFlag & 0x02 ) {
		m_ctrlLAOff.SetWindowTextW(_T("LA ON"));
		m_ctrlLAOff.SetBkColor(RGB(0, 0, 0));
		m_ctrlLAOff.SetTextColor(RGB(0, 255, 0));
		m_ctrlLAOff.SetTextBkColor(RGB(0, 0, 0));
		m_ctrlLAOff.SetFont(_T("Waukegan LDO"), 14);
	}
	else {
		m_ctrlLAOff.SetWindowTextW(_T("LA OFF"));
		m_ctrlLAOff.SetBkColor(RGB(0, 0, 0));
		m_ctrlLAOff.SetTextColor(RGB(255, 0, 0));
		m_ctrlLAOff.SetTextBkColor(RGB(0, 0, 0));
		m_ctrlLAOff.SetFont(_T("Waukegan LDO"), 14);
	}

	if ( uchLeadRaLaLlOffFlag & 0x04 ) {
		m_ctrlLLOff.SetWindowTextW(_T("LL ON"));
		m_ctrlLLOff.SetBkColor(RGB(0, 0, 0));
		m_ctrlLLOff.SetTextColor(RGB(0, 255, 0));
		m_ctrlLLOff.SetTextBkColor(RGB(0, 0, 0));
		m_ctrlLLOff.SetFont(_T("Waukegan LDO"), 14);
	}
	else {
		m_ctrlLLOff.SetWindowTextW(_T("LL OFF"));
		m_ctrlLLOff.SetBkColor(RGB(0, 0, 0));
		m_ctrlLLOff.SetTextColor(RGB(255, 0, 0));
		m_ctrlLLOff.SetTextBkColor(RGB(0, 0, 0));
		m_ctrlLLOff.SetFont(_T("Waukegan LDO"), 14);
	}

	if ( uchLeadRaLaLlOffFlag & 0x08 ) {
		m_ctrlRLOff.SetWindowTextW(_T("RL ON"));
		m_ctrlRLOff.SetBkColor(RGB(0, 0, 0));
		m_ctrlRLOff.SetTextColor(RGB(0, 255, 0));
		m_ctrlRLOff.SetTextBkColor(RGB(0, 0, 0));
		m_ctrlRLOff.SetFont(_T("Waukegan LDO"), 14);
	}
	else {
		m_ctrlRLOff.SetWindowTextW(_T("RL OFF"));
		m_ctrlRLOff.SetBkColor(RGB(0, 0, 0));
		m_ctrlRLOff.SetTextColor(RGB(255, 0, 0));
		m_ctrlRLOff.SetTextBkColor(RGB(0, 0, 0));
		m_ctrlRLOff.SetFont(_T("Waukegan LDO"), 14);
	}


	if ( uchChannelExistFlag & 0x01 ) {
		m_ctrlCHIExist.SetWindowTextW(_T("CH I ON"));
		m_ctrlCHIExist.SetBkColor(RGB(0, 0, 0));
		m_ctrlCHIExist.SetTextColor(RGB(0, 255, 0));
		m_ctrlCHIExist.SetTextBkColor(RGB(0, 0, 0));
		m_ctrlCHIExist.SetFont(_T("Waukegan LDO"), 14);
	}
	else {
		m_ctrlCHIExist.SetWindowTextW(_T("CH I OFF"));
		m_ctrlCHIExist.SetBkColor(RGB(0, 0, 0));
		m_ctrlCHIExist.SetTextColor(RGB(255, 0, 0));
		m_ctrlCHIExist.SetTextBkColor(RGB(0, 0, 0));
		m_ctrlCHIExist.SetFont(_T("Waukegan LDO"), 14);
	}

	if ( uchChannelExistFlag & 0x02 ) {
		m_ctrlCHIIExist.SetWindowTextW(_T("CH II ON"));
		m_ctrlCHIIExist.SetBkColor(RGB(0, 0, 0));
		m_ctrlCHIIExist.SetTextColor(RGB(0, 255, 0));
		m_ctrlCHIIExist.SetTextBkColor(RGB(0, 0, 0));
		m_ctrlCHIIExist.SetFont(_T("Waukegan LDO"), 14);
	}
	else {
		m_ctrlCHIIExist.SetWindowTextW(_T("CH II OFF"));
		m_ctrlCHIIExist.SetBkColor(RGB(0, 0, 0));
		m_ctrlCHIIExist.SetTextColor(RGB(255, 0, 0));
		m_ctrlCHIIExist.SetTextBkColor(RGB(0, 0, 0));
		m_ctrlCHIIExist.SetFont(_T("Waukegan LDO"), 14);
	}
}

