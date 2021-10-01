// Multi_Para MonitorDlg.cpp : 实现文件
//

#include "stdafx.h"
#include "Multi_Para Monitor.h"
#include "Multi_Para MonitorDlg.h"
#include "SetPatientDlg.h"
#include "NbpCaliDlg.h"
#include "SetPatientDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// 用于应用程序“关于”菜单项的 CAboutDlg 对话框

class CAboutDlg : public CDialog
{
public:
	CAboutDlg();

// 对话框数据
	enum { IDD = IDD_ABOUTBOX };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV 支持

// 实现
protected:
	DECLARE_MESSAGE_MAP()
};

CAboutDlg::CAboutDlg() : CDialog(CAboutDlg::IDD)
{
}

void CAboutDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CAboutDlg, CDialog)
END_MESSAGE_MAP()


// CMulti_ParaMonitorDlg 对话框




CMulti_ParaMonitorDlg::CMulti_ParaMonitorDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CMulti_ParaMonitorDlg::IDD, pParent)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);

	m_pcComPort = NULL;
	m_pcComWatchThread = NULL;
}

void CMulti_ParaMonitorDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	DDX_Control(pDX, IDC_STATIC_SPO2WAVE, m_SpO2Wave);
	DDX_Control(pDX, IDC_PROGRESS_SPO2, m_SpO2Bar);
	DDX_Control(pDX, IDC_STATIC_SPO2INFO, m_SpO2Info);
	DDX_Control(pDX, IDC_STATIC_RESPWAVE, m_RespWave);
	DDX_Control(pDX, IDC_STATIC_ECG1, m_pEcgWave[0]);
	DDX_Control(pDX, IDC_STATIC_ECG2, m_pEcgWave[1]);
	DDX_Control(pDX, IDC_STATIC_ECG3, m_pEcgWave[2]);
	DDX_Control(pDX, IDC_STATIC_ECG4, m_pEcgWave[3]);
	DDX_Control(pDX, IDC_STATIC_ECG5, m_pEcgWave[4]);
	DDX_Control(pDX, IDC_STATIC_ECG6, m_pEcgWave[5]);
	DDX_Control(pDX, IDC_STATIC_ECGINFO, m_EcgInfo);
	DDX_Control(pDX, IDC_STATIC_RESPINFO, m_RespInfo);
	DDX_Control(pDX, IDC_STATIC_TEMPINFO, m_TempInfo);
	DDX_Control(pDX, IDC_STATIC_NIBP, m_NibpInfo);

}

BEGIN_MESSAGE_MAP(CMulti_ParaMonitorDlg, CDialog)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	//}}AFX_MSG_MAP
	ON_WM_RBUTTONDOWN()
	ON_WM_LBUTTONDOWN()
	ON_COMMAND(ID_SET_LAYOUT_3D, &CMulti_ParaMonitorDlg::OnSetLayout3d)
	ON_COMMAND(ID_SET_LAYOUT_5D, &CMulti_ParaMonitorDlg::OnSetLayout5d)
	ON_COMMAND(ID_SET_FILTER_DIAG, &CMulti_ParaMonitorDlg::OnSetFilterDiag)
	ON_COMMAND(ID_SET_FILTER_MONITOR, &CMulti_ParaMonitorDlg::OnSetFilterMonitor)
	ON_COMMAND(ID_SET_FILTER_HARDEST, &CMulti_ParaMonitorDlg::OnSetFilterHardest)
	ON_COMMAND(ID_SET_FILTER_SURGERY, &CMulti_ParaMonitorDlg::OnSetFilterSurgery)
	ON_COMMAND(ID_SET_50HZ_TRAP, &CMulti_ParaMonitorDlg::OnSet50hzTrap)
	ON_COMMAND(ID_SET_60HZ_TRAP, &CMulti_ParaMonitorDlg::OnSet60hzTrap)
	ON_COMMAND(ID_SET_5060HZ_TRAP, &CMulti_ParaMonitorDlg::OnSet5060hzTrap)
	ON_COMMAND(ID_SET_NO_TRAP, &CMulti_ParaMonitorDlg::OnSetNoTrap)
	ON_COMMAND(ID_SET_HR_AUTO, &CMulti_ParaMonitorDlg::OnSetHrAuto)
	ON_COMMAND(ID_SET_HR_CHI, &CMulti_ParaMonitorDlg::OnSetHrChi)
	ON_COMMAND(ID_SET_HR_CHII, &CMulti_ParaMonitorDlg::OnSetHrChii)
	ON_COMMAND(ID_ENABLE_PACE_DETECTION, &CMulti_ParaMonitorDlg::OnEnablePaceDetection)
	ON_COMMAND(ID_DISABLE_PACE_DETECTION, &CMulti_ParaMonitorDlg::OnDisablePaceDetection)
	ON_COMMAND(ID_START_ECG_CAL, &CMulti_ParaMonitorDlg::OnStartEcgCal)
	ON_COMMAND(ID_STOP_ECG_CAL, &CMulti_ParaMonitorDlg::OnStopEcgCal)
	ON_COMMAND(ID_SET_PACE_LEAD_I, &CMulti_ParaMonitorDlg::OnSetPaceLeadI)
	ON_COMMAND(ID_SET_PACE_LEAD_II, &CMulti_ParaMonitorDlg::OnSetPaceLeadIi)
	ON_COMMAND(ID_SET_PACE_LEAD_III, &CMulti_ParaMonitorDlg::OnSetPaceLeadIii)
	ON_COMMAND(ID_SET_PACE_LEAD_AVL, &CMulti_ParaMonitorDlg::OnSetPaceLeadAvl)
	ON_COMMAND(ID_SET_PACE_LEAD_AVR, &CMulti_ParaMonitorDlg::OnSetPaceLeadAvr)
	ON_COMMAND(ID_SET_PACE_LEAD_AVF, &CMulti_ParaMonitorDlg::OnSetPaceLeadAvf)
	ON_COMMAND(ID_SET_APNEA_TIME_5S, &CMulti_ParaMonitorDlg::OnSetApneaTime5s)
	ON_COMMAND(ID_SET_APNEA_TIME_10S, &CMulti_ParaMonitorDlg::OnSetApneaTime10s)
	ON_COMMAND(ID_SET_APNEA_TIME_15S, &CMulti_ParaMonitorDlg::OnSetApneaTime15s)
	ON_COMMAND(ID_SET_RESP_LEAD_I, &CMulti_ParaMonitorDlg::OnSetRespLeadI)
	ON_COMMAND(ID_SET_RESP_LEAD_II, &CMulti_ParaMonitorDlg::OnSetRespLeadIi)
	ON_COMMAND(ID_SET_RESP_SENSITIVITY_1, &CMulti_ParaMonitorDlg::OnSetRespSensitivity1)
	ON_COMMAND(ID_SET_RESP_SENSITIVITY_2, &CMulti_ParaMonitorDlg::OnSetRespSensitivity2)
	ON_COMMAND(ID_SET_RESP_SENSITIVITY_3, &CMulti_ParaMonitorDlg::OnSetRespSensitivity3)
	ON_COMMAND(ID_SET_RESP_SENSITIVITY_4, &CMulti_ParaMonitorDlg::OnSetRespSensitivity4)
	ON_COMMAND(ID_SET_RESP_SENSITIVITY_5, &CMulti_ParaMonitorDlg::OnSetRespSensitivity5)
	ON_COMMAND(ID_SET_GAIN_CHALL_X250, &CMulti_ParaMonitorDlg::OnSetGainChallX250)
	ON_COMMAND(ID_SET_GAIN_CHALL_X500, &CMulti_ParaMonitorDlg::OnSetGainChallX500)
	ON_COMMAND(ID_SET_GAIN_CHALL_X1000, &CMulti_ParaMonitorDlg::OnSetGainChallX1000)
	ON_COMMAND(ID_SET_GAIN_CHALL_X2000, &CMulti_ParaMonitorDlg::OnSetGainChallX2000)
	ON_COMMAND(ID_SET_SCAN_SPEED_ECG_2MS, &CMulti_ParaMonitorDlg::OnSetScanSpeedEcg2ms)
	ON_COMMAND(ID_SET_SCAN_SPEED_ECG_4MS, &CMulti_ParaMonitorDlg::OnSetScanSpeedEcg4ms)
	ON_COMMAND(ID_SET_SCAN_SPEED_ECG_10MS, &CMulti_ParaMonitorDlg::OnSetScanSpeedEcg10ms)
	ON_COMMAND(ID_SET_SCAN_SPEED_RESP_2MS, &CMulti_ParaMonitorDlg::OnSetScanSpeedResp2ms)
	ON_COMMAND(ID_SET_SCAN_SPEED_RESP_4MS, &CMulti_ParaMonitorDlg::OnSetScanSpeedResp4ms)
	ON_COMMAND(ID_SET_SCAN_SPEED_RESP_10MS, &CMulti_ParaMonitorDlg::OnSetScanSpeedResp10ms)
	ON_COMMAND(ID_SET_SCAN_SPEED_RESP_20MS, &CMulti_ParaMonitorDlg::OnSetScanSpeedResp20ms)
	ON_COMMAND(ID_SpPO2_SELT_TEST, &CMulti_ParaMonitorDlg::OnSppo2SeltTest)
	ON_COMMAND(ID_SPO2_SENSTIVITY_1, &CMulti_ParaMonitorDlg::OnSpo2Senstivity1)
	ON_COMMAND(ID_SPO2_SENSTIVITY_2, &CMulti_ParaMonitorDlg::OnSpo2Senstivity2)
	ON_COMMAND(ID_SPO2_SENSTIVITY_3, &CMulti_ParaMonitorDlg::OnSpo2Senstivity3)
	ON_COMMAND(ID_SPO2_SENSTIVITY_4, &CMulti_ParaMonitorDlg::OnSpo2Senstivity4)
	ON_COMMAND(ID_MODULEINFO, &CMulti_ParaMonitorDlg::OnModuleinfo)
	ON_COMMAND(ID_SPO2MODULE_UPDATE, &CMulti_ParaMonitorDlg::OnSpo2moduleUpdate)
	ON_COMMAND(ID_NBP_START, &CMulti_ParaMonitorDlg::OnNbpStart)
	ON_COMMAND(ID_NIBP_STOP, &CMulti_ParaMonitorDlg::OnNibpStop)
	ON_COMMAND(ID_NBP_SET_MEASURE_MODE_MANUAL, &CMulti_ParaMonitorDlg::OnNbpSetMeasureModeManual)
	ON_COMMAND(ID_NBP_SET_MEASURE_MODE_CONT, &CMulti_ParaMonitorDlg::OnNbpSetMeasureModeCont)
	ON_COMMAND(ID_NBP_SET_MEASURE_MODE_AUTO_1MIN, &CMulti_ParaMonitorDlg::OnNbpSetMeasureModeAuto1min)
	ON_COMMAND(ID_NBP_SET_MEASURE_MODE_AUTO_2MIN, &CMulti_ParaMonitorDlg::OnNbpSetMeasureModeAuto2min)
	ON_COMMAND(ID_NBP_SET_MEASURE_MODE_AUTO_3MIN, &CMulti_ParaMonitorDlg::OnNbpSetMeasureModeAuto3min)
	ON_COMMAND(ID_NBP_SET_MEASURE_MODE_AUTO_4MIN, &CMulti_ParaMonitorDlg::OnNbpSetMeasureModeAuto4min)
	ON_COMMAND(ID_NBP_SET_MEASURE_MODE_AUTO_5MIN, &CMulti_ParaMonitorDlg::OnNbpSetMeasureModeAuto5min)
	ON_COMMAND(ID_NBP_SET_MEASURE_MODE_AUTO_10MIN, &CMulti_ParaMonitorDlg::OnNbpSetMeasureModeAuto10min)
	ON_COMMAND(ID_NBP_SET_MEASURE_MODE_AUTO_15MIN, &CMulti_ParaMonitorDlg::OnNbpSetMeasureModeAuto15min)
	ON_COMMAND(ID_32940, &CMulti_ParaMonitorDlg::On32940)
	ON_COMMAND(ID_NBP_SET_MEASURE_MODE_AUTO_60MIN, &CMulti_ParaMonitorDlg::OnNbpSetMeasureModeAuto60min)
	ON_COMMAND(ID_NBP_SET_MEASURE_MODE_AUTO_90MIN, &CMulti_ParaMonitorDlg::OnNbpSetMeasureModeAuto90min)
	ON_COMMAND(ID_NBP_SET_MEASURE_MODE_AUTO_2HOUR, &CMulti_ParaMonitorDlg::OnNbpSetMeasureModeAuto2hour)
	ON_COMMAND(ID_NBP_SET_MEASURE_MODE_AUTO_3HOUR, &CMulti_ParaMonitorDlg::OnNbpSetMeasureModeAuto3hour)
	ON_COMMAND(ID_NBP_SET_MEASURE_MODE_AUTO_4HOUR, &CMulti_ParaMonitorDlg::OnNbpSetMeasureModeAuto4hour)
	ON_COMMAND(ID_NBP_SET_MEASURE_MODE_AUTO_8HOUR, &CMulti_ParaMonitorDlg::OnNbpSetMeasureModeAuto8hour)
	ON_COMMAND(ID_SET_PREINFLATE_ADULT_80MMHG, &CMulti_ParaMonitorDlg::OnSetPreinflateAdult80mmhg)
	ON_COMMAND(ID_SET_PREINFLATE_ADULT_100MMHG, &CMulti_ParaMonitorDlg::OnSetPreinflateAdult100mmhg)
	ON_COMMAND(ID_SET_PREINFLATE_ADULT_120MMHG, &CMulti_ParaMonitorDlg::OnSetPreinflateAdult120mmhg)
	ON_COMMAND(ID_SET_PREINFLATE_ADULT_140MMHG, &CMulti_ParaMonitorDlg::OnSetPreinflateAdult140mmhg)
	ON_COMMAND(ID_SET_PREINFLATE_ADULT_150MMHG, &CMulti_ParaMonitorDlg::OnSetPreinflateAdult150mmhg)
	ON_COMMAND(ID_SET_PREINFLATE_ADULT_160MMHG, &CMulti_ParaMonitorDlg::OnSetPreinflateAdult160mmhg)
	ON_COMMAND(ID_SET_PREINFLATE_ADULT_180MMHG, &CMulti_ParaMonitorDlg::OnSetPreinflateAdult180mmhg)
	ON_COMMAND(ID_SET_PREINFLATE_ADULT_200MMHG, &CMulti_ParaMonitorDlg::OnSetPreinflateAdult200mmhg)
	ON_COMMAND(ID_SET_PREINFLATE_ADULT_220MMHG, &CMulti_ParaMonitorDlg::OnSetPreinflateAdult220mmhg)
	ON_COMMAND(ID_SET_PREINFLATE_ADULT_240MMHG, &CMulti_ParaMonitorDlg::OnSetPreinflateAdult240mmhg)
	ON_COMMAND(ID_SET_PREINFLATE_ADULT_250MMHG, &CMulti_ParaMonitorDlg::OnSetPreinflateAdult250mmhg)
	ON_COMMAND(ID_SET_PREINFLATE_ADULT_260MMHG, &CMulti_ParaMonitorDlg::OnSetPreinflateAdult260mmhg)
	ON_COMMAND(ID_SET_PREINFLATE_ADULT_270MMHG, &CMulti_ParaMonitorDlg::OnSetPreinflateAdult270mmhg)
	ON_COMMAND(ID_SET_PREINFLATE_ADULT_280MMHG, &CMulti_ParaMonitorDlg::OnSetPreinflateAdult280mmhg)
	ON_COMMAND(ID_SET_PREINFLATE_CHILD_80MMHG, &CMulti_ParaMonitorDlg::OnSetPreinflateChild80mmhg)
	ON_COMMAND(ID_SET_PREINFLATE_CHILD_100MMHG, &CMulti_ParaMonitorDlg::OnSetPreinflateChild100mmhg)
	ON_COMMAND(ID_SET_PREINFLATE_CHILD_120MMHG, &CMulti_ParaMonitorDlg::OnSetPreinflateChild120mmhg)
	ON_COMMAND(ID_SET_PREINFLATE_CHILD_140MMHG, &CMulti_ParaMonitorDlg::OnSetPreinflateChild140mmhg)
	ON_COMMAND(ID_SET_PREINFLATE_CHILD_160MMHG, &CMulti_ParaMonitorDlg::OnSetPreinflateChild160mmhg)
	ON_COMMAND(ID_SET_PREINFLATE_CHILD_180MMHG, &CMulti_ParaMonitorDlg::OnSetPreinflateChild180mmhg)
	ON_COMMAND(ID_SET_PREINFLATE_CHILD_200MMHG, &CMulti_ParaMonitorDlg::OnSetPreinflateChild200mmhg)
	ON_COMMAND(ID_SET_PREINFLATE_NEON_60MMHG, &CMulti_ParaMonitorDlg::OnSetPreinflateNeon60mmhg)
	ON_COMMAND(ID_SET_PREINFLATE_NEON_80MMHG, &CMulti_ParaMonitorDlg::OnSetPreinflateNeon80mmhg)
	ON_COMMAND(ID_SET_PREINFLATE_NEON_100MMHG, &CMulti_ParaMonitorDlg::OnSetPreinflateNeon100mmhg)
	ON_COMMAND(ID_SET_PREINFLATE_NEON_120MMHG, &CMulti_ParaMonitorDlg::OnSetPreinflateNeon120mmhg)
	ON_COMMAND(ID_NBP_START_CHECK_LEAK, &CMulti_ParaMonitorDlg::OnNbpStartCheckLeak)
	ON_COMMAND(ID_NBP_START_VENIPUNCTURE, &CMulti_ParaMonitorDlg::OnNbpStartVenipuncture)
	ON_COMMAND(ID_SET_VENIPUNCTURE_ADULT_22MMHG, &CMulti_ParaMonitorDlg::OnSetVenipunctureAdult22mmhg)
	ON_COMMAND(ID_SET_VENIPUNCTURE_ADULT_32MMHG, &CMulti_ParaMonitorDlg::OnSetVenipunctureAdult32mmhg)
	ON_COMMAND(ID_SET_VENIPUNCTURE_ADULT_42MMHG, &CMulti_ParaMonitorDlg::OnSetVenipunctureAdult42mmhg)
	ON_COMMAND(ID_SET_VENIPUNCTURE_ADULT_52MMHG, &CMulti_ParaMonitorDlg::OnSetVenipunctureAdult52mmhg)
	ON_COMMAND(ID_SET_VENIPUNCTURE_ADULT_62MMHG, &CMulti_ParaMonitorDlg::OnSetVenipunctureAdult62mmhg)
	ON_COMMAND(ID_SET_VENIPUNCTURE_ADULT_72MMHG, &CMulti_ParaMonitorDlg::OnSetVenipunctureAdult72mmhg)
	ON_COMMAND(ID_SET_VENIPUNCTURE_ADULT_82MMHG, &CMulti_ParaMonitorDlg::OnSetVenipunctureAdult82mmhg)
	ON_COMMAND(ID_SET_VENIPUNCTURE_ADULT_92MMHG, &CMulti_ParaMonitorDlg::OnSetVenipunctureAdult92mmhg)
	ON_COMMAND(ID_SET_VENIPUNCTURE_ADULT_102MMHG, &CMulti_ParaMonitorDlg::OnSetVenipunctureAdult102mmhg)
	ON_COMMAND(ID_SET_VENIPUNCTURE_ADULT_112MMHG, &CMulti_ParaMonitorDlg::OnSetVenipunctureAdult112mmhg)
	ON_COMMAND(ID_SET_VENIPUNCTURE_ADULT_122MMHG, &CMulti_ParaMonitorDlg::OnSetVenipunctureAdult122mmhg)
	ON_COMMAND(ID_SET_VENIPUNCTURE_CHILD_22MMHG, &CMulti_ParaMonitorDlg::OnSetVenipunctureChild22mmhg)
	ON_COMMAND(ID_SET_VENIPUNCTURE_CHILD_32MMHG, &CMulti_ParaMonitorDlg::OnSetVenipunctureChild32mmhg)
	ON_COMMAND(ID_SET_VENIPUNCTURE_CHILD_42MMHG, &CMulti_ParaMonitorDlg::OnSetVenipunctureChild42mmhg)
	ON_COMMAND(ID_SET_VENIPUNCTURE_CHILD_52MMHG, &CMulti_ParaMonitorDlg::OnSetVenipunctureChild52mmhg)
	ON_COMMAND(ID_SET_VENIPUNCTURE_CHILD_62MMHG, &CMulti_ParaMonitorDlg::OnSetVenipunctureChild62mmhg)
	ON_COMMAND(ID_SET_VENIPUNCTURE_CHILD_72MMHG, &CMulti_ParaMonitorDlg::OnSetVenipunctureChild72mmhg)
	ON_COMMAND(ID_SET_VENIPUNCTURE_CHILD_82MMHG, &CMulti_ParaMonitorDlg::OnSetVenipunctureChild82mmhg)
	ON_COMMAND(ID_SET_VENIPUNCTURE_NEON_22MMHG, &CMulti_ParaMonitorDlg::OnSetVenipunctureNeon22mmhg)
	ON_COMMAND(ID_SET_VENIPUNCTURE_NEON_32MMHG, &CMulti_ParaMonitorDlg::OnSetVenipunctureNeon32mmhg)
	ON_COMMAND(ID_SET_VENIPUNCTURE_NEON_42MMHG, &CMulti_ParaMonitorDlg::OnSetVenipunctureNeon42mmhg)
	ON_COMMAND(ID_SET_VENIPUNCTURE_NEON_52MMHG, &CMulti_ParaMonitorDlg::OnSetVenipunctureNeon52mmhg)
	ON_COMMAND(ID_NBP_RESET, &CMulti_ParaMonitorDlg::OnNbpReset)
	ON_COMMAND(ID_SET_PATIENTTYPE, &CMulti_ParaMonitorDlg::OnSetPatienttype)
	ON_COMMAND(ID_SPO2_PATIENTTYPE, &CMulti_ParaMonitorDlg::OnSpo2Patienttype)
	ON_COMMAND(ID_ECG_PATIENTTYPE, &CMulti_ParaMonitorDlg::OnEcgPatienttype)
	ON_COMMAND(ID_ENABLE_SOFT_PROTECT, &CMulti_ParaMonitorDlg::OnEnableSoftProtect)
	ON_COMMAND(ID_DISABLE_SOFT_PROTECT, &CMulti_ParaMonitorDlg::OnDisableSoftProtect)
	ON_COMMAND(ID_NIBP_MODULE_INFO, &CMulti_ParaMonitorDlg::OnNibpModuleInfo)
	ON_COMMAND(ID_REQUEST_TEST_RESULT, &CMulti_ParaMonitorDlg::OnRequestTestResult)
	ON_COMMAND(ID_REQUEST_POST_RESULT, &CMulti_ParaMonitorDlg::OnRequestPostResult)
	ON_COMMAND(ID_REQUEST_CUFF_PRS, &CMulti_ParaMonitorDlg::OnRequestCuffPrs)
	ON_COMMAND(ID_NIBP_PRSCALIBRATE, &CMulti_ParaMonitorDlg::OnNibpPrscalibrate)
	ON_COMMAND(ID_UPDATE, &CMulti_ParaMonitorDlg::OnUpdate)
	ON_COMMAND(ID_NBP_START_UPDATE, &CMulti_ParaMonitorDlg::OnNbpStartUpdate)
	ON_COMMAND(ID_SETTINGAPNEATIME_20S, &CMulti_ParaMonitorDlg::OnSettingapneatime20s)
	ON_COMMAND(ID_CHANNELI_LEADI, &CMulti_ParaMonitorDlg::OnChanneliLeadi)
	ON_COMMAND(ID_CHANNELI_LEADII, &CMulti_ParaMonitorDlg::OnChanneliLeadii)
	ON_COMMAND(ID_CHANNELI_LEADIII, &CMulti_ParaMonitorDlg::OnChanneliLeadiii)
	ON_COMMAND(ID_CHANNELI_LEADAVR, &CMulti_ParaMonitorDlg::OnChanneliLeadavr)
	ON_COMMAND(ID_CHANNELI_LEADAVL, &CMulti_ParaMonitorDlg::OnChanneliLeadavl)
	ON_COMMAND(ID_CHANNELI_LEADAVF, &CMulti_ParaMonitorDlg::OnChanneliLeadavf)
	ON_COMMAND(ID_CHANNELII_LEADI, &CMulti_ParaMonitorDlg::OnChanneliiLeadi)
	ON_COMMAND(ID_CHANNELII_LEADII, &CMulti_ParaMonitorDlg::OnChanneliiLeadii)
	ON_COMMAND(ID_CHANNELII_LEADIII, &CMulti_ParaMonitorDlg::OnChanneliiLeadiii)
	ON_COMMAND(ID_CHANNELII_LEADAVR, &CMulti_ParaMonitorDlg::OnChanneliiLeadavr)
	ON_COMMAND(ID_CHANNELII_LEADAVL, &CMulti_ParaMonitorDlg::OnChanneliiLeadavl)
	ON_COMMAND(ID_CHANNELII_LEADAVF, &CMulti_ParaMonitorDlg::OnChanneliiLeadavf)
	END_MESSAGE_MAP()


// CMulti_ParaMonitorDlg 消息处理程序

BOOL CMulti_ParaMonitorDlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	// 将“关于...”菜单项添加到系统菜单中。

	// IDM_ABOUTBOX 必须在系统命令范围内。
	ASSERT((IDM_ABOUTBOX & 0xFFF0) == IDM_ABOUTBOX);
	ASSERT(IDM_ABOUTBOX < 0xF000);

	CMenu* pSysMenu = GetSystemMenu(FALSE);
	if (pSysMenu != NULL)
	{
		CString strAboutMenu;
		strAboutMenu.LoadString(IDS_ABOUTBOX);
		if (!strAboutMenu.IsEmpty())
		{
			pSysMenu->AppendMenu(MF_SEPARATOR);
			pSysMenu->AppendMenu(MF_STRING, IDM_ABOUTBOX, strAboutMenu);
		}
	}

	// 设置此对话框的图标。当应用程序主窗口不是对话框时，框架将自动
	//  执行此操作
	SetIcon(m_hIcon, TRUE);			// 设置大图标
	SetIcon(m_hIcon, FALSE);		// 设置小图标

	// TODO: 在此添加额外的初始化代码
	InitVari();
	InitTheWindow();
	InitCommPort();
	
	MenuDefaultSel();

	return TRUE;  // 除非将焦点设置到控件，否则返回 TRUE
}

void CMulti_ParaMonitorDlg::OnSysCommand(UINT nID, LPARAM lParam)
{
	if ((nID & 0xFFF0) == IDM_ABOUTBOX)
	{
		CAboutDlg dlgAbout;
		dlgAbout.DoModal();
	}
	else
	{
		CDialog::OnSysCommand(nID, lParam);
	}
}

// 如果向对话框添加最小化按钮，则需要下面的代码
//  来绘制该图标。对于使用文档/视图模型的 MFC 应用程序，
//  这将由框架自动完成。

void CMulti_ParaMonitorDlg::OnPaint()
{
	if (IsIconic())
	{
		CPaintDC dc(this); // 用于绘制的设备上下文

		SendMessage(WM_ICONERASEBKGND, reinterpret_cast<WPARAM>(dc.GetSafeHdc()), 0);

		// 使图标在工作区矩形中居中
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// 绘制图标
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialog::OnPaint();
	}
}

//当用户拖动最小化窗口时系统调用此函数取得光标
//显示。
HCURSOR CMulti_ParaMonitorDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}

void CMulti_ParaMonitorDlg::RcvData(ZUGMED_PACKET tPacket)
{
	if (PARAM_ECG == tPacket.u8ParaType)
	{
		RcvEcgData(tPacket);
	} 
	else if (PARAM_SPO2 == tPacket.u8ParaType)
	{
		RcvSpO2Data(tPacket);
	}
	else if (PARAM_NBP == tPacket.u8ParaType)
	{
		RcvNIBPData(tPacket);
	}
}

void CMulti_ParaMonitorDlg::RcvSpO2Data(ZUGMED_PACKET tZugMedPacket)
{
	if (ZUGMED_PACKET_TYPE_DD == tZugMedPacket.u8Type)
	{
		if (tZugMedPacket.u8Id == ZUGMED_RESPONSE_RT_PLS)
		{
			unsigned int uiPls = tZugMedPacket.pu8Data[0];
			unsigned int uiPulseBeep = tZugMedPacket.pu8Data[1];
			unsigned int uiBarGraph = tZugMedPacket.pu8Data[2];

			m_SpO2Wave.RcvOneData(uiPls);
			m_SpO2Bar.SetPos(uiBarGraph*5);
		}
		else if (tZugMedPacket.u8Id == ZUGMED_RESPONSE_RESULT)
		{
			unsigned int uiPulseRate;
			unsigned char ucSpO2;
			unsigned int uiPi;
			unsigned char ucStatu1;
			unsigned char ucStatu2;

			uiPulseRate = tZugMedPacket.pu8Data[0] + (tZugMedPacket.pu8Data[1] << 8);
			ucSpO2      = tZugMedPacket.pu8Data[2];
			uiPi        = tZugMedPacket.pu8Data[3] + (tZugMedPacket.pu8Data[4] << 8);
			ucStatu1    = tZugMedPacket.pu8Data[5];
			ucStatu2    = tZugMedPacket.pu8Data[6];
			
			m_SpO2Info.SetSpO2Info(ucSpO2,uiPulseRate,uiPi,ucStatu1,ucStatu2);
			m_SpO2Wave.SetSpO2Status(ucStatu1,ucStatu2);
		}
		else if (tZugMedPacket.u8Id == ZUGMED_RESPONSE_CONNECT_ACK)
		{
			SndStartCmd();
		}
	}
	else if (ZUGMED_PACKET_TYPE_DA == tZugMedPacket.u8Type)
	{
		if (tZugMedPacket.u8Id == ZUGMED_RESPONSE_SELF_TEST_INFO)
		{

		}
		else if (tZugMedPacket.u8Id == ZUGMED_RESPONSE_MODULE_INFO)
		{

		}
	}
}

void CMulti_ParaMonitorDlg::RcvEcgData(ZUGMED_PACKET tPacket)
{
	switch ( tPacket.u8Id ) 
	{
		case ZUGMED_PACKET_ID_DATA_ECG_RESP_WAVE:
			HandlePacketUpEcgRespWave(&tPacket);
			break;
		case ZUGMED_PACKET_ID_DATA_ECG_RESP_RATE:
			HandlePacketParHrRr(&tPacket);
			break;
		case ZUGMED_PACKET_ID_DATA_TEMP_RESULT:
			HandlePacketParTempData(&tPacket);
			break;
		case ZUGMED_PACKET_ID_DATA_ECG_LEAD_STATUS:
			HandlePacketParLeadStatus(&tPacket);
			break;
		case ZUGMED_PACKET_ID_DATA_ECG_CHAN_OVLD:
			HandlePacketParEcgOverload(&tPacket);
			break;
		case ZUGMED_PACKET_ID_DATA_RESP_APNEA_FLAG:
			HandlePacketParRespApnea(&tPacket);
			break;
		case ZUGMED_PACKET_ID_DATA_RESP_CVA_FLAG:
			HandlePacketRespCva(&tPacket);
			break;
		case ZUGMED_PACKET_ID_RESPONSE_GENERAL:
			HandlePacketResponseGeneral(&tPacket);
			break;
		case ZUGMED_PACKET_ID_REQUEST_HANDSHAKE:
			HandleEcgPacketStart();
			break;
		case ZUGMED_PACKET_ID_RESPONSE_MODULE_INFO:
//			HandlePacketUpModuleInfo(&tPacket);
			break;
		case ZUGMED_PACKET_ID_RESPONSE_MODULE_STATUS:
	//		HandlePacketUpModuleStatus(&tPacket);
			break;
	}
}

void CMulti_ParaMonitorDlg::RcvNIBPData(ZUGMED_PACKET tPacket)
{
	if((tPacket.u8Type == ZUGMED_PACKET_TYPE_DD || tPacket.u8Type == ZUGMED_PACKET_TYPE_DA )&& tPacket.u8Id == ZUGMED_NBP_RESPONSE_CUFFPRS)
	{
		int iCuffPrs = tPacket.pu8Data[0] + (tPacket.pu8Data[1] << 8);
		bool bCuffErrorFlag = (bool)(tPacket.pu8Data[2]);
		ZUGMED_NOTIFY_LIST tSystemStatus = (ZUGMED_NOTIFY_LIST)(tPacket.pu8Data[3]);

		m_pDebugInfoDlg->m_NbpRealPrs.ZugMedSetCuffInfo(iCuffPrs, bCuffErrorFlag, tSystemStatus);
	}
	else if (tPacket.u8Type == ZUGMED_PACKET_TYPE_DD)
	{
		if (tPacket.u8Id == ZUGMED_NBP_RESPONSE_NOTIFY_END)
		{
			ZUGMED_NOTIFY_LIST tMode = (ZUGMED_NOTIFY_LIST)tPacket.pu8Data[0];
			ZUGMED_NOTIFY_START_OR_STOP_LIST tState = (ZUGMED_NOTIFY_START_OR_STOP_LIST)tPacket.pu8Data[1];

			if(tMode == ZUGMED_NOTIFY_MODE_BP | ZUGMED_NOTIFY_MODE_CHECK_LEAK | ZUGMED_NOTIFY_MODE_VP)
			{
				if(tState == ZUGMED_NOTIFY_MODE_STATE_END)
				{
					ZUGMED_PACKET tPacket;
					tPacket.u8Len = 0x0A;
					tPacket.u8ParaType = 0x02;
					tPacket.u8Type = ZUGMED_PACKET_TYPE_DR;
					tPacket.u8Id = ZUGMED_CMD_NBP_REQUEST_TEST_RESULT;
					tPacket.u32No = m_uiNBPSerialNo;

					m_uiNBPSerialNo++;

					SndCmdPacket(tPacket);
				}
			}
		}
		else if (tPacket.u8Id == ZUGMED_NBP_RESPONSE_CONNECT_ACK)
		{
			ZUGMED_PACKET tPacket;
			tPacket.u8Len = 10;
			tPacket.u8ParaType = 0x02;
			tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
			tPacket.u8Id = ZUGMED_CMD_NBP_CONNECT_ACK;
			tPacket.u32No = m_uiNBPSerialNo;

			m_uiNBPSerialNo++;
			SndCmdPacket(tPacket);
		}
		else if (tPacket.u8Id == ZUGMED_NBP_RESPONSE_RT_PLS_PRS)
		{

		}
	}
	else if(tPacket.u8Type == ZUGMED_PACKET_TYPE_DA)
	{
		if (tPacket.u8Id == ZUGMED_NBP_RESPONSE_ANSWER)
		{
			unsigned int tu32No = tPacket.u32No;
			ZUGMED_GENERAL_RESPONSE_LIST tPacketStatus = (ZUGMED_GENERAL_RESPONSE_LIST)(tPacket.pu8Data[0]);

	//		RcvPacketAnswer(tu32No,tPacketStatus);
		}
		else if (tPacket.u8Id == ZUGMED_NBP_RESPONSE_TEST_RESULT_STATUS)
		{
			unsigned short uiSysPrs = tPacket.pu8Data[0] + (tPacket.pu8Data[1] << 8);
			unsigned short uiDiaPrs = tPacket.pu8Data[2] + (tPacket.pu8Data[3] << 8);
			unsigned short uiMeanPrs = tPacket.pu8Data[4] + (tPacket.pu8Data[5] << 8);
			unsigned short uiPlsRate = tPacket.pu8Data[6] + (tPacket.pu8Data[7] << 8);
			ZUGMED_ERROR_MESSAGE_LIST tErrorMessage = (ZUGMED_ERROR_MESSAGE_LIST)(tPacket.pu8Data[9]);
			PATIENT_MODE_LIST tPatientMode = (PATIENT_MODE_LIST)(tPacket.pu8Data[8]);
			ZUGMED_NOTIFY_LIST tSystemStatus = (ZUGMED_NOTIFY_LIST)(tPacket.pu8Data[11]);
			MEASURE_MODE_LIST tMeasureMode = (MEASURE_MODE_LIST)(tPacket.pu8Data[10]);
	
			ZugMedRcvResult(tErrorMessage, uiMeanPrs, uiSysPrs, uiDiaPrs, uiPlsRate, tPatientMode, tSystemStatus, tMeasureMode);
		}
		else if (tPacket.u8Id == ZUGMED_NBP_RESPONSE_MODULE_INFO)
		{

		}
	}
}

void CMulti_ParaMonitorDlg::ZugMedRcvResult(ZUGMED_ERROR_MESSAGE_LIST tErrorMessage, unsigned short uiMeanPrs, unsigned short uiSysPrs, unsigned short uiDiaPrs, unsigned short uiPlsRate, PATIENT_MODE_LIST tPatientMode, ZUGMED_NOTIFY_LIST tSystemStatus, MEASURE_MODE_LIST tMeasureMode)
{
	CString strErrorCode;

	switch(tErrorMessage){
		case ZUGMED_ERROR_MESSAGE_NORMAL:
			strErrorCode = _T("MESSAGE NORMAL");
			break;
		case ZUGMED_ERROR_MESSAGE_CUFF_LOOSE:
			strErrorCode = _T("CUFF LOOSE");
			break;
		case ZUGMED_ERROR_MESSAGE_STOP:
			strErrorCode = _T("MESSAGE STOP");
			break;
		case ZUGMED_ERROR_MESSAGE_LEAK:
			strErrorCode = _T("MESSAGE LEAK");
			break;
		case ZUGMED_ERROR_MESSAGE_PRS_ERROR:
			strErrorCode = _T("PRS ERROR");
			break;
		case ZUGMED_ERROR_MESSAGE_WEAK_SIGNAL:
			strErrorCode = _T("WEAK SIGNAL");
			break;
		case ZUGMED_ERROR_MESSAGE_EXCEED_SCOPE:
			strErrorCode = _T("EXCEED SCOPE");
			break;
		case ZUGMED_ERROR_MESSAGE_MOVE:
			strErrorCode = _T("HAND MOVE");
			break;
		case ZUGMED_ERROR_MESSAGE_OVER_PRS:
			strErrorCode = _T("OVER PRESSURE");
			break;
		case ZUGMED_ERROR_MESSAGE_SYSTEM_ERROR:
			strErrorCode = _T("SYSTEM ERROR");
			break;
		case ZUGMED_ERROR_MESSAGE_SIGNAL_SATURATION:
			strErrorCode = _T("SIGNAL SATURATION");
			break;
		case ZUGMED_ERROR_MESSAGE_TIMEOUT:
			if(tSystemStatus == ZUGMED_NOTIFY_MODE_BP){
				strErrorCode = _T("MEASURE TIMEOUT");
			}else if(tSystemStatus == ZUGMED_NOTIFY_MODE_VP){
				strErrorCode = _T("VP TIMEOUT");
			}
			break;
		default:
			break;
	}

	m_NibpInfo.SetNibpInfo(uiSysPrs,uiMeanPrs,uiDiaPrs,uiPlsRate);

	m_pDebugInfoDlg->m_NBPErr.SetContent(strErrorCode);
	
	switch ( tPatientMode) 
	{
		case PATIENT_MODE_ADULT:
			m_pDebugInfoDlg->m_NBPPatientType.SetContent(_T("Adult Mode"));
			break;
		case PATIENT_MODE_CHILD:
			m_pDebugInfoDlg->m_NBPPatientType.SetContent(_T("Child Mode"));
			break;
		case PATIENT_MODE_NEON:
			m_pDebugInfoDlg->m_NBPPatientType.SetContent(_T("Naonate"));
			break;
	}

	switch ( tMeasureMode ) {
		case MEASURE_MODE_MANUAL:
			m_pDebugInfoDlg->m_NBPMode.SetContent(_T("Manual Mode"));
			break;
		case MEASURE_MODE_AUTO_1MIN:
			m_pDebugInfoDlg->m_NBPMode.SetContent(_T("Auto - 1Min"));
			break;
		case MEASURE_MODE_AUTO_2MIN:
			m_pDebugInfoDlg->m_NBPMode.SetContent(_T("Auto - 2Min"));
			break;
		case MEASURE_MODE_AUTO_3MIN:
			m_pDebugInfoDlg->m_NBPMode.SetContent(_T("Auto - 3Min"));
			break;
		case MEASURE_MODE_AUTO_4MIN:
			m_pDebugInfoDlg->m_NBPMode.SetContent(_T("Auto - 4Min"));
			break;
		case MEASURE_MODE_AUTO_5MIN:
			m_pDebugInfoDlg->m_NBPMode.SetContent(_T("Auto - 5Min"));
			break;
		case MEASURE_MODE_AUTO_10MIN:
			m_pDebugInfoDlg->m_NBPMode.SetContent(_T("Auto - 10Min"));
			break;
		case MEASURE_MODE_AUTO_15MIN:
			m_pDebugInfoDlg->m_NBPMode.SetContent(_T("Auto - 15Min"));
			break;
		case MEASURE_MODE_AUTO_30MIN:
			m_pDebugInfoDlg->m_NBPMode.SetContent(_T("Auto - 30Min"));
			break;
		case MEASURE_MODE_AUTO_60MIN:
			m_pDebugInfoDlg->m_NBPMode.SetContent(_T("Auto - 60Min"));
			break;
		case MEASURE_MODE_AUTO_90MIN:
			m_pDebugInfoDlg->m_NBPMode.SetContent(_T("Auto - 90Min"));
			break;
		case MEASURE_MODE_AUTO_2HOUR:
			m_pDebugInfoDlg->m_NBPMode.SetContent(_T("Auto - 2Hour"));
			break;
		case MEASURE_MODE_AUTO_3HOUR:
			m_pDebugInfoDlg->m_NBPMode.SetContent(_T("Auto - 3Hour"));
			break;
		case MEASURE_MODE_AUTO_4HOUR:
			m_pDebugInfoDlg->m_NBPMode.SetContent(_T("Auto - 4Hour"));
			break;
		case MEASURE_MODE_AUTO_8HOUR:
			m_pDebugInfoDlg->m_NBPMode.SetContent(_T("Auto - 8Hour"));
			break;
		case MEASURE_MODE_CONT:
			m_pDebugInfoDlg->m_NBPMode.SetContent(_T("Continuous Mode"));
			break;
	}
}

void CMulti_ParaMonitorDlg::InitTheWindow()
{
	MoveWindow(0,0,MULTIPARA_INTERFACE_W+80,MULTIPARA_INTERFACE_H);
	CenterWindow();

	m_SpO2Info.MoveWindow(MULTIPARA_SPO2WAVE_W,MULTIPARA_STARTEND_H+MULTIPARA_SPO2WAVE_H*4,MULTIPARA_SPO2INFO_W,MULTIPARA_SPO2INFO_H);
	m_SpO2Info.SetRegion(MULTIPARA_SPO2INFO_W,MULTIPARA_SPO2INFO_H);
	
	m_EcgInfo.MoveWindow(MULTIPARA_INTERFACE_W-MULTIPARA_ECGINFO_W,MULTIPARA_STARTEND_H,MULTIPARA_ECGINFO_W,MULTIPARA_ECGINFO_H);
	m_EcgInfo.SetRegion(MULTIPARA_ECGINFO_W,MULTIPARA_ECGINFO_H);
	m_EcgInfo.SetLeadNameForSt(m_ptEcgLeadPos[0], m_ptEcgLeadPos[1], ECG_LEAD_V1);
	
	m_RespInfo.MoveWindow(MULTIPARA_INTERFACE_W-MULTIPARA_ECGINFO_W,MULTIPARA_STARTEND_H+MULTIPARA_ECGINFO_H,MULTIPARA_RESPINFO_W,MULTIPARA_RESPINFO_H);
	m_RespInfo.SetRegion(MULTIPARA_RESPINFO_W,MULTIPARA_RESPINFO_H);

	m_TempInfo.MoveWindow(MULTIPARA_INTERFACE_W-MULTIPARA_ECGINFO_W,MULTIPARA_STARTEND_H+MULTIPARA_ECGINFO_H+MULTIPARA_RESPINFO_H,MULTIPARA_TEMPINFO_W,MULTIPARA_TEMPINFO_H);
	m_TempInfo.SetRegion(MULTIPARA_TEMPINFO_W,MULTIPARA_TEMPINFO_H);
	
	m_NibpInfo.MoveWindow(MULTIPARA_INTERFACE_W-MULTIPARA_ECGINFO_W,MULTIPARA_STARTEND_H+MULTIPARA_ECGINFO_H+MULTIPARA_RESPINFO_H+MULTIPARA_TEMPINFO_H,MULTIPARA_NIBPINFO_W,MULTIPARA_NIBPINFO_H);
	m_NibpInfo.SetRegion(MULTIPARA_NIBPINFO_W,MULTIPARA_NIBPINFO_H);

	InitEcg5DWindow();
}

void CMulti_ParaMonitorDlg::InitEcg3DWindow()
{
	m_pEcgWave[2].ShowWindow(SW_HIDE);		
	m_pEcgWave[3].ShowWindow(SW_HIDE);		
	m_pEcgWave[4].ShowWindow(SW_HIDE);		
	m_pEcgWave[5].ShowWindow(SW_HIDE);	

	m_pEcgWave[0].MoveWindow(MULTIPARA_STARTEND_W,MULTIPARA_STARTEND_H,MULTIPARA_3DECGWAVE_W,MULTIPARA_3DECGWAVE_H);
	m_pEcgWave[0].SetRegion(MULTIPARA_3DECGWAVE_W,MULTIPARA_3DECGWAVE_H);

	m_pEcgWave[1].MoveWindow(MULTIPARA_STARTEND_W,MULTIPARA_STARTEND_H+MULTIPARA_3DECGWAVE_H,MULTIPARA_3DECGWAVE_W,MULTIPARA_3DECGWAVE_H);
	m_pEcgWave[1].SetRegion(MULTIPARA_3DECGWAVE_W,MULTIPARA_3DECGWAVE_H);

	m_RespWave.MoveWindow(MULTIPARA_STARTEND_W,1+MULTIPARA_STARTEND_H+MULTIPARA_3DBASE_H*2,MULTIPARA_SPO2WAVE_W-1,MULTIPARA_3DBASE_H);
	m_RespWave.SetRegion(MULTIPARA_SPO2WAVE_W-1,MULTIPARA_3DBASE_H);
	m_RespWave.SetScanSpeed(SCAN_SPEED_10MS);

	m_SpO2Bar.MoveWindow(MULTIPARA_SPO2WAVE_W-15,2+MULTIPARA_STARTEND_H+MULTIPARA_3DBASE_H*3,15,MULTIPARA_3DBASE_H);
	m_SpO2Wave.MoveWindow(MULTIPARA_STARTEND_W,2+MULTIPARA_STARTEND_H+MULTIPARA_3DBASE_H*3,MULTIPARA_SPO2WAVE_W-15,MULTIPARA_3DBASE_H);
	m_SpO2Wave.SetRegion(MULTIPARA_SPO2WAVE_W-15,MULTIPARA_3DBASE_H);

}

void CMulti_ParaMonitorDlg::InitEcg5DWindow()
{
	m_pEcgWave[2].ShowWindow(SW_SHOW);		
	m_pEcgWave[3].ShowWindow(SW_SHOW);		
	m_pEcgWave[4].ShowWindow(SW_SHOW);		
	m_pEcgWave[5].ShowWindow(SW_SHOW);	

	m_RespWave.MoveWindow(MULTIPARA_STARTEND_W,1+MULTIPARA_STARTEND_H+MULTIPARA_SPO2WAVE_H*3,MULTIPARA_SPO2WAVE_W-1,MULTIPARA_SPO2WAVE_H);
	m_RespWave.SetRegion(MULTIPARA_SPO2WAVE_W-1,MULTIPARA_SPO2WAVE_H);
	m_RespWave.SetScanSpeed(SCAN_SPEED_10MS);

	m_SpO2Bar.MoveWindow(MULTIPARA_SPO2WAVE_W-15,MULTIPARA_STARTEND_H+MULTIPARA_SPO2WAVE_H*4,15,MULTIPARA_SPO2WAVE_H);
	m_SpO2Wave.MoveWindow(MULTIPARA_STARTEND_W,MULTIPARA_STARTEND_H+MULTIPARA_SPO2WAVE_H*4,MULTIPARA_SPO2WAVE_W-15,MULTIPARA_SPO2WAVE_H);
	m_SpO2Wave.SetRegion(MULTIPARA_SPO2WAVE_W-15,MULTIPARA_SPO2WAVE_H);

	m_pEcgWave[0].MoveWindow(MULTIPARA_STARTEND_W,MULTIPARA_STARTEND_H,MULTIPARA_5DECGWAVE_W,MULTIPARA_5DECGWAVE_H);
	m_pEcgWave[0].SetRegion(MULTIPARA_5DECGWAVE_W,MULTIPARA_5DECGWAVE_H);

	m_pEcgWave[1].MoveWindow(MULTIPARA_STARTEND_W,MULTIPARA_STARTEND_H+MULTIPARA_5DECGWAVE_H,MULTIPARA_5DECGWAVE_W,MULTIPARA_5DECGWAVE_H);
	m_pEcgWave[1].SetRegion(MULTIPARA_5DECGWAVE_W,MULTIPARA_5DECGWAVE_H);

	m_pEcgWave[2].MoveWindow(MULTIPARA_STARTEND_W,MULTIPARA_STARTEND_H+MULTIPARA_5DECGWAVE_H*2,MULTIPARA_5DECGWAVE_W,MULTIPARA_5DECGWAVE_H);
	m_pEcgWave[2].SetRegion(MULTIPARA_5DECGWAVE_W,MULTIPARA_5DECGWAVE_H);

	m_pEcgWave[3].MoveWindow(MULTIPARA_5DECGWAVE_W+2,MULTIPARA_STARTEND_H,MULTIPARA_5DECGWAVE_W,MULTIPARA_5DECGWAVE_H);
	m_pEcgWave[3].SetRegion(MULTIPARA_5DECGWAVE_W,MULTIPARA_5DECGWAVE_H);

	m_pEcgWave[4].MoveWindow(MULTIPARA_5DECGWAVE_W+2,MULTIPARA_STARTEND_H+MULTIPARA_5DECGWAVE_H,MULTIPARA_5DECGWAVE_W,MULTIPARA_5DECGWAVE_H);
	m_pEcgWave[4].SetRegion(MULTIPARA_5DECGWAVE_W,MULTIPARA_5DECGWAVE_H);

	m_pEcgWave[5].MoveWindow(MULTIPARA_5DECGWAVE_W+2,MULTIPARA_STARTEND_H+MULTIPARA_5DECGWAVE_H*2,MULTIPARA_5DECGWAVE_W,MULTIPARA_5DECGWAVE_H);
	m_pEcgWave[5].SetRegion(MULTIPARA_5DECGWAVE_W,MULTIPARA_5DECGWAVE_H);
	
	m_pEcgWave[0].SetChannel(ECG_CHANNEL_I);
	m_pEcgWave[1].SetChannel(ECG_CHANNEL_II);
	m_pEcgWave[0].SetLead(ECG_LEAD_I);
	m_pEcgWave[1].SetLead(ECG_LEAD_II);
	m_pEcgWave[2].SetLead(ECG_LEAD_III);
	m_pEcgWave[3].SetLead(ECG_LEAD_AVR);
	m_pEcgWave[4].SetLead(ECG_LEAD_AVL);
	m_pEcgWave[5].SetLead(ECG_LEAD_AVF);

	for ( int i = 0; i < 6; i ++ ) {
		m_pEcgWave[i].SetGain(ECG_GAIN_1_00);
		m_pEcgWave[i].SetFilter(FILTER_DIAG);
		m_pEcgWave[i].SetScanSpeed(SCAN_SPEED_2MS);
	}
	
	m_RespWave.SetScanSpeed(SCAN_SPEED_10MS);
}

void CMulti_ParaMonitorDlg::InitCommPort()
{
	bool CommFlag= FALSE;

	delete m_pcComWatchThread;
	m_pcComWatchThread = NULL;
	delete m_pcComPort;
	m_pcComPort = NULL;

	for (int i=0; i<100; i++)
	{
		m_pcComPort = new CComPort(i);
		if ( FALSE == m_pcComPort->Initialize())
		{
			delete m_pcComPort;
			m_pcComPort = NULL;

			CommFlag= FALSE;
		}
		else
		{
			CommFlag = TRUE;
			m_pcComWatchThread=new CComWatchThread(m_pcComPort, this);
			m_pcComWatchThread->CreateThread(CREATE_SUSPENDED);
			m_pcComWatchThread->SetThreadPriority(THREAD_PRIORITY_LOWEST);
			m_pcComWatchThread->ResumeThread();

			break;
		}
	}

	if (CommFlag == FALSE)
	{
		MessageBox(_T("failed to initialize,please try again!"),_T("Warning!"),MB_ICONWARNING);
	}
}

void CMulti_ParaMonitorDlg::SndCmdPacket(ZUGMED_PACKET tPacket)
{ 
	unsigned char puchBuff[MAX_PATH];
	unsigned char uchIndex = 0;
	unsigned long gu32No = 0;

	puchBuff[uchIndex ++] = ZUGMED_PACKET_HEAD;
	puchBuff[uchIndex ++] = tPacket.u8Len;
	puchBuff[uchIndex ++] = tPacket.u8ParaType;
	puchBuff[uchIndex ++] = tPacket.u8Type;
	puchBuff[uchIndex ++] = tPacket.u8Id;
	puchBuff[uchIndex ++] = gu32No & 0xFF;
	puchBuff[uchIndex ++] = (gu32No >> 8) & 0xFF;
	puchBuff[uchIndex ++] = (gu32No >> 16) & 0xFF;
	puchBuff[uchIndex ++] = (gu32No >> 24) & 0xFF;

	gu32No ++;
	for ( int i = 0; i < tPacket.u8Len - 10; i ++ )
	{
		puchBuff[uchIndex ++] = tPacket.pu8Data[i];
	}

	unsigned char uchChecksum = 0;
	for ( int i = 1; i < uchIndex; i ++ )
	{
		uchChecksum += puchBuff[i];
	}
	puchBuff[uchIndex ++] = uchChecksum;
	
	if (m_pcComPort != NULL)
	{
		m_pcComPort->Send(puchBuff, tPacket.u8Len);
	}
}

void CMulti_ParaMonitorDlg::SndStartCmd()
{
	ZUGMED_PACKET tPacket;
	int m_gZugMedSndCmdCounter=0;

	tPacket.u8Len = 10;
	tPacket.u8ParaType = PARAM_SPO2;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_CMD_CONNECT_ACK;
	tPacket.u32No = 0;

	m_gZugMedSndCmdCounter++;

	SndCmdPacket(tPacket);
}
void CMulti_ParaMonitorDlg::OnRButtonDown(UINT nFlags, CPoint point)
{
	// TODO: 在此添加消息处理程序代码和/或调用默认值
	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(m_MenuNum);
	ClientToScreen(&point);
	pcMenuPopup->TrackPopupMenu(TPM_CENTERALIGN | TPM_RIGHTBUTTON, point.x, point.y, this);

	CDialog::OnRButtonDown(nFlags, point);
}

void CMulti_ParaMonitorDlg::OnLButtonDown(UINT nFlags, CPoint point)
{
	// TODO: 在此添加消息处理程序代码和/或调用默认值
//	PostMessage(WM_NCLBUTTONDOWN,HTCAPTION,MAKELPARAM(point.x,point.y));

	CDialog::OnLButtonDown(nFlags, point);
}

void CMulti_ParaMonitorDlg::InitVari()
{
	for ( int i = 0; i < 6; i ++ ) {
		m_ptEcgLeadPos[i] = ECG_LEAD_CAL;
	}
	m_ptEcgLeadPos[0] = ECG_LEAD_II;
	m_ptEcgLeadPos[1] = ECG_LEAD_I;
	m_ptEcgLeadPos[2] = ECG_LEAD_III;
	m_ptEcgLeadPos[3] = ECG_LEAD_AVR;
	m_ptEcgLeadPos[4] = ECG_LEAD_AVL;
	m_ptEcgLeadPos[5] = ECG_LEAD_AVF;

	m_uiEcgScanSpeed=2;
	m_uiRespScanSpeed=5;
	m_MenuNum = 0;

	m_SpO2Bar.SetPos(0);
	m_cMenu.LoadMenuW(IDR_NIBP_MENU);
	
	m_uiNBPSerialNo = 0;

	m_pDebugInfoDlg = new CDebugInfoDlg;
	m_pDebugInfoDlg->Create(IDD_DEBUGINFO_DIALOG,this);
	m_pDebugInfoDlg->ShowWindow(SW_HIDE);
}

void CMulti_ParaMonitorDlg::HandlePacketUpEcgRespWave(ZUGMED_PACKET * ptPacket)
{
	unsigned int uiStatus = ptPacket->pu8Data[0];
	
	static int iPaceDelayCount = 0;
	static int iRWaveDelayCount = 0;

	if ( uiStatus & 0x01 ) {
		m_EcgInfo.SetPaceFlag(true);
		iPaceDelayCount = 0;
	}
	else {
		iPaceDelayCount ++;
		if ( iPaceDelayCount > 100 ) {
			iPaceDelayCount = 100;
			m_EcgInfo.SetPaceFlag(false);
		}
	}

	if ( uiStatus & 0x10 ) {
		m_EcgInfo.SetRWaveFlag(true);
		iRWaveDelayCount = 0;
	}
	else {
		iRWaveDelayCount ++;
		if ( iRWaveDelayCount > 100 ) {
			iRWaveDelayCount = 100;
			m_EcgInfo.SetRWaveFlag(false);
		}
	}

//	unsigned int uiEcg0Value = (ptPacket->pu8Data[2] << 8) + ptPacket->pu8Data[1];
//	unsigned int uiEcg1Value = (ptPacket->pu8Data[4] << 8) + ptPacket->pu8Data[3];
//	unsigned int uiRespValue = (ptPacket->pu8Data[8] << 8) + ptPacket->pu8Data[7];


	unsigned int uiEcg0Value = ptPacket->pu8Data[1]  + ((ptPacket->pu8Data[2] & 0x0f)<< 8);
	unsigned int uiEcg1Value = (ptPacket->pu8Data[3]<< 4) + ((ptPacket->pu8Data[2] & 0xf0)>> 4);
	unsigned int uiEcg2Value  = ptPacket->pu8Data[4]  + ((ptPacket->pu8Data[5] & 0x0f)<< 8);
	unsigned int uiRespValue = (ptPacket->pu8Data[6]<< 4)  + ((ptPacket->pu8Data[5] & 0xf0)>> 4);
	CalLeadData(uiEcg0Value, uiEcg1Value);

	static UINT uiEcgCurrentPoint = 0,uiRespCurrentPoint = 0;

	if ( 0 == uiEcgCurrentPoint ) 
	{
		for ( int i = 0; i < 6; i ++ ) 
		{
			m_pEcgWave[i].RcvOneData(m_puiEcgLeadData[i]);
		}
	}

	uiEcgCurrentPoint ++;
	if ( uiEcgCurrentPoint >= m_uiEcgScanSpeed ) {
		uiEcgCurrentPoint = 0;
	}

	if ( 0 == uiRespCurrentPoint ) {	
		m_RespWave.RcvOneData(uiRespValue);
	}

	uiRespCurrentPoint ++;
	if ( uiRespCurrentPoint >= m_uiRespScanSpeed ) {
		uiRespCurrentPoint = 0;
	}
}

void CMulti_ParaMonitorDlg::CalLeadData(unsigned int uiData0 , unsigned int uiData1)
{
	if ( m_ptEcgLeadPos[0] == m_ptEcgLeadPos[1] ) {
		m_puiEcgLeadData[0] = uiData0;
		m_puiEcgLeadData[1] = uiData1;

		for ( int i = 2; i < 6; i ++ ) 
		{
			m_puiEcgLeadData[i] = 2048;
		}
		return;
	}

	int iData0 = uiData0 - 2048;
	int iData1 = uiData1 - 2048;


	ECG_LEAD_NAME tEcgLead0, tEcgLead1;
	if ( m_ptEcgLeadPos[0] < m_ptEcgLeadPos[1] ) {
		tEcgLead0 = m_ptEcgLeadPos[0];
		tEcgLead1 = m_ptEcgLeadPos[1];
	}
	else {
		tEcgLead0 = m_ptEcgLeadPos[1];
		tEcgLead1 = m_ptEcgLeadPos[0];
		int iTemp = iData0;
		iData0 = iData1;
		iData1 = iTemp;
	}

	int iLeadIData, iLeadIIData;

	if ( (ECG_LEAD_I == tEcgLead0) && (ECG_LEAD_II == tEcgLead1) ) {
		iLeadIData = iData0;
		iLeadIIData = iData1;
	}
	else if ( (ECG_LEAD_I == tEcgLead0) && (ECG_LEAD_III == tEcgLead1) ) {
		iLeadIData = iData0;
		iLeadIIData = iData0 + iData1;
	}
	else if ( (ECG_LEAD_I == tEcgLead0) && (ECG_LEAD_AVR == tEcgLead1) ) {
		iLeadIData = iData0;
		iLeadIIData = -2 * iData1 - iData0;
	}
	else if ( (ECG_LEAD_I == tEcgLead0) && (ECG_LEAD_AVL == tEcgLead1) ) {
		iLeadIData = iData0;
		iLeadIIData = 2 * (iData0 - iData1);
	}
	else if ( (ECG_LEAD_I == tEcgLead0) && (ECG_LEAD_AVF == tEcgLead1) ) {
		iLeadIData = iData0;
		iLeadIIData = iData0 / 2 + iData1;
	}
	else if ( (ECG_LEAD_II == tEcgLead0) && (ECG_LEAD_III == tEcgLead1) ) {
		iLeadIData = iData0 - iData1;
		iLeadIIData = iData0;
	}
	else if ( (ECG_LEAD_II == tEcgLead0) && (ECG_LEAD_AVR == tEcgLead1) ) {
		iLeadIData = -iData0 - 2 * iData1;
		iLeadIIData = iData0;
	}
	else if ( (ECG_LEAD_II == tEcgLead0) && (ECG_LEAD_AVL == tEcgLead1) ) {
		iLeadIData = iData0 / 2 + iData1;
		iLeadIIData = iData0;
	}
	else if ( (ECG_LEAD_II == tEcgLead0) && (ECG_LEAD_AVF == tEcgLead1) ) {
		iLeadIData = 2 * (iData0 - iData1);
		iLeadIIData = iData0;
	}
	else if ( (ECG_LEAD_III == tEcgLead0) && (ECG_LEAD_AVR == tEcgLead1) ) {
		iLeadIData = -iData0 / 2 - iData1;
		iLeadIIData = iData0 / 2 - iData1;
	}
	else if ( (ECG_LEAD_III == tEcgLead0) && (ECG_LEAD_AVL == tEcgLead1) ) {
		iLeadIData = iData0 + 2 * iData1;
		iLeadIIData = 2 * (iData0 + iData1);
	}
	else if ( (ECG_LEAD_III == tEcgLead0) && (ECG_LEAD_AVF == tEcgLead1) ) {
		iLeadIData = 2 * (iData1 - iData0);
		iLeadIIData = -iData0 + 2 * iData1;
	}
	else if ( (ECG_LEAD_AVR == tEcgLead0) && (ECG_LEAD_AVL == tEcgLead1) ) {
		iLeadIData = -2 * (iData0 - iData1) / 3;
		iLeadIIData = -2 * (2 * iData0 + iData1) / 3;
	}
	else if ( (ECG_LEAD_AVR == tEcgLead0) && (ECG_LEAD_AVF == tEcgLead1) ) {
		iLeadIData = -2 * (2 * iData0 + iData1) / 3;
		iLeadIIData = -2 * (iData0 - iData1) / 3;
	}
	else if ( (ECG_LEAD_AVL == tEcgLead0) && (ECG_LEAD_AVF == tEcgLead1) ) {
		iLeadIData = 2 * (2 * iData0 + iData1) / 3;
		iLeadIIData = 2 * (iData0 + 2 * iData1) / 3;
	}


	for ( int i = 0; i < 6; i ++ ) {
		if ( ECG_LEAD_I == m_ptEcgLeadPos[i] ) {
			m_puiEcgLeadData[i] = iLeadIData + 2048;
		}
		else if ( ECG_LEAD_II == m_ptEcgLeadPos[i] ) {
			m_puiEcgLeadData[i] = iLeadIIData + 2048;
		}
		else if ( ECG_LEAD_III == m_ptEcgLeadPos[i] ) {
			m_puiEcgLeadData[i] = iLeadIIData - iLeadIData + 2048;
		}
		else if ( ECG_LEAD_AVR == m_ptEcgLeadPos[i] ) {
			m_puiEcgLeadData[i] = -(iLeadIData + iLeadIIData) / 2 + 2048;
		}
		else if ( ECG_LEAD_AVL == m_ptEcgLeadPos[i] ) {
			m_puiEcgLeadData[i] = iLeadIData - iLeadIIData / 2 + 2048;
		}
		else if ( ECG_LEAD_AVF == m_ptEcgLeadPos[i] ) {
			m_puiEcgLeadData[i] = iLeadIIData  - iLeadIData / 2 + 2048;
		}
	}
}
void CMulti_ParaMonitorDlg::HandlePacketParLeadStatus(ZUGMED_PACKET * ptPacket)
{
	ECG_LEAD_MODE tLeadMode = ECG_LEAD_SYSTEM_SET_MAX;
	if ( ptPacket->pu8Data[1] & 0x01 ) {
		tLeadMode = ECG_LEAD_SYSTEM_SET_12;
	}
	else if ( ptPacket->pu8Data[0] & 0x01 ) {
		tLeadMode = ECG_LEAD_SYSTEM_SET_5;
	}
	else {
		tLeadMode = ECG_LEAD_SYSTEM_SET_3;
	}

	unsigned char uchLeadRaLaLlOffFlag = 0;
	unsigned char uchLeadVxOffFlag = 0;
	unsigned char uchChannelStatus = 0;

	if ( 0x20 == (ptPacket->pu8Data[0] & 0x20) ) {
		uchLeadRaLaLlOffFlag |= 0x01;
	}
	if ( 0x10 == (ptPacket->pu8Data[0] & 0x10) ) {
		uchLeadRaLaLlOffFlag |= 0x02;
	}
	if ( 0x08 == (ptPacket->pu8Data[0] & 0x08) ) {
		uchLeadRaLaLlOffFlag |= 0x04;
	}
	if ( 0x02 == (ptPacket->pu8Data[0] & 0x02) ) {
		uchLeadRaLaLlOffFlag |= 0x08;
	}
	if ( 0x04 == (ptPacket->pu8Data[0] & 0x04) ) {
		uchLeadVxOffFlag |= 0x01;
	}

	uchLeadVxOffFlag |= ptPacket->pu8Data[1] & 0x3E;

	uchChannelStatus = ~(ptPacket->pu8Data[2]);

	m_pDebugInfoDlg->SetLeadStatus(tLeadMode, uchLeadRaLaLlOffFlag, uchLeadVxOffFlag, uchChannelStatus);

}


void CMulti_ParaMonitorDlg::HandlePacketParHrRr(ZUGMED_PACKET * ptPacket)
{
	unsigned int uiHr = (ptPacket->pu8Data[1] << 8) + ptPacket->pu8Data[0];
	unsigned int uiRr = (ptPacket->pu8Data[3] << 8) + ptPacket->pu8Data[2];

	m_EcgInfo.SetHr(uiHr);
	m_RespInfo.SetRr(uiRr);
}

void CMulti_ParaMonitorDlg::HandlePacketParEcgOverload(ZUGMED_PACKET * ptPacket)
{
	unsigned char uchOvldStatus = ptPacket->pu8Data[0];

	m_pDebugInfoDlg->SetChannelOvldStatus(uchOvldStatus);
}
void CMulti_ParaMonitorDlg::HandlePacketParTempData(ZUGMED_PACKET * ptPacket)
{
	unsigned int uiTemp1 = (ptPacket->pu8Data[1] << 8) + ptPacket->pu8Data[0];
	unsigned int uiTemp2 = (ptPacket->pu8Data[3] << 8) + ptPacket->pu8Data[2];

	m_TempInfo.SetTemp(uiTemp1, uiTemp2);
}

void CMulti_ParaMonitorDlg::HandlePacketParRespApnea(ZUGMED_PACKET * ptPacket)
{
	bool bApneaFlag = false;

	if ( 1 == ptPacket->pu8Data[0] ) 
	{
		bApneaFlag = true;		
	}

	m_RespInfo.SetApneaFlag(bApneaFlag);
}

void CMulti_ParaMonitorDlg::HandleEcgPacketStart()
{
	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_ECG;
	tPacket.u8Len = 10;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_HANDSHAKE;

	SndCmdPacket(tPacket);
}
void CMulti_ParaMonitorDlg::HandlePacketRespCva(ZUGMED_PACKET * ptPacket)
{
	bool bCvaFlag = false;

	if ( 1 == ptPacket->pu8Data[0] ) 
	{
		bCvaFlag = true;
	}

	m_RespInfo.SetCvaFlag(bCvaFlag);

}

void CMulti_ParaMonitorDlg::HandlePacketResponseGeneral(ZUGMED_PACKET * ptPacket)
{
	ZUGMED_GENERAL_RESPONSE_LIST tCode = (ZUGMED_GENERAL_RESPONSE_LIST)(ptPacket->pu8Data[0]);

	CString strCode;
	switch ( tCode )
	{
	case ZUGMED_GENERAL_RESPONSE_PARATYPE_ERROR:
//		strCode = _T("参数类型错");
		strCode = _T("Parameter Type Err");
		break;
	case ZUGMED_GENERAL_RESPONSE_TYPE_ERROR:
//		strCode = _T("命令类型错");
		strCode = _T("Command Type Err");
		break;
	case ZUGMED_GENERAL_RESPONSE_ID_ERROR:
	//	strCode = _T("命令ID错");
		strCode = _T("Command ID Err");
		break;
	case ZUGMED_GENERAL_RESPONSE_DATA_ERROR:
	//	strCode = _T("命令参数错");
		strCode = _T("Command Err");
		break;
	case ZUGMED_GENERAL_RESPONSE_NO_ERROR:
	//	strCode = _T("命令序号错");
		strCode = _T("Command No Err");
		break;
	case ZUGMED_GENERAL_RESPONSE_CHECKSUM_ERROR:
	//	strCode = _T("命令校验和错");
		strCode = _T("Command Check Code Err");
		break;
	case ZUGMED_GENERAL_RESPONSE_SUCCEED:
	//	strCode = _T("命令执行成功");
		strCode = _T("Command Executed successfully");
		break;
	case ZUGMED_GENERAL_RESPONSE_FAIL:
	//	strCode = _T("命令执行失败");
		strCode = _T("Failed to Execute");
		break;
	case ZUGMED_GENERAL_RESPONSE_BUSY:
	//	strCode = _T("系统忙，命令无法执行");
		strCode = _T("System Busy");
		break;
	}
	if(tCode == ZUGMED_GENERAL_RESPONSE_SUCCEED ) return;
	MessageBox(strCode);
}


void CMulti_ParaMonitorDlg::OnSetLayout3d()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_ECG;
	tPacket.u8Len = 10 + 1;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_ECG_SET_LEAD_SET;
	tPacket.pu8Data[0] = 0;

	SndCmdPacket(tPacket);

	m_pEcgWave[0].ResetData();
	m_pEcgWave[1].ResetData();
	m_pEcgWave[2].ResetData();
	m_pEcgWave[3].ResetData();
	m_pEcgWave[4].ResetData();
	m_pEcgWave[5].ResetData();

	m_RespWave.ResetData();
	m_SpO2Wave.ResetData();

	InitEcg3DWindow();

	m_pEcgWave[0].Invalidate();
	m_pEcgWave[1].Invalidate();
	m_pEcgWave[2].Invalidate();
	m_pEcgWave[3].Invalidate();
	m_pEcgWave[4].Invalidate();
	m_pEcgWave[5].Invalidate();

	m_RespWave.Invalidate();
	m_SpO2Wave.Invalidate();

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_LAYOUT_3D, ID_SET_LAYOUT_5D, ID_SET_LAYOUT_3D, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetLayout5d()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_ECG;
	tPacket.u8Len = 10 + 1;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_ECG_SET_LEAD_SET;
	tPacket.pu8Data[0] = 1;
	
	SndCmdPacket(tPacket);

	m_pEcgWave[0].ResetData();
	m_pEcgWave[1].ResetData();
	m_pEcgWave[2].ResetData();
	m_pEcgWave[3].ResetData();
	m_pEcgWave[4].ResetData();
	m_pEcgWave[5].ResetData();

	m_RespWave.ResetData();
	m_SpO2Wave.ResetData();

	InitEcg5DWindow();

	m_pEcgWave[0].Invalidate();
	m_pEcgWave[1].Invalidate();
	m_pEcgWave[2].Invalidate();
	m_pEcgWave[3].Invalidate();
	m_pEcgWave[4].Invalidate();
	m_pEcgWave[5].Invalidate();

	m_RespWave.Invalidate();
	m_SpO2Wave.Invalidate();

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_LAYOUT_3D, ID_SET_LAYOUT_5D, ID_SET_LAYOUT_5D, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetFilterDiag()
{
	// TODO: 在此添加命令处理程序代码
	ECG_FILTER_MODE tFilterMode = FILTER_DIAG;

	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_ECG;
	tPacket.u8Len = 10 + 1;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_ECG_SET_FILTER;
	tPacket.pu8Data[0] = tFilterMode & 0x0F;

	SndCmdPacket(tPacket);

	for ( int i = 0; i < 6; i ++ ) {
		m_pEcgWave[i].SetFilter(FILTER_DIAG);
		m_pEcgWave[i].Invalidate();
	}

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_FILTER_DIAG, ID_SET_FILTER_SURGERY, ID_SET_FILTER_DIAG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetFilterMonitor()
{
	// TODO: 在此添加命令处理程序代码
	ECG_FILTER_MODE tFilterMode = FILTER_MONITOR;

	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_ECG;
	tPacket.u8Len = 10 + 1;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_ECG_SET_FILTER;
	tPacket.pu8Data[0] = tFilterMode & 0x0F;

	SndCmdPacket(tPacket);

	for ( int i = 0; i < 7; i ++ ) {
		m_pEcgWave[i].SetFilter(FILTER_MONITOR);
		m_pEcgWave[i].Invalidate();
	}

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_FILTER_DIAG, ID_SET_FILTER_SURGERY, ID_SET_FILTER_MONITOR, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetFilterHardest()
{
	// TODO: 在此添加命令处理程序代码
	ECG_FILTER_MODE tFilterMode = FILTER_HARDEST;

	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_ECG;
	tPacket.u8Len = 10 + 1;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_ECG_SET_FILTER;
	tPacket.pu8Data[0] = tFilterMode & 0x0F;

	SndCmdPacket(tPacket);

	for ( int i = 0; i < 7; i ++ ) {
		m_pEcgWave[i].SetFilter(FILTER_HARDEST);
		m_pEcgWave[i].Invalidate();
	}

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_FILTER_DIAG, ID_SET_FILTER_SURGERY, ID_SET_FILTER_HARDEST, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetFilterSurgery()
{
	// TODO: 在此添加命令处理程序代码
	ECG_FILTER_MODE tFilterMode = FILTER_SURGERY;

	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_ECG;
	tPacket.u8Len = 10 + 1;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_ECG_SET_FILTER;
	tPacket.pu8Data[0] = tFilterMode & 0x0F;

	SndCmdPacket(tPacket);

	for ( int i = 0; i < 7; i ++ ) {
		m_pEcgWave[i].SetFilter(FILTER_SURGERY);
		m_pEcgWave[i].Invalidate();
	}

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_FILTER_DIAG, ID_SET_FILTER_SURGERY, ID_SET_FILTER_SURGERY, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSet50hzTrap()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_ECG;
	tPacket.u8Len = 10 + 1;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_ECG_SET_TRAP;
	tPacket.pu8Data[0] = 0x00;

	SndCmdPacket(tPacket);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_50HZ_TRAP, ID_SET_NO_TRAP, ID_SET_50HZ_TRAP, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSet60hzTrap()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_ECG;
	tPacket.u8Len = 10 + 1;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_ECG_SET_TRAP;
	tPacket.pu8Data[0] = 0x01;

	SndCmdPacket(tPacket);
	
	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_50HZ_TRAP, ID_SET_NO_TRAP, ID_SET_60HZ_TRAP, MF_BYCOMMAND);

}

void CMulti_ParaMonitorDlg::OnSet5060hzTrap()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_ECG;
	tPacket.u8Len = 10 + 1;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_ECG_SET_TRAP;
	tPacket.pu8Data[0] = 0x02;

	SndCmdPacket(tPacket);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_50HZ_TRAP, ID_SET_NO_TRAP, ID_SET_5060HZ_TRAP, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetNoTrap()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_ECG;
	tPacket.u8Len = 10 + 1;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_ECG_SET_TRAP;
	tPacket.pu8Data[0] = 0x10;

	SndCmdPacket(tPacket);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_50HZ_TRAP, ID_SET_NO_TRAP, ID_SET_NO_TRAP, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetHrAuto()
{
	// TODO: 在此添加命令处理程序代码	
	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_ECG;
	tPacket.u8Len = 10 + 1;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_ECG_SET_ARR_CHAN;

	tPacket.pu8Data[0] = 0x10;

	SndCmdPacket(tPacket);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_HR_CHI, ID_SET_HR_CHII, ID_SET_HR_AUTO, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetHrChi()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_ECG;
	tPacket.u8Len = 10 + 1;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_ECG_SET_ARR_CHAN;

	tPacket.pu8Data[0] = ECG_CHANNEL_I;

	SndCmdPacket(tPacket);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_HR_CHI, ID_SET_HR_CHII, ID_SET_HR_CHI, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetHrChii()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_ECG;
	tPacket.u8Len = 10 + 1;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_ECG_SET_ARR_CHAN;

	tPacket.pu8Data[0] = ECG_CHANNEL_II;

	SndCmdPacket(tPacket);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_HR_CHI, ID_SET_HR_CHII, ID_SET_HR_CHII, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnEnablePaceDetection()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_ECG;
	tPacket.u8Len = 10 + 1;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_ECG_START_STOP_PACE;
	tPacket.pu8Data[0] = 0x01;

	SndCmdPacket(tPacket);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_ENABLE_PACE_DETECTION, ID_DISABLE_PACE_DETECTION, ID_ENABLE_PACE_DETECTION, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnDisablePaceDetection()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_ECG;
	tPacket.u8Len = 10 + 1;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_ECG_START_STOP_PACE;
	tPacket.pu8Data[0] = 0x00;

	SndCmdPacket(tPacket);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_ENABLE_PACE_DETECTION, ID_DISABLE_PACE_DETECTION, ID_DISABLE_PACE_DETECTION, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnStartEcgCal()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_ECG;
	tPacket.u8Len = 10 + 1;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_ECG_START_STOP_CAL;
	tPacket.pu8Data[0] = 0;

	SndCmdPacket(tPacket);

	CMenu *pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_START_ECG_CAL, ID_STOP_ECG_CAL, ID_START_ECG_CAL, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnStopEcgCal()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_ECG;
	tPacket.u8Len = 10 + 1;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_ECG_START_STOP_CAL;
	tPacket.pu8Data[0] = 1;

	SndCmdPacket(tPacket);

	CMenu *pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_START_ECG_CAL, ID_STOP_ECG_CAL, ID_STOP_ECG_CAL, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetPaceLeadI()
{
	// TODO: 在此添加命令处理程序代码
	ECG_PACE_LEAD_LIST tLead = ECG_PACE_LEAD_I;

	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_ECG;
	tPacket.u8Len = 10 + 1;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_ECG_PACE_SET_LEAD;
	tPacket.pu8Data[0] = tLead & 0x0F;

	SndCmdPacket(tPacket);
}

void CMulti_ParaMonitorDlg::OnSetPaceLeadIi()
{
	// TODO: 在此添加命令处理程序代码
	ECG_PACE_LEAD_LIST tLead = ECG_PACE_LEAD_II;

	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_ECG;
	tPacket.u8Len = 10 + 1;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_ECG_PACE_SET_LEAD;
	tPacket.pu8Data[0] = tLead & 0x0F;

	SndCmdPacket(tPacket);
}

void CMulti_ParaMonitorDlg::OnSetPaceLeadIii()
{
	// TODO: 在此添加命令处理程序代码
	ECG_PACE_LEAD_LIST tLead = ECG_PACE_LEAD_III;

	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_ECG;
	tPacket.u8Len = 10 + 1;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_ECG_PACE_SET_LEAD;
	tPacket.pu8Data[0] = tLead & 0x0F;

	SndCmdPacket(tPacket);
}

void CMulti_ParaMonitorDlg::OnSetPaceLeadAvl()
{
	// TODO: 在此添加命令处理程序代码
	ECG_PACE_LEAD_LIST tLead = ECG_PACE_LEAD_AVL;

	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_ECG;
	tPacket.u8Len = 10 + 1;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_ECG_PACE_SET_LEAD;
	tPacket.pu8Data[0] = tLead & 0x0F;

	SndCmdPacket(tPacket);
}

void CMulti_ParaMonitorDlg::OnSetPaceLeadAvr()
{
	// TODO: 在此添加命令处理程序代码
	ECG_PACE_LEAD_LIST tLead = ECG_PACE_LEAD_AVR;

	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_ECG;
	tPacket.u8Len = 10 + 1;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_ECG_PACE_SET_LEAD;
	tPacket.pu8Data[0] = tLead & 0x0F;

	SndCmdPacket(tPacket);
}

void CMulti_ParaMonitorDlg::OnSetPaceLeadAvf()
{
	// TODO: 在此添加命令处理程序代码
	ECG_PACE_LEAD_LIST tLead = ECG_PACE_LEAD_AVF;

	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_ECG;
	tPacket.u8Len = 10 + 1;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_ECG_PACE_SET_LEAD;
	tPacket.pu8Data[0] = tLead & 0x0F;

	SndCmdPacket(tPacket);
}


void CMulti_ParaMonitorDlg::OnSetApneaTime5s()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_ECG;
	tPacket.u8Len = 10 + 1;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_RESP_SET_APNEA;
	tPacket.pu8Data[0] = 5;

	SndCmdPacket(tPacket);

	CMenu *pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_APNEA_TIME_5S, ID_SETTINGAPNEATIME_20S, ID_SET_APNEA_TIME_5S, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetApneaTime10s()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_ECG;
	tPacket.u8Len = 10 + 1;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_RESP_SET_APNEA;
	tPacket.pu8Data[0] = 10;

	SndCmdPacket(tPacket);

	CMenu *pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_APNEA_TIME_5S, ID_SETTINGAPNEATIME_20S, ID_SET_APNEA_TIME_10S, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetApneaTime15s()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_ECG;
	tPacket.u8Len = 10 + 1;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_RESP_SET_APNEA;
	tPacket.pu8Data[0] = 15;

	SndCmdPacket(tPacket);

	CMenu *pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_APNEA_TIME_5S, ID_SETTINGAPNEATIME_20S, ID_SET_APNEA_TIME_15S, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSettingapneatime20s()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_ECG;
	tPacket.u8Len = 10 + 1;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_RESP_SET_APNEA;
	tPacket.pu8Data[0] = 20;

	SndCmdPacket(tPacket);

	CMenu *pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_APNEA_TIME_5S, ID_SETTINGAPNEATIME_20S, ID_SETTINGAPNEATIME_20S, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetRespLeadI()
{
	// TODO: 在此添加命令处理程序代码
	RESP_LEAD_LIST tRespLead = RESP_LEAD_I;
 
	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_ECG;
	tPacket.u8Len = 10 + 1;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_RESP_SET_LEAD;
	tPacket.pu8Data[0] = tRespLead & 0x0F;

	SndCmdPacket(tPacket);

	CMenu *pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_RESP_LEAD_I, ID_SET_RESP_LEAD_II, ID_SET_RESP_LEAD_I, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetRespLeadIi()
{
	// TODO: 在此添加命令处理程序代码
	RESP_LEAD_LIST tRespLead = RESP_LEAD_II;

	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_ECG;
	tPacket.u8Len = 10 + 1;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_RESP_SET_LEAD;
	tPacket.pu8Data[0] = tRespLead & 0x0F;

	SndCmdPacket(tPacket);

	CMenu *pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_RESP_LEAD_I, ID_SET_RESP_LEAD_II, ID_SET_RESP_LEAD_II, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetRespSensitivity1()
{
	// TODO: 在此添加命令处理程序代码
	RESP_SENSITIVITY_LIST tSensitivity = RESP_SENSITIVITY_1;

	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_ECG;
	tPacket.u8Len = 10 + 1;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_RESP_SET_SENSITIVITY;
	tPacket.pu8Data[0] = tSensitivity & 0x0F;

	SndCmdPacket(tPacket);

	CMenu *pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_RESP_SENSITIVITY_1, ID_SET_RESP_SENSITIVITY_5, ID_SET_RESP_SENSITIVITY_1, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetRespSensitivity2()
{
	// TODO: 在此添加命令处理程序代码
	RESP_SENSITIVITY_LIST tSensitivity = RESP_SENSITIVITY_2;

	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_ECG;
	tPacket.u8Len = 10 + 1;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_RESP_SET_SENSITIVITY;
	tPacket.pu8Data[0] = tSensitivity & 0x0F;

	SndCmdPacket(tPacket);

	CMenu *pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_RESP_SENSITIVITY_1, ID_SET_RESP_SENSITIVITY_5, ID_SET_RESP_SENSITIVITY_2, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetRespSensitivity3()
{
	// TODO: 在此添加命令处理程序代码
	RESP_SENSITIVITY_LIST tSensitivity = RESP_SENSITIVITY_3;

	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_ECG;
	tPacket.u8Len = 10 + 1;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_RESP_SET_SENSITIVITY;
	tPacket.pu8Data[0] = tSensitivity & 0x0F;

	SndCmdPacket(tPacket);

	CMenu *pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_RESP_SENSITIVITY_1, ID_SET_RESP_SENSITIVITY_5, ID_SET_RESP_SENSITIVITY_3, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetRespSensitivity4()
{
	// TODO: 在此添加命令处理程序代码
	RESP_SENSITIVITY_LIST tSensitivity = RESP_SENSITIVITY_4;

	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_ECG;
	tPacket.u8Len = 10 + 1;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_RESP_SET_SENSITIVITY;
	tPacket.pu8Data[0] = tSensitivity & 0x0F;

	SndCmdPacket(tPacket);

	CMenu *pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_RESP_SENSITIVITY_1, ID_SET_RESP_SENSITIVITY_5, ID_SET_RESP_SENSITIVITY_4, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetRespSensitivity5()
{
	// TODO: 在此添加命令处理程序代码
	RESP_SENSITIVITY_LIST tSensitivity = RESP_SENSITIVITY_5;

	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_ECG;
	tPacket.u8Len = 10 + 1;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_RESP_SET_SENSITIVITY;
	tPacket.pu8Data[0] = tSensitivity & 0x0F;

	SndCmdPacket(tPacket);

	CMenu *pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_RESP_SENSITIVITY_1, ID_SET_RESP_SENSITIVITY_5, ID_SET_RESP_SENSITIVITY_5, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetGainChallX250()
{
	// TODO: 在此添加命令处理程序代码
	unsigned char uchData = 0;
	uchData = 0xF0;
	uchData |= ECG_GAIN_0_25;

	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_ECG;
	tPacket.u8Len = 10 + 1;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_ECG_SET_GAIN;
	tPacket.pu8Data[0] = uchData;

	SndCmdPacket(tPacket);

	for ( int i = 0; i < 7; i ++ ) {
		m_pEcgWave[i].SetGain(ECG_GAIN_0_25);
		m_pEcgWave[i].Invalidate();
	}

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_GAIN_CHALL_X250, ID_SET_GAIN_CHALL_X2000, ID_SET_GAIN_CHALL_X250, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetGainChallX500()
{
	// TODO: 在此添加命令处理程序代码
	unsigned char uchData = 0;
	uchData = 0xF0;
	uchData |= ECG_GAIN_0_50;

	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_ECG;
	tPacket.u8Len = 10 + 1;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_ECG_SET_GAIN;
	tPacket.pu8Data[0] = uchData;

	SndCmdPacket(tPacket);

	for ( int i = 0; i < 7; i ++ ) {
		m_pEcgWave[i].SetGain(ECG_GAIN_0_50);
		m_pEcgWave[i].Invalidate();
	}

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_GAIN_CHALL_X250, ID_SET_GAIN_CHALL_X2000, ID_SET_GAIN_CHALL_X500, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetGainChallX1000()
{
	// TODO: 在此添加命令处理程序代码
	unsigned char uchData = 0;
	uchData = 0xF0;
	uchData |= ECG_GAIN_1_00;

	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_ECG;
	tPacket.u8Len = 10 + 1;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_ECG_SET_GAIN;
	tPacket.pu8Data[0] = uchData;

	SndCmdPacket(tPacket);

	for ( int i = 0; i < 7; i ++ ) {
		m_pEcgWave[i].SetGain(ECG_GAIN_1_00);
		m_pEcgWave[i].Invalidate();
	}

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_GAIN_CHALL_X250, ID_SET_GAIN_CHALL_X2000, ID_SET_GAIN_CHALL_X1000, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetGainChallX2000()
{
	// TODO: 在此添加命令处理程序代码
	unsigned char uchData = 0;
	uchData = 0xF0;
	uchData |= ECG_GAIN_2_00;

	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_ECG;
	tPacket.u8Len = 10 + 1;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_ECG_SET_GAIN;
	tPacket.pu8Data[0] = uchData;

	SndCmdPacket(tPacket);

	for ( int i = 0; i < 7; i ++ ) {
		m_pEcgWave[i].SetGain(ECG_GAIN_2_00);
		m_pEcgWave[i].Invalidate();
	}

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_GAIN_CHALL_X250, ID_SET_GAIN_CHALL_X2000, ID_SET_GAIN_CHALL_X2000, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetScanSpeedEcg2ms()
{
	// TODO: 在此添加命令处理程序代码
	m_uiEcgScanSpeed = 1;

	for ( int i = 0; i < 7; i ++ ) {
		m_pEcgWave[i].SetScanSpeed(SCAN_SPEED_2MS);
		m_pEcgWave[i].Invalidate();
	}

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_SCAN_SPEED_ECG_2MS, ID_SET_SCAN_SPEED_ECG_10MS, ID_SET_SCAN_SPEED_ECG_2MS, MF_BYCOMMAND);

}

void CMulti_ParaMonitorDlg::OnSetScanSpeedEcg4ms()
{
	// TODO: 在此添加命令处理程序代码
	m_uiEcgScanSpeed = 2;

	for ( int i = 0; i < 7; i ++ ) {
		m_pEcgWave[i].SetScanSpeed(SCAN_SPEED_4MS);
		m_pEcgWave[i].Invalidate();
	}

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_SCAN_SPEED_ECG_2MS, ID_SET_SCAN_SPEED_ECG_10MS, ID_SET_SCAN_SPEED_ECG_4MS, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetScanSpeedEcg10ms()
{
	// TODO: 在此添加命令处理程序代码
	m_uiEcgScanSpeed = 5;

	for ( int i = 0; i < 7; i ++ ) {
		m_pEcgWave[i].SetScanSpeed(SCAN_SPEED_10MS);
		m_pEcgWave[i].Invalidate();
	}

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_SCAN_SPEED_ECG_2MS, ID_SET_SCAN_SPEED_ECG_10MS, ID_SET_SCAN_SPEED_ECG_10MS, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetScanSpeedResp2ms()
{
	// TODO: 在此添加命令处理程序代码
	m_uiRespScanSpeed = 1;

	m_RespWave.SetScanSpeed(SCAN_SPEED_2MS);
	m_RespWave.Invalidate();

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_SCAN_SPEED_RESP_2MS, ID_SET_SCAN_SPEED_RESP_20MS, ID_SET_SCAN_SPEED_RESP_2MS, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetScanSpeedResp4ms()
{
	// TODO: 在此添加命令处理程序代码
	m_uiRespScanSpeed = 2;

	m_RespWave.SetScanSpeed(SCAN_SPEED_4MS);
	m_RespWave.Invalidate();

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_SCAN_SPEED_RESP_2MS, ID_SET_SCAN_SPEED_RESP_20MS, ID_SET_SCAN_SPEED_RESP_4MS, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetScanSpeedResp10ms()
{
	// TODO: 在此添加命令处理程序代码
	m_uiRespScanSpeed = 5;

	m_RespWave.SetScanSpeed(SCAN_SPEED_10MS);
	m_RespWave.Invalidate();

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_SCAN_SPEED_RESP_2MS, ID_SET_SCAN_SPEED_RESP_20MS, ID_SET_SCAN_SPEED_RESP_10MS, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetScanSpeedResp20ms()
{
	// TODO: 在此添加命令处理程序代码
	m_uiRespScanSpeed = 10;

	m_RespWave.SetScanSpeed(SCAN_SPEED_20MS);
	m_RespWave.Invalidate();

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_SCAN_SPEED_RESP_2MS, ID_SET_SCAN_SPEED_RESP_20MS, ID_SET_SCAN_SPEED_RESP_20MS, MF_BYCOMMAND);
}

void  CMulti_ParaMonitorDlg::SetPatientType(BOOL Ecg,BOOL Nibp,BOOL SpO2,PATIENT_TYPE num)
{
	ZUGMED_PACKET tPacket;
	tPacket.u8Len = 10+1;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_CMD_SET_PATIENT_MODE;
	tPacket.u32No = 0;
	tPacket.pu8Data[0] = num;

	if (Ecg == TRUE)
	{
		tPacket.u8ParaType = PARAM_ECG;
		SndCmdPacket(tPacket);
	}
	if (Nibp == TRUE)
	{
		tPacket.u8ParaType = PARAM_NBP;
		SndCmdPacket(tPacket);
	}
	if (SpO2 == TRUE)
	{
		tPacket.u8ParaType = PARAM_SPO2;
		SndCmdPacket(tPacket);
	}
}

void CMulti_ParaMonitorDlg::OnSppo2SeltTest()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;
	tPacket.u8Len = 10;
	tPacket.u8ParaType = PARAM_SPO2;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DR;
	tPacket.u8Id = ZUGMED_CMD_REQUEST_SELF_TEST_RESULT;
	tPacket.u32No = 0;
	SndCmdPacket(tPacket);
}

void CMulti_ParaMonitorDlg::OnSpo2Senstivity1()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;

	tPacket.u8Len = 11;
	tPacket.u8ParaType = PARAM_SPO2;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_CMD_SET_AVERAGE_TIME;
	tPacket.u32No = 0;
	tPacket.pu8Data[0] = 0;
	SndCmdPacket(tPacket);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(2);
	pcMenuPopup->CheckMenuRadioItem(ID_SPO2_SENSTIVITY_1, ID_SPO2_SENSTIVITY_4, ID_SPO2_SENSTIVITY_1, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSpo2Senstivity2()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;

	tPacket.u8Len = 11;
	tPacket.u8ParaType = PARAM_SPO2;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_CMD_SET_AVERAGE_TIME;
	tPacket.u32No = 0;
	tPacket.pu8Data[0] = 1;
	SndCmdPacket(tPacket);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(2);
	pcMenuPopup->CheckMenuRadioItem(ID_SPO2_SENSTIVITY_1, ID_SPO2_SENSTIVITY_4, ID_SPO2_SENSTIVITY_2, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSpo2Senstivity3()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;

	tPacket.u8Len = 11;
	tPacket.u8ParaType = PARAM_SPO2;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_CMD_SET_AVERAGE_TIME;
	tPacket.u32No = 0;
	tPacket.pu8Data[0] = 2;
	SndCmdPacket(tPacket);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(2);
	pcMenuPopup->CheckMenuRadioItem(ID_SPO2_SENSTIVITY_1, ID_SPO2_SENSTIVITY_4, ID_SPO2_SENSTIVITY_3, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSpo2Senstivity4()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;

	tPacket.u8Len = 11;
	tPacket.u8ParaType = PARAM_SPO2;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_CMD_SET_AVERAGE_TIME;
	tPacket.u32No = 0;
	tPacket.pu8Data[0] = 3;
	SndCmdPacket(tPacket);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(2);
	pcMenuPopup->CheckMenuRadioItem(ID_SPO2_SENSTIVITY_1, ID_SPO2_SENSTIVITY_4, ID_SPO2_SENSTIVITY_4, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnModuleinfo()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;
	tPacket.u8Len = 10;
	tPacket.u8ParaType = PARAM_SPO2;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DR;
	tPacket.u8Id = ZUGMED_CMD_REQUEST_MODULE_INFO;
	tPacket.u32No = 0;
	SndCmdPacket(tPacket);
}

void CMulti_ParaMonitorDlg::OnSpo2moduleUpdate()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;

	tPacket.u8Len = 10;
	tPacket.u8ParaType = PARAM_SPO2;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_CMD_UPDATE;
	tPacket.u32No = 0;
	SndCmdPacket(tPacket);
}

void CMulti_ParaMonitorDlg::OnNbpStart()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_NBP;
	tPacket.u8Len = 0x0A;
	tPacket.u8ParaType = 0x02;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_CMD_NBP_START;
	tPacket.u32No = 0;

	SndCmdPacket(tPacket);
}

void CMulti_ParaMonitorDlg::OnNibpStop()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_NBP;
	tPacket.u8Len = 0x0A;
	tPacket.u8ParaType = 0x02;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_CMD_NBP_STOP;
	tPacket.u32No = 0;

	SndCmdPacket(tPacket);
}

void CMulti_ParaMonitorDlg::ZugMedSndCmdForMeasureMode(ZUGMED_CMD_SET_MEASURE_MODE_PARA_LIST tMode)
{
	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_NBP;
	tPacket.u8Len = 0x0B;
	tPacket.u8ParaType = 0x02;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_CMD_NBP_SET_MEASURE_MODE;
	tPacket.u32No = m_uiNBPSerialNo;
	tPacket.pu8Data[0] = (unsigned char)tMode;

	m_uiNBPSerialNo ++;

	SndCmdPacket(tPacket);
}

void CMulti_ParaMonitorDlg::OnNbpSetMeasureModeManual()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForMeasureMode(ZUGMED_CMD_SET_MEASURE_MODE_PARA_MANUAL);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_NBP_SET_MEASURE_MODE_MANUAL, ID_NBP_SET_MEASURE_MODE_AUTO_8HOUR, ID_NBP_SET_MEASURE_MODE_MANUAL, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnNbpSetMeasureModeCont()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForMeasureMode(ZUGMED_CMD_SET_MEASURE_MODE_PARA_CONT);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_NBP_SET_MEASURE_MODE_MANUAL, ID_NBP_SET_MEASURE_MODE_AUTO_8HOUR, ID_NBP_SET_MEASURE_MODE_CONT, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnNbpSetMeasureModeAuto1min()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForMeasureMode(ZUGMED_CMD_SET_MEASURE_MODE_PARA_AUTO_1MIN);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_NBP_SET_MEASURE_MODE_MANUAL, ID_NBP_SET_MEASURE_MODE_AUTO_8HOUR, ID_NBP_SET_MEASURE_MODE_AUTO_1MIN, MF_BYCOMMAND);
	pcMenuPopup->CheckMenuRadioItem(ID_NBP_SET_MEASURE_MODE_AUTO_1MIN, ID_NBP_SET_MEASURE_MODE_AUTO_8HOUR, ID_NBP_SET_MEASURE_MODE_AUTO_1MIN, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnNbpSetMeasureModeAuto2min()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForMeasureMode(ZUGMED_CMD_SET_MEASURE_MODE_PARA_AUTO_2MIN);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_NBP_SET_MEASURE_MODE_MANUAL, ID_NBP_SET_MEASURE_MODE_AUTO_8HOUR, ID_NBP_SET_MEASURE_MODE_AUTO_2MIN, MF_BYCOMMAND);
	pcMenuPopup->CheckMenuRadioItem(ID_NBP_SET_MEASURE_MODE_AUTO_1MIN, ID_NBP_SET_MEASURE_MODE_AUTO_8HOUR, ID_NBP_SET_MEASURE_MODE_AUTO_2MIN, MF_BYCOMMAND);

}

void CMulti_ParaMonitorDlg::OnNbpSetMeasureModeAuto3min()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForMeasureMode(ZUGMED_CMD_SET_MEASURE_MODE_PARA_AUTO_3MIN);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_NBP_SET_MEASURE_MODE_MANUAL, ID_NBP_SET_MEASURE_MODE_AUTO_8HOUR, ID_NBP_SET_MEASURE_MODE_AUTO_3MIN, MF_BYCOMMAND);
	pcMenuPopup->CheckMenuRadioItem(ID_NBP_SET_MEASURE_MODE_AUTO_1MIN, ID_NBP_SET_MEASURE_MODE_AUTO_8HOUR, ID_NBP_SET_MEASURE_MODE_AUTO_3MIN, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnNbpSetMeasureModeAuto4min()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForMeasureMode(ZUGMED_CMD_SET_MEASURE_MODE_PARA_AUTO_4MIN);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_NBP_SET_MEASURE_MODE_MANUAL, ID_NBP_SET_MEASURE_MODE_AUTO_8HOUR, ID_NBP_SET_MEASURE_MODE_AUTO_4MIN, MF_BYCOMMAND);
	pcMenuPopup->CheckMenuRadioItem(ID_NBP_SET_MEASURE_MODE_AUTO_1MIN, ID_NBP_SET_MEASURE_MODE_AUTO_8HOUR, ID_NBP_SET_MEASURE_MODE_AUTO_4MIN, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnNbpSetMeasureModeAuto5min()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForMeasureMode(ZUGMED_CMD_SET_MEASURE_MODE_PARA_AUTO_5MIN);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_NBP_SET_MEASURE_MODE_MANUAL, ID_NBP_SET_MEASURE_MODE_AUTO_8HOUR, ID_NBP_SET_MEASURE_MODE_AUTO_5MIN, MF_BYCOMMAND);
	pcMenuPopup->CheckMenuRadioItem(ID_NBP_SET_MEASURE_MODE_AUTO_1MIN, ID_NBP_SET_MEASURE_MODE_AUTO_8HOUR, ID_NBP_SET_MEASURE_MODE_AUTO_5MIN, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnNbpSetMeasureModeAuto10min()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForMeasureMode(ZUGMED_CMD_SET_MEASURE_MODE_PARA_AUTO_10MIN);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_NBP_SET_MEASURE_MODE_MANUAL, ID_NBP_SET_MEASURE_MODE_AUTO_8HOUR, ID_NBP_SET_MEASURE_MODE_AUTO_10MIN, MF_BYCOMMAND);
	pcMenuPopup->CheckMenuRadioItem(ID_NBP_SET_MEASURE_MODE_AUTO_1MIN, ID_NBP_SET_MEASURE_MODE_AUTO_8HOUR, ID_NBP_SET_MEASURE_MODE_AUTO_10MIN, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnNbpSetMeasureModeAuto15min()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForMeasureMode(ZUGMED_CMD_SET_MEASURE_MODE_PARA_AUTO_10MIN);
	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_NBP_SET_MEASURE_MODE_MANUAL, ID_NBP_SET_MEASURE_MODE_AUTO_8HOUR, ID_NBP_SET_MEASURE_MODE_AUTO_15MIN, MF_BYCOMMAND);
	pcMenuPopup->CheckMenuRadioItem(ID_NBP_SET_MEASURE_MODE_AUTO_1MIN, ID_NBP_SET_MEASURE_MODE_AUTO_8HOUR, ID_NBP_SET_MEASURE_MODE_AUTO_15MIN, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::On32940()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForMeasureMode(ZUGMED_CMD_SET_MEASURE_MODE_PARA_AUTO_30MIN);
	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_NBP_SET_MEASURE_MODE_MANUAL, ID_NBP_SET_MEASURE_MODE_AUTO_8HOUR, ID_32940, MF_BYCOMMAND);
	pcMenuPopup->CheckMenuRadioItem(ID_NBP_SET_MEASURE_MODE_AUTO_1MIN, ID_NBP_SET_MEASURE_MODE_AUTO_8HOUR, ID_32940, MF_BYCOMMAND);

}

void CMulti_ParaMonitorDlg::OnNbpSetMeasureModeAuto60min()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForMeasureMode(ZUGMED_CMD_SET_MEASURE_MODE_PARA_AUTO_60MIN);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_NBP_SET_MEASURE_MODE_MANUAL, ID_NBP_SET_MEASURE_MODE_AUTO_8HOUR, ID_NBP_SET_MEASURE_MODE_AUTO_60MIN, MF_BYCOMMAND);
	pcMenuPopup->CheckMenuRadioItem(ID_NBP_SET_MEASURE_MODE_AUTO_1MIN, ID_NBP_SET_MEASURE_MODE_AUTO_8HOUR, ID_NBP_SET_MEASURE_MODE_AUTO_60MIN, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnNbpSetMeasureModeAuto90min()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForMeasureMode(ZUGMED_CMD_SET_MEASURE_MODE_PARA_AUTO_90MIN);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_NBP_SET_MEASURE_MODE_MANUAL, ID_NBP_SET_MEASURE_MODE_AUTO_8HOUR, ID_NBP_SET_MEASURE_MODE_AUTO_90MIN, MF_BYCOMMAND);
	pcMenuPopup->CheckMenuRadioItem(ID_NBP_SET_MEASURE_MODE_AUTO_1MIN, ID_NBP_SET_MEASURE_MODE_AUTO_8HOUR, ID_NBP_SET_MEASURE_MODE_AUTO_90MIN, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnNbpSetMeasureModeAuto2hour()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForMeasureMode(ZUGMED_CMD_SET_MEASURE_MODE_PARA_AUTO_2HOUR);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_NBP_SET_MEASURE_MODE_MANUAL, ID_NBP_SET_MEASURE_MODE_AUTO_8HOUR, ID_NBP_SET_MEASURE_MODE_AUTO_2HOUR, MF_BYCOMMAND);
	pcMenuPopup->CheckMenuRadioItem(ID_NBP_SET_MEASURE_MODE_AUTO_1MIN, ID_NBP_SET_MEASURE_MODE_AUTO_8HOUR, ID_NBP_SET_MEASURE_MODE_AUTO_2HOUR, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnNbpSetMeasureModeAuto3hour()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForMeasureMode(ZUGMED_CMD_SET_MEASURE_MODE_PARA_AUTO_3HOUR);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_NBP_SET_MEASURE_MODE_MANUAL, ID_NBP_SET_MEASURE_MODE_AUTO_8HOUR, ID_NBP_SET_MEASURE_MODE_AUTO_3HOUR, MF_BYCOMMAND);
	pcMenuPopup->CheckMenuRadioItem(ID_NBP_SET_MEASURE_MODE_AUTO_1MIN, ID_NBP_SET_MEASURE_MODE_AUTO_8HOUR, ID_NBP_SET_MEASURE_MODE_AUTO_3HOUR, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnNbpSetMeasureModeAuto4hour()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForMeasureMode(ZUGMED_CMD_SET_MEASURE_MODE_PARA_AUTO_4HOUR);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_NBP_SET_MEASURE_MODE_MANUAL, ID_NBP_SET_MEASURE_MODE_AUTO_8HOUR, ID_NBP_SET_MEASURE_MODE_AUTO_4HOUR, MF_BYCOMMAND);
	pcMenuPopup->CheckMenuRadioItem(ID_NBP_SET_MEASURE_MODE_AUTO_1MIN, ID_NBP_SET_MEASURE_MODE_AUTO_8HOUR, ID_NBP_SET_MEASURE_MODE_AUTO_4HOUR, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnNbpSetMeasureModeAuto8hour()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForMeasureMode(ZUGMED_CMD_SET_MEASURE_MODE_PARA_AUTO_8HOUR);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_NBP_SET_MEASURE_MODE_MANUAL, ID_NBP_SET_MEASURE_MODE_AUTO_8HOUR, ID_NBP_SET_MEASURE_MODE_AUTO_8HOUR, MF_BYCOMMAND);
	pcMenuPopup->CheckMenuRadioItem(ID_NBP_SET_MEASURE_MODE_AUTO_1MIN, ID_NBP_SET_MEASURE_MODE_AUTO_8HOUR, ID_NBP_SET_MEASURE_MODE_AUTO_8HOUR, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::ZugMedSndCmdForPreinflatePrs(ZUGMED_CMD_SET_PREINFLATE_PRS_PARA_LIST tPrs)
{
	ZUGMED_PACKET tPacket;

	tPacket.u8Len = 0x0B;
	tPacket.u8ParaType = PARAM_NBP;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_CMD_NBP_SET_PREINFLATE_PRS;
	tPacket.u32No = m_uiNBPSerialNo;
	tPacket.pu8Data[0] = (unsigned char)tPrs;

	m_uiNBPSerialNo ++;

	SndCmdPacket(tPacket);
}

void CMulti_ParaMonitorDlg::OnSetPreinflateAdult80mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForPreinflatePrs(ZUGMED_CMD_SET_PREINFLATE_PRS_PARA_80MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_PREINFLATE_ADULT_80MMHG, ID_SET_PREINFLATE_ADULT_280MMHG, ID_SET_PREINFLATE_ADULT_80MMHG, MF_BYCOMMAND);

}

void CMulti_ParaMonitorDlg::OnSetPreinflateAdult100mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForPreinflatePrs(ZUGMED_CMD_SET_PREINFLATE_PRS_PARA_100MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_PREINFLATE_ADULT_80MMHG, ID_SET_PREINFLATE_ADULT_280MMHG, ID_SET_PREINFLATE_ADULT_100MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetPreinflateAdult120mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForPreinflatePrs(ZUGMED_CMD_SET_PREINFLATE_PRS_PARA_120MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_PREINFLATE_ADULT_80MMHG, ID_SET_PREINFLATE_ADULT_280MMHG, ID_SET_PREINFLATE_ADULT_120MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetPreinflateAdult140mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForPreinflatePrs(ZUGMED_CMD_SET_PREINFLATE_PRS_PARA_140MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_PREINFLATE_ADULT_80MMHG, ID_SET_PREINFLATE_ADULT_280MMHG, ID_SET_PREINFLATE_ADULT_140MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetPreinflateAdult150mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForPreinflatePrs(ZUGMED_CMD_SET_PREINFLATE_PRS_PARA_150MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_PREINFLATE_ADULT_80MMHG, ID_SET_PREINFLATE_ADULT_280MMHG, ID_SET_PREINFLATE_ADULT_150MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetPreinflateAdult160mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForPreinflatePrs(ZUGMED_CMD_SET_PREINFLATE_PRS_PARA_160MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_PREINFLATE_ADULT_80MMHG, ID_SET_PREINFLATE_ADULT_280MMHG, ID_SET_PREINFLATE_ADULT_160MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetPreinflateAdult180mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForPreinflatePrs(ZUGMED_CMD_SET_PREINFLATE_PRS_PARA_180MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_PREINFLATE_ADULT_80MMHG, ID_SET_PREINFLATE_ADULT_280MMHG, ID_SET_PREINFLATE_ADULT_180MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetPreinflateAdult200mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForPreinflatePrs(ZUGMED_CMD_SET_PREINFLATE_PRS_PARA_200MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_PREINFLATE_ADULT_80MMHG, ID_SET_PREINFLATE_ADULT_280MMHG, ID_SET_PREINFLATE_ADULT_200MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetPreinflateAdult220mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForPreinflatePrs(ZUGMED_CMD_SET_PREINFLATE_PRS_PARA_220MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_PREINFLATE_ADULT_80MMHG, ID_SET_PREINFLATE_ADULT_280MMHG, ID_SET_PREINFLATE_ADULT_220MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetPreinflateAdult240mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForPreinflatePrs(ZUGMED_CMD_SET_PREINFLATE_PRS_PARA_240MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_PREINFLATE_ADULT_80MMHG, ID_SET_PREINFLATE_ADULT_280MMHG, ID_SET_PREINFLATE_ADULT_240MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetPreinflateAdult250mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForPreinflatePrs(ZUGMED_CMD_SET_PREINFLATE_PRS_PARA_250MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_PREINFLATE_ADULT_80MMHG, ID_SET_PREINFLATE_ADULT_280MMHG, ID_SET_PREINFLATE_ADULT_250MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetPreinflateAdult260mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForPreinflatePrs(ZUGMED_CMD_SET_PREINFLATE_PRS_PARA_260MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_PREINFLATE_ADULT_80MMHG, ID_SET_PREINFLATE_ADULT_280MMHG, ID_SET_PREINFLATE_ADULT_260MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetPreinflateAdult270mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForPreinflatePrs(ZUGMED_CMD_SET_PREINFLATE_PRS_PARA_270MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_PREINFLATE_ADULT_80MMHG, ID_SET_PREINFLATE_ADULT_280MMHG, ID_SET_PREINFLATE_ADULT_270MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetPreinflateAdult280mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForPreinflatePrs(ZUGMED_CMD_SET_PREINFLATE_PRS_PARA_280MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_PREINFLATE_ADULT_80MMHG, ID_SET_PREINFLATE_ADULT_280MMHG, ID_SET_PREINFLATE_ADULT_280MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetPreinflateChild80mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForPreinflatePrs(ZUGMED_CMD_SET_PREINFLATE_PRS_PARA_80MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_PREINFLATE_CHILD_80MMHG, ID_SET_PREINFLATE_CHILD_200MMHG, ID_SET_PREINFLATE_CHILD_80MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetPreinflateChild100mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForPreinflatePrs(ZUGMED_CMD_SET_PREINFLATE_PRS_PARA_100MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_PREINFLATE_CHILD_80MMHG, ID_SET_PREINFLATE_CHILD_200MMHG, ID_SET_PREINFLATE_CHILD_100MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetPreinflateChild120mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForPreinflatePrs(ZUGMED_CMD_SET_PREINFLATE_PRS_PARA_120MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_PREINFLATE_CHILD_80MMHG, ID_SET_PREINFLATE_CHILD_200MMHG, ID_SET_PREINFLATE_CHILD_120MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetPreinflateChild140mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForPreinflatePrs(ZUGMED_CMD_SET_PREINFLATE_PRS_PARA_140MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_PREINFLATE_CHILD_80MMHG, ID_SET_PREINFLATE_CHILD_200MMHG, ID_SET_PREINFLATE_CHILD_140MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetPreinflateChild160mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForPreinflatePrs(ZUGMED_CMD_SET_PREINFLATE_PRS_PARA_160MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_PREINFLATE_CHILD_80MMHG, ID_SET_PREINFLATE_CHILD_200MMHG, ID_SET_PREINFLATE_CHILD_160MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetPreinflateChild180mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForPreinflatePrs(ZUGMED_CMD_SET_PREINFLATE_PRS_PARA_180MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_PREINFLATE_CHILD_80MMHG, ID_SET_PREINFLATE_CHILD_200MMHG, ID_SET_PREINFLATE_CHILD_180MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetPreinflateChild200mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForPreinflatePrs(ZUGMED_CMD_SET_PREINFLATE_PRS_PARA_200MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_PREINFLATE_CHILD_80MMHG, ID_SET_PREINFLATE_CHILD_200MMHG, ID_SET_PREINFLATE_CHILD_200MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetPreinflateNeon60mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForPreinflatePrs(ZUGMED_CMD_SET_PREINFLATE_PRS_PARA_60MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_PREINFLATE_NEON_60MMHG, ID_SET_PREINFLATE_NEON_120MMHG, ID_SET_PREINFLATE_NEON_60MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetPreinflateNeon80mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForPreinflatePrs(ZUGMED_CMD_SET_PREINFLATE_PRS_PARA_80MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_PREINFLATE_NEON_60MMHG, ID_SET_PREINFLATE_NEON_120MMHG, ID_SET_PREINFLATE_NEON_80MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetPreinflateNeon100mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForPreinflatePrs(ZUGMED_CMD_SET_PREINFLATE_PRS_PARA_100MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_PREINFLATE_NEON_60MMHG, ID_SET_PREINFLATE_NEON_120MMHG, ID_SET_PREINFLATE_NEON_100MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetPreinflateNeon120mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForPreinflatePrs(ZUGMED_CMD_SET_PREINFLATE_PRS_PARA_120MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_PREINFLATE_NEON_60MMHG, ID_SET_PREINFLATE_NEON_120MMHG, ID_SET_PREINFLATE_NEON_120MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnNbpStartCheckLeak()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;

	tPacket.u8Len = 10;
	tPacket.u8ParaType = 0x02;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_CMD_NBP_START_CHECK_LEAK;
	tPacket.u32No = m_uiNBPSerialNo;

	m_uiNBPSerialNo ++;

	SndCmdPacket(tPacket);
}

void CMulti_ParaMonitorDlg::OnNbpStartVenipuncture()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;

	tPacket.u8Len = 10;
	tPacket.u8ParaType = 0x02;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_CMD_NBP_START_VP;
	tPacket.u32No = m_uiNBPSerialNo;

	m_uiNBPSerialNo ++;

	SndCmdPacket(tPacket);
}

void CMulti_ParaMonitorDlg::ZugMedSndCmdForVpPrs(ZUGMED_CMD_SET_VP_PRS_PARA_LIST tPrs)
{
	ZUGMED_PACKET tPacket;

	tPacket.u8Len = 0x0B;
	tPacket.u8ParaType = 0x02;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_CMD_NBP_SET_VP_PRS;
	tPacket.pu8Data[0] = (unsigned char)tPrs;

	tPacket.u32No = m_uiNBPSerialNo;

	m_uiNBPSerialNo ++;

	SndCmdPacket(tPacket);
}

void CMulti_ParaMonitorDlg::OnSetVenipunctureAdult22mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForVpPrs(ZUGMED_CMD_SET_VP_PRS_PARA_22MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_VENIPUNCTURE_ADULT_22MMHG, ID_SET_VENIPUNCTURE_ADULT_122MMHG, ID_SET_VENIPUNCTURE_ADULT_22MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetVenipunctureAdult32mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForVpPrs(ZUGMED_CMD_SET_VP_PRS_PARA_32MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_VENIPUNCTURE_ADULT_22MMHG, ID_SET_VENIPUNCTURE_ADULT_122MMHG, ID_SET_VENIPUNCTURE_ADULT_32MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetVenipunctureAdult42mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForVpPrs(ZUGMED_CMD_SET_VP_PRS_PARA_42MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_VENIPUNCTURE_ADULT_22MMHG, ID_SET_VENIPUNCTURE_ADULT_122MMHG, ID_SET_VENIPUNCTURE_ADULT_42MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetVenipunctureAdult52mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForVpPrs(ZUGMED_CMD_SET_VP_PRS_PARA_52MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_VENIPUNCTURE_ADULT_22MMHG, ID_SET_VENIPUNCTURE_ADULT_122MMHG, ID_SET_VENIPUNCTURE_ADULT_52MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetVenipunctureAdult62mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForVpPrs(ZUGMED_CMD_SET_VP_PRS_PARA_62MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_VENIPUNCTURE_ADULT_22MMHG, ID_SET_VENIPUNCTURE_ADULT_122MMHG, ID_SET_VENIPUNCTURE_ADULT_62MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetVenipunctureAdult72mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForVpPrs(ZUGMED_CMD_SET_VP_PRS_PARA_72MMHG);


	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_VENIPUNCTURE_ADULT_22MMHG, ID_SET_VENIPUNCTURE_ADULT_122MMHG, ID_SET_VENIPUNCTURE_ADULT_72MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetVenipunctureAdult82mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForVpPrs(ZUGMED_CMD_SET_VP_PRS_PARA_82MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_VENIPUNCTURE_ADULT_22MMHG, ID_SET_VENIPUNCTURE_ADULT_122MMHG, ID_SET_VENIPUNCTURE_ADULT_82MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetVenipunctureAdult92mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForVpPrs(ZUGMED_CMD_SET_VP_PRS_PARA_92MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_VENIPUNCTURE_ADULT_22MMHG, ID_SET_VENIPUNCTURE_ADULT_122MMHG, ID_SET_VENIPUNCTURE_ADULT_92MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetVenipunctureAdult102mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForVpPrs(ZUGMED_CMD_SET_VP_PRS_PARA_102MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_VENIPUNCTURE_ADULT_22MMHG, ID_SET_VENIPUNCTURE_ADULT_122MMHG, ID_SET_VENIPUNCTURE_ADULT_102MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetVenipunctureAdult112mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForVpPrs(ZUGMED_CMD_SET_VP_PRS_PARA_112MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_VENIPUNCTURE_ADULT_22MMHG, ID_SET_VENIPUNCTURE_ADULT_122MMHG, ID_SET_VENIPUNCTURE_ADULT_112MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetVenipunctureAdult122mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForVpPrs(ZUGMED_CMD_SET_VP_PRS_PARA_122MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_VENIPUNCTURE_ADULT_22MMHG, ID_SET_VENIPUNCTURE_ADULT_122MMHG, ID_SET_VENIPUNCTURE_ADULT_122MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetVenipunctureChild22mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForVpPrs(ZUGMED_CMD_SET_VP_PRS_PARA_22MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_VENIPUNCTURE_CHILD_22MMHG, ID_SET_VENIPUNCTURE_CHILD_82MMHG, ID_SET_VENIPUNCTURE_CHILD_22MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetVenipunctureChild32mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForVpPrs(ZUGMED_CMD_SET_VP_PRS_PARA_32MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_VENIPUNCTURE_CHILD_22MMHG, ID_SET_VENIPUNCTURE_CHILD_82MMHG, ID_SET_VENIPUNCTURE_CHILD_32MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetVenipunctureChild42mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForVpPrs(ZUGMED_CMD_SET_VP_PRS_PARA_42MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_VENIPUNCTURE_CHILD_22MMHG, ID_SET_VENIPUNCTURE_CHILD_82MMHG, ID_SET_VENIPUNCTURE_CHILD_42MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetVenipunctureChild52mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForVpPrs(ZUGMED_CMD_SET_VP_PRS_PARA_52MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_VENIPUNCTURE_CHILD_22MMHG, ID_SET_VENIPUNCTURE_CHILD_82MMHG, ID_SET_VENIPUNCTURE_CHILD_52MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetVenipunctureChild62mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForVpPrs(ZUGMED_CMD_SET_VP_PRS_PARA_62MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_VENIPUNCTURE_CHILD_22MMHG, ID_SET_VENIPUNCTURE_CHILD_82MMHG, ID_SET_VENIPUNCTURE_CHILD_62MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetVenipunctureChild72mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForVpPrs(ZUGMED_CMD_SET_VP_PRS_PARA_72MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_VENIPUNCTURE_CHILD_22MMHG, ID_SET_VENIPUNCTURE_CHILD_82MMHG, ID_SET_VENIPUNCTURE_CHILD_72MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetVenipunctureChild82mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForVpPrs(ZUGMED_CMD_SET_VP_PRS_PARA_82MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_VENIPUNCTURE_CHILD_22MMHG, ID_SET_VENIPUNCTURE_CHILD_82MMHG, ID_SET_VENIPUNCTURE_CHILD_82MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetVenipunctureNeon22mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForVpPrs(ZUGMED_CMD_SET_VP_PRS_PARA_22MMHG);


	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_VENIPUNCTURE_NEON_22MMHG, ID_SET_VENIPUNCTURE_NEON_52MMHG, ID_SET_VENIPUNCTURE_NEON_22MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetVenipunctureNeon32mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForVpPrs(ZUGMED_CMD_SET_VP_PRS_PARA_32MMHG);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_VENIPUNCTURE_NEON_22MMHG, ID_SET_VENIPUNCTURE_NEON_52MMHG, ID_SET_VENIPUNCTURE_NEON_32MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetVenipunctureNeon42mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForVpPrs(ZUGMED_CMD_SET_VP_PRS_PARA_42MMHG);
	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_VENIPUNCTURE_NEON_22MMHG, ID_SET_VENIPUNCTURE_NEON_52MMHG, ID_SET_VENIPUNCTURE_NEON_42MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnSetVenipunctureNeon52mmhg()
{
	// TODO: 在此添加命令处理程序代码
	ZugMedSndCmdForVpPrs(ZUGMED_CMD_SET_VP_PRS_PARA_52MMHG);
	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_VENIPUNCTURE_NEON_22MMHG, ID_SET_VENIPUNCTURE_NEON_52MMHG, ID_SET_VENIPUNCTURE_NEON_52MMHG, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnNbpReset()
{
	// TODO: 在此添加命令处理程序代码
}

void CMulti_ParaMonitorDlg::OnSetPatienttype()
{
	// TODO: 在此添加命令处理程序代码
	CSetPatientDlg Dlg;
	Dlg.m_pDlg = this;
	Dlg.m_PatientTypeInfo = m_PatTypeInfo;

	if (Dlg.DoModal() == IDOK)
	{
		m_PatTypeInfo = Dlg.m_PatientTypeInfo;
	}
}

void CMulti_ParaMonitorDlg::OnSpo2Patienttype()
{
	// TODO: 在此添加命令处理程序代码
	CSetPatientDlg Dlg;
	Dlg.m_pDlg = this;
	Dlg.m_PatientTypeInfo = m_PatTypeInfo;

	if (Dlg.DoModal() == IDOK)
	{
		m_PatTypeInfo = Dlg.m_PatientTypeInfo;
	}
}

void CMulti_ParaMonitorDlg::OnEcgPatienttype()
{
	// TODO: 在此添加命令处理程序代码
	CSetPatientDlg Dlg;
	Dlg.m_pDlg = this;
	Dlg.m_PatientTypeInfo = m_PatTypeInfo;

	if (Dlg.DoModal() == IDOK)
	{
		m_PatTypeInfo = Dlg.m_PatientTypeInfo;
	}
}

void CMulti_ParaMonitorDlg::OnEnableSoftProtect()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;

	tPacket.u8Len = 0x0B;
	tPacket.u8ParaType = 0x02;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_CMD_NBP_SET_SECURITY;
	tPacket.u32No = m_uiNBPSerialNo;
	tPacket.pu8Data[0] = ZUGMED_CMD_SET_SECURITY_PARA_ENABLE_SOFT_PROTECT;

	m_uiNBPSerialNo ++;

	SndCmdPacket(tPacket);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_ENABLE_SOFT_PROTECT, ID_DISABLE_SOFT_PROTECT, ID_ENABLE_SOFT_PROTECT, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnDisableSoftProtect()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;

	tPacket.u8Len = 0x0B;
	tPacket.u8ParaType = 0x02;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_CMD_NBP_SET_SECURITY;
	tPacket.u32No = m_uiNBPSerialNo;
	tPacket.pu8Data[0] = ZUGMED_CMD_SET_SECURITY_PARA_DISABLE_SOFT_PROTECT;

	m_uiNBPSerialNo ++;

	SndCmdPacket(tPacket);

	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_ENABLE_SOFT_PROTECT, ID_DISABLE_SOFT_PROTECT, ID_DISABLE_SOFT_PROTECT, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnNibpModuleInfo()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;
	tPacket.u8Len = 0x0A;
	tPacket.u8ParaType = 0x02;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DR;
	tPacket.u8Id = ZUGMED_CMD_NBP_REQUEST_MODULE_INFO;
	tPacket.u32No = m_uiNBPSerialNo;

	m_uiNBPSerialNo++;

	m_uiNBPSerialNo ++;

	SndCmdPacket(tPacket);
}

void CMulti_ParaMonitorDlg::OnRequestTestResult()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;
	tPacket.u8Len = 0x0A;
	tPacket.u8ParaType = 0x02;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DR;
	tPacket.u8Id = ZUGMED_CMD_NBP_REQUEST_TEST_RESULT;
	tPacket.u32No = m_uiNBPSerialNo;

	m_uiNBPSerialNo ++;

	SndCmdPacket(tPacket);
}

void CMulti_ParaMonitorDlg::OnRequestPostResult()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;
	tPacket.u8Len = 0x0A;
	tPacket.u8ParaType = 0x02;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DR;
	tPacket.u8Id = ZUGMED_CMD_NBP_REQUEST_MODULE_INFO;
	tPacket.u32No = m_uiNBPSerialNo;

	m_uiNBPSerialNo ++;

	SndCmdPacket(tPacket);
}

void CMulti_ParaMonitorDlg::OnRequestCuffPrs()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;

	tPacket.u8Len = 10;
	tPacket.u8ParaType = 0x02;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DR;
	tPacket.u8Id = ZUGMED_CMD_NBP_REQUEST_CUFF_PRS;
	tPacket.u32No = m_uiNBPSerialNo;

	m_uiNBPSerialNo++;

	SndCmdPacket(tPacket);
}

void CMulti_ParaMonitorDlg::OnNibpPrscalibrate()
{
	// TODO: 在此添加命令处理程序代码
	CNbpCaliDlg dlg;
	dlg.m_pMultiDlg = this;
	dlg.DoModal();
}

void CMulti_ParaMonitorDlg::ZugMedSndCmdForCalibrate(unsigned short u16Data)
{
	ZUGMED_PACKET tPacket;

	tPacket.u8Len = 0x0C;
	tPacket.u8ParaType = PARAM_NBP;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_CMD_NBP_START_CALIBRATE_PRS;
	tPacket.u32No = m_uiNBPSerialNo;
	tPacket.pu8Data[0] = (unsigned char)u16Data;
	tPacket.pu8Data[1] = (unsigned char)(u16Data>>8);

	m_uiNBPSerialNo++;

	SndCmdPacket(tPacket);
}

void CMulti_ParaMonitorDlg::OnNibpStopCmd()
{
	ZUGMED_PACKET tPacket;
	tPacket.u8Len = 0x0A;
	tPacket.u8ParaType = 0x02;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_CMD_NBP_STOP;
	tPacket.u32No = m_uiNBPSerialNo;

	m_uiNBPSerialNo++;

	SndCmdPacket(tPacket);
}

void CMulti_ParaMonitorDlg::ZugMedSndCmdForCuffPrsPara(UINT uiCurrentPrs, UINT uiActualPrs)
{
	ZUGMED_PACKET tPacket;

	tPacket.u8Len = 0x0E;
	tPacket.u8ParaType = 0x02;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_CMD_NBP_SET_CUFFPRS_PARA;
	tPacket.u32No = m_uiNBPSerialNo;
	tPacket.pu8Data[0] = (unsigned char)(uiCurrentPrs & 0xFF);
	tPacket.pu8Data[1] = (unsigned char)((uiCurrentPrs >> 8) & 0xFF);
	tPacket.pu8Data[2] = (unsigned char)(uiActualPrs & 0xFF);
	tPacket.pu8Data[3] = (unsigned char)((uiActualPrs >> 8) & 0xFF);

	m_uiNBPSerialNo++;

	SndCmdPacket(tPacket);
}
void CMulti_ParaMonitorDlg::OnUpdate()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;
	tPacket.u8ParaType = PARAM_ECG;
	tPacket.u8Len = 10;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_UPDATE;	
	SndCmdPacket(tPacket);
}

void CMulti_ParaMonitorDlg::OnNbpStartUpdate()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;

	tPacket.u8Len = 0x0A;
	tPacket.u8ParaType = 0x02;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_CMD_NBP_UPDATE;
	tPacket.u32No = m_uiNBPSerialNo;
	m_uiNBPSerialNo++;
	SndCmdPacket(tPacket);
}

void CMulti_ParaMonitorDlg::SetCommPort(int Num)
{
	bool CommFlag= FALSE;
	
	if (m_pcComWatchThread != NULL)
	{
		m_pcComWatchThread->SuspendThread();
		Sleep(50);

		delete m_pcComWatchThread;
		m_pcComWatchThread = NULL;
	}

	if (m_pcComPort != NULL)
	{
		delete m_pcComPort;
		m_pcComPort = NULL;
	//	Sleep(10);
	}

	m_pcComPort = new CComPort(Num-1);
	if ( FALSE == m_pcComPort->Initialize())
	{
		delete m_pcComPort;
		m_pcComPort = NULL;

		CommFlag= FALSE;
	}
	else
	{
		CommFlag = TRUE;
		m_pcComWatchThread=new CComWatchThread(m_pcComPort, this);
		m_pcComWatchThread->CreateThread(CREATE_SUSPENDED);
		m_pcComWatchThread->SetThreadPriority(THREAD_PRIORITY_LOWEST);
		m_pcComWatchThread->ResumeThread();
	}

	if (CommFlag == FALSE)
	{
		MessageBox(_T("failed to initialize,please again!"),_T("Worning!"),MB_ICONWARNING);
	}
}


void CMulti_ParaMonitorDlg::MenuDefaultSel(void)
{
	CMenu *pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_HR_CHI, ID_SET_HR_CHII, ID_SET_HR_AUTO, MF_BYCOMMAND);
	
	pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_LAYOUT_3D, ID_SET_LAYOUT_5D, ID_SET_LAYOUT_5D, MF_BYCOMMAND);
	
	pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_SCAN_SPEED_ECG_2MS, ID_SET_SCAN_SPEED_ECG_10MS, ID_SET_SCAN_SPEED_ECG_2MS, MF_BYCOMMAND);
	
	pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_SCAN_SPEED_RESP_2MS, ID_SET_SCAN_SPEED_RESP_20MS, ID_SET_SCAN_SPEED_RESP_10MS, MF_BYCOMMAND);
	
	pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_START_ECG_CAL, ID_STOP_ECG_CAL, ID_STOP_ECG_CAL, MF_BYCOMMAND);

	pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_FILTER_DIAG, ID_SET_FILTER_SURGERY, ID_SET_FILTER_MONITOR, MF_BYCOMMAND);
	
	pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_GAIN_CHALL_X250, ID_SET_GAIN_CHALL_X2000, ID_SET_GAIN_CHALL_X1000, MF_BYCOMMAND);

	pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_50HZ_TRAP, ID_SET_NO_TRAP, ID_SET_NO_TRAP, MF_BYCOMMAND);

	pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_RESP_SENSITIVITY_1, ID_SET_RESP_SENSITIVITY_5, ID_SET_RESP_SENSITIVITY_2, MF_BYCOMMAND);

	pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_APNEA_TIME_5S, ID_SETTINGAPNEATIME_20S, ID_SETTINGAPNEATIME_20S, MF_BYCOMMAND);

	pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_RESP_LEAD_I, ID_SET_RESP_LEAD_II, ID_SET_RESP_LEAD_I, MF_BYCOMMAND);
	
	pcMenuPopup = m_cMenu.GetSubMenu(0);
	pcMenuPopup->CheckMenuRadioItem(ID_ENABLE_PACE_DETECTION, ID_DISABLE_PACE_DETECTION, ID_DISABLE_PACE_DETECTION, MF_BYCOMMAND);
	
	pcMenuPopup = m_cMenu.GetSubMenu(2);
	pcMenuPopup->CheckMenuRadioItem(ID_SPO2_SENSTIVITY_1, ID_SPO2_SENSTIVITY_4, ID_SPO2_SENSTIVITY_1, MF_BYCOMMAND);
	
	pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_NBP_SET_MEASURE_MODE_MANUAL, ID_NBP_SET_MEASURE_MODE_AUTO_8HOUR, ID_NBP_SET_MEASURE_MODE_MANUAL, MF_BYCOMMAND);
	
	pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_PREINFLATE_ADULT_80MMHG, ID_SET_PREINFLATE_ADULT_280MMHG, ID_SET_PREINFLATE_ADULT_160MMHG, MF_BYCOMMAND);
	
	pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_PREINFLATE_CHILD_80MMHG, ID_SET_PREINFLATE_CHILD_200MMHG, ID_SET_PREINFLATE_CHILD_140MMHG, MF_BYCOMMAND);

	pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_PREINFLATE_NEON_60MMHG, ID_SET_PREINFLATE_NEON_120MMHG, ID_SET_PREINFLATE_NEON_100MMHG, MF_BYCOMMAND);
	
	pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_VENIPUNCTURE_ADULT_22MMHG, ID_SET_VENIPUNCTURE_ADULT_122MMHG, ID_SET_VENIPUNCTURE_ADULT_82MMHG, MF_BYCOMMAND);
	
	pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_VENIPUNCTURE_CHILD_22MMHG, ID_SET_VENIPUNCTURE_CHILD_82MMHG, ID_SET_VENIPUNCTURE_CHILD_62MMHG, MF_BYCOMMAND);

	pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_SET_VENIPUNCTURE_NEON_22MMHG, ID_SET_VENIPUNCTURE_NEON_52MMHG, ID_SET_VENIPUNCTURE_NEON_42MMHG, MF_BYCOMMAND);
	
	pcMenuPopup = m_cMenu.GetSubMenu(1);
	pcMenuPopup->CheckMenuRadioItem(ID_ENABLE_SOFT_PROTECT, ID_DISABLE_SOFT_PROTECT, ID_ENABLE_SOFT_PROTECT, MF_BYCOMMAND);
}


void CMulti_ParaMonitorDlg::OnChanneliLeadi()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;

	tPacket.u8Len = 0x0B;
	tPacket.u8ParaType = 0x01;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_ECG_SET_LEAD;
	tPacket.pu8Data[0] = 1;

	SndCmdPacket(tPacket);
	m_ptEcgLeadPos[0] = ECG_LEAD_I;
	//AdjustLeadPos();


	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(2);
	pcMenuPopup->CheckMenuRadioItem(ID_CHANNELI_LEADI, ID_CHANNELI_LEADAVF, ID_CHANNELI_LEADI, MF_BYCOMMAND);

}

void CMulti_ParaMonitorDlg::OnChanneliLeadii()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;

	tPacket.u8Len = 0x0B;
	tPacket.u8ParaType = 0x01;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_ECG_SET_LEAD;
	tPacket.pu8Data[0] = 2;

	SndCmdPacket(tPacket);
	m_ptEcgLeadPos[0] = ECG_LEAD_II;
	//AdjustLeadPos();


	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(2);
	pcMenuPopup->CheckMenuRadioItem(ID_CHANNELI_LEADI, ID_CHANNELI_LEADAVF, ID_CHANNELI_LEADII, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnChanneliLeadiii()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;

	tPacket.u8Len = 0x0B;
	tPacket.u8ParaType = 0x01;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_ECG_SET_LEAD;
	tPacket.pu8Data[0] = 3;

	SndCmdPacket(tPacket);
	m_ptEcgLeadPos[0] = ECG_LEAD_III;
	//AdjustLeadPos();


	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(2);
	pcMenuPopup->CheckMenuRadioItem(ID_CHANNELI_LEADI, ID_CHANNELI_LEADAVF, ID_CHANNELI_LEADIII, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnChanneliLeadavr()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;

	tPacket.u8Len = 0x0B;
	tPacket.u8ParaType = 0x01;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_ECG_SET_LEAD;
	tPacket.pu8Data[0] = 4;

	SndCmdPacket(tPacket);
	m_ptEcgLeadPos[0] = ECG_LEAD_AVR;
	//AdjustLeadPos();


	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(2);
	pcMenuPopup->CheckMenuRadioItem(ID_CHANNELI_LEADI, ID_CHANNELI_LEADAVF, ID_CHANNELI_LEADAVR, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnChanneliLeadavl()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;

	tPacket.u8Len = 0x0B;
	tPacket.u8ParaType = 0x01;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_ECG_SET_LEAD;
	tPacket.pu8Data[0] = 5;

	SndCmdPacket(tPacket);
	m_ptEcgLeadPos[0] = ECG_LEAD_AVL;
	//AdjustLeadPos();


	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(2);
	pcMenuPopup->CheckMenuRadioItem(ID_CHANNELI_LEADI, ID_CHANNELI_LEADAVF, ID_CHANNELI_LEADAVL, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnChanneliLeadavf()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;

	tPacket.u8Len = 0x0B;
	tPacket.u8ParaType = 0x01;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_ECG_SET_LEAD;
	tPacket.pu8Data[0] = 6;

	SndCmdPacket(tPacket);
	m_ptEcgLeadPos[0] = ECG_LEAD_AVF;
	//AdjustLeadPos();


	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(2);
	pcMenuPopup->CheckMenuRadioItem(ID_CHANNELI_LEADI, ID_CHANNELI_LEADAVF, ID_CHANNELI_LEADAVF, MF_BYCOMMAND);
}


void CMulti_ParaMonitorDlg::OnChanneliiLeadi()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;

	tPacket.u8Len = 0x0B;
	tPacket.u8ParaType = 0x01;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_ECG_SET_LEAD;
	tPacket.pu8Data[0] = 0x11;

	SndCmdPacket(tPacket);
	m_ptEcgLeadPos[1] = ECG_LEAD_I;
	//AdjustLeadPos();


	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(2);
	pcMenuPopup->CheckMenuRadioItem(ID_CHANNELII_LEADI, ID_CHANNELII_LEADAVF, ID_CHANNELII_LEADI, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnChanneliiLeadii()
{
	// TODO: 在此添加命令处理程序代码
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;

	tPacket.u8Len = 0x0B;
	tPacket.u8ParaType = 0x01;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_ECG_SET_LEAD;
	tPacket.pu8Data[0] = 0x12;

	SndCmdPacket(tPacket);
	m_ptEcgLeadPos[1] = ECG_LEAD_II;
	//AdjustLeadPos();


	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(2);
	pcMenuPopup->CheckMenuRadioItem(ID_CHANNELII_LEADI, ID_CHANNELII_LEADAVF, ID_CHANNELII_LEADII, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnChanneliiLeadiii()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;

	tPacket.u8Len = 0x0B;
	tPacket.u8ParaType = 0x01;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_ECG_SET_LEAD;
	tPacket.pu8Data[0] = 0x13;

	SndCmdPacket(tPacket);
	m_ptEcgLeadPos[1] = ECG_LEAD_III;
	//AdjustLeadPos();


	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(2);
	pcMenuPopup->CheckMenuRadioItem(ID_CHANNELII_LEADI, ID_CHANNELII_LEADAVF, ID_CHANNELII_LEADIII, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnChanneliiLeadavr()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;

	tPacket.u8Len = 0x0B;
	tPacket.u8ParaType = 0x01;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_ECG_SET_LEAD;
	tPacket.pu8Data[0] = 0x14;

	SndCmdPacket(tPacket);
	m_ptEcgLeadPos[1] = ECG_LEAD_AVR;
	//AdjustLeadPos();


	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(2);
	pcMenuPopup->CheckMenuRadioItem(ID_CHANNELII_LEADI, ID_CHANNELII_LEADAVF, ID_CHANNELII_LEADAVR, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnChanneliiLeadavl()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;

	tPacket.u8Len = 0x0B;
	tPacket.u8ParaType = 0x01;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_ECG_SET_LEAD;
	tPacket.pu8Data[0] = 0x15;

	SndCmdPacket(tPacket);
	m_ptEcgLeadPos[1] = ECG_LEAD_AVL;
	//AdjustLeadPos();


	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(2);
	pcMenuPopup->CheckMenuRadioItem(ID_CHANNELII_LEADI, ID_CHANNELII_LEADAVF, ID_CHANNELII_LEADAVL, MF_BYCOMMAND);
}

void CMulti_ParaMonitorDlg::OnChanneliiLeadavf()
{
	// TODO: 在此添加命令处理程序代码
	ZUGMED_PACKET tPacket;

	tPacket.u8Len = 0x0B;
	tPacket.u8ParaType = 0x01;
	tPacket.u8Type = ZUGMED_PACKET_TYPE_DC;
	tPacket.u8Id = ZUGMED_PACKET_ID_CMD_ECG_SET_LEAD;
	tPacket.pu8Data[0] = 0x16;

	SndCmdPacket(tPacket);
	m_ptEcgLeadPos[1] = ECG_LEAD_AVF;
	//AdjustLeadPos();


	CMenu * pcMenuPopup = m_cMenu.GetSubMenu(2);
	pcMenuPopup->CheckMenuRadioItem(ID_CHANNELII_LEADI, ID_CHANNELII_LEADAVF, ID_CHANNELII_LEADAVF, MF_BYCOMMAND);
}
