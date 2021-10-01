// Multi_Para MonitorDlg.h : 头文件
//
#include "Resource.h"
#include "PackID.h"
#include "ComWatchThread.h"
#include "LAYOUT.h"
#include "SpO2Wave.h"
#include "SpO2Info.h"
#include "StaticRespWave.h"
#include "StaticEcgWave.h"
#include "StaticEcgInfo.h"
#include "StaticRespInfo.h"
#include "StaticTempInfo.h"
#include "NibpInfo.h"
#include "DebugInfoDlg.h"
#include "SetPatientDlg.h"

#pragma once
// CMulti_ParaMonitorDlg 对话框
class CMulti_ParaMonitorDlg : public CDialog
{
// 构造
public:
	CMulti_ParaMonitorDlg(CWnd* pParent = NULL);	// 标准构造函数

// 对话框数据
	enum { IDD = IDD_MULTI_PARAMONITOR_DIALOG };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV 支持

// 实现
protected:
	HICON m_hIcon;

	// 生成的消息映射函数
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	DECLARE_MESSAGE_MAP()

public:
	CSpO2Wave m_SpO2Wave;
	CComPort * m_pcComPort;
	CComWatchThread *m_pcComWatchThread;
	CDebugInfoDlg *m_pDebugInfoDlg;
	CProgressCtrl m_SpO2Bar;
	CSpO2Info m_SpO2Info;
	CStaticRespWave m_RespWave;
	CStaticEcgWave m_pEcgWave[6];
	CStaticEcgInfo m_EcgInfo;
	CStaticRespInfo m_RespInfo;
	CStaticTempInfo m_TempInfo;
	CNibpInfo m_NibpInfo;
	ECG_LEAD_NAME m_ptEcgLeadPos[6];
	unsigned int m_puiEcgLeadData[6];
	unsigned int m_uiEcgScanSpeed;
	unsigned int m_uiRespScanSpeed;
	CMenu m_cMenu;
	int m_MenuNum;
	UINT m_uiNBPSerialNo;
	PATIENT_TYPE_INFO m_PatTypeInfo;

public:
	void RcvData(ZUGMED_PACKET tPacket);
	void InitTheWindow();
	void InitCommPort();
	void RcvSpO2Data(ZUGMED_PACKET tPacket); 	
	void RcvEcgData(ZUGMED_PACKET tPacket); 	
	void RcvNIBPData(ZUGMED_PACKET tPacket); 	
	void SndCmdPacket(ZUGMED_PACKET tPacket);
	void SndStartCmd();
	void InitEcg3DWindow();
	void InitEcg5DWindow();
	void InitVari();
	void SetPatientType(BOOL Ecg,BOOL Nibp,BOOL SpO2,PATIENT_TYPE num);

	//Ecg
	void HandlePacketUpEcgRespWave(ZUGMED_PACKET * ptPacket);
	void CalLeadData(unsigned int uiData0 , unsigned int uiData1);
	void HandlePacketParRespApnea(ZUGMED_PACKET * ptPacket);
	void HandlePacketParTempData(ZUGMED_PACKET * ptPacket);
	void HandlePacketParHrRr(ZUGMED_PACKET * ptPacket);
	void HandlePacketRespCva(ZUGMED_PACKET * ptPacket);
	void HandleEcgPacketStart();
	void HandlePacketResponseGeneral(ZUGMED_PACKET * ptPacket);
	void HandlePacketParLeadStatus(ZUGMED_PACKET * ptPacket);
	void HandlePacketParEcgOverload(ZUGMED_PACKET * ptPacket);

	void ZugMedSndCmdForMeasureMode(ZUGMED_CMD_SET_MEASURE_MODE_PARA_LIST tMode);
	void ZugMedSndCmdForPreinflatePrs(ZUGMED_CMD_SET_PREINFLATE_PRS_PARA_LIST tPrs);
	void ZugMedSndCmdForVpPrs(ZUGMED_CMD_SET_VP_PRS_PARA_LIST tPrs);
	void ZugMedSndCmdForCalibrate(unsigned short u16Data);
	void OnNibpStopCmd();
	void ZugMedSndCmdForCuffPrsPara(UINT uiCurrentPrs, UINT uiActualPrs);
	void ZugMedRcvResult(ZUGMED_ERROR_MESSAGE_LIST tErrorMessage, unsigned short uiMeanPrs, unsigned short uiSysPrs, unsigned short uiDiaPrs, unsigned short uiPlsRate, PATIENT_MODE_LIST tPatientMode, ZUGMED_NOTIFY_LIST tSystemStatus, MEASURE_MODE_LIST tMeasureMode);

	afx_msg void OnRButtonDown(UINT nFlags, CPoint point);
	afx_msg void OnLButtonDown(UINT nFlags, CPoint point);
	afx_msg void OnSetLayout3d();
	afx_msg void OnSetLayout5d();
	afx_msg void OnSetFilterDiag();
	afx_msg void OnSetFilterMonitor();
	afx_msg void OnSetFilterHardest();
	afx_msg void OnSetFilterSurgery();
	afx_msg void OnSet50hzTrap();
	afx_msg void OnSet60hzTrap();
	afx_msg void OnSet5060hzTrap();
	afx_msg void OnSetNoTrap();
	afx_msg void OnSetHrAuto();
	afx_msg void OnSetHrChi();
	afx_msg void OnSetHrChii();
	afx_msg void OnEnablePaceDetection();
	afx_msg void OnDisablePaceDetection();
	afx_msg void OnStartEcgCal();
	afx_msg void OnStopEcgCal();
	afx_msg void OnSetPaceLeadI();
	afx_msg void OnSetPaceLeadIi();
	afx_msg void OnSetPaceLeadIii();
	afx_msg void OnSetPaceLeadAvl();
	afx_msg void OnSetPaceLeadAvr();
	afx_msg void OnSetPaceLeadAvf();
	afx_msg void OnSetApneaTime5s();
	afx_msg void OnSetApneaTime10s();
	afx_msg void OnSetApneaTime15s();
	afx_msg void OnSetRespLeadI();
	afx_msg void OnSetRespLeadIi();
	afx_msg void OnSetRespSensitivity1();
	afx_msg void OnSetRespSensitivity2();
	afx_msg void OnSetRespSensitivity3();
	afx_msg void OnSetRespSensitivity4();
	afx_msg void OnSetRespSensitivity5();
	afx_msg void OnSetGainChallX250();
	afx_msg void OnSetGainChallX500();
	afx_msg void OnSetGainChallX1000();
	afx_msg void OnSetGainChallX2000();
	afx_msg void OnSetScanSpeedEcg2ms();
	afx_msg void OnSetScanSpeedEcg4ms();
	afx_msg void OnSetScanSpeedEcg10ms();
	afx_msg void OnSetScanSpeedResp2ms();
	afx_msg void OnSetScanSpeedResp4ms();
	afx_msg void OnSetScanSpeedResp10ms();
	afx_msg void OnSetScanSpeedResp20ms();
	afx_msg void OnSppo2SeltTest();
	afx_msg void OnSpo2Senstivity1();
	afx_msg void OnSpo2Senstivity2();
	afx_msg void OnSpo2Senstivity3();
	afx_msg void OnSpo2Senstivity4();
	afx_msg void OnModuleinfo();
	afx_msg void OnSpo2moduleUpdate();
	afx_msg void OnNbpStart();
	afx_msg void OnNibpStop();
	afx_msg void OnNbpSetMeasureModeManual();
	afx_msg void OnNbpSetMeasureModeCont();
	afx_msg void OnNbpSetMeasureModeAuto1min();
	afx_msg void OnNbpSetMeasureModeAuto2min();
	afx_msg void OnNbpSetMeasureModeAuto3min();
	afx_msg void OnNbpSetMeasureModeAuto4min();
	afx_msg void OnNbpSetMeasureModeAuto5min();
	afx_msg void OnNbpSetMeasureModeAuto10min();
	afx_msg void OnNbpSetMeasureModeAuto15min();
	afx_msg void On32940();
	afx_msg void OnNbpSetMeasureModeAuto60min();
	afx_msg void OnNbpSetMeasureModeAuto90min();
	afx_msg void OnNbpSetMeasureModeAuto2hour();
	afx_msg void OnNbpSetMeasureModeAuto3hour();
	afx_msg void OnNbpSetMeasureModeAuto4hour();
	afx_msg void OnNbpSetMeasureModeAuto8hour();
	afx_msg void OnSetPreinflateAdult80mmhg();
	afx_msg void OnSetPreinflateAdult100mmhg();
	afx_msg void OnSetPreinflateAdult120mmhg();
	afx_msg void OnSetPreinflateAdult140mmhg();
	afx_msg void OnSetPreinflateAdult150mmhg();
	afx_msg void OnSetPreinflateAdult160mmhg();
	afx_msg void OnSetPreinflateAdult180mmhg();
	afx_msg void OnSetPreinflateAdult200mmhg();
	afx_msg void OnSetPreinflateAdult220mmhg();
	afx_msg void OnSetPreinflateAdult240mmhg();
	afx_msg void OnSetPreinflateAdult250mmhg();
	afx_msg void OnSetPreinflateAdult260mmhg();
	afx_msg void OnSetPreinflateAdult270mmhg();
	afx_msg void OnSetPreinflateAdult280mmhg();
	afx_msg void OnSetPreinflateChild80mmhg();
	afx_msg void OnSetPreinflateChild100mmhg();
	afx_msg void OnSetPreinflateChild120mmhg();
	afx_msg void OnSetPreinflateChild140mmhg();
	afx_msg void OnSetPreinflateChild160mmhg();
	afx_msg void OnSetPreinflateChild180mmhg();
	afx_msg void OnSetPreinflateChild200mmhg();
	afx_msg void OnSetPreinflateNeon60mmhg();
	afx_msg void OnSetPreinflateNeon80mmhg();
	afx_msg void OnSetPreinflateNeon100mmhg();
	afx_msg void OnSetPreinflateNeon120mmhg();
	afx_msg void OnNbpStartCheckLeak();
	afx_msg void OnNbpStartVenipuncture();
	afx_msg void OnSetVenipunctureAdult22mmhg();
	afx_msg void OnSetVenipunctureAdult32mmhg();
	afx_msg void OnSetVenipunctureAdult42mmhg();
	afx_msg void OnSetVenipunctureAdult52mmhg();
	afx_msg void OnSetVenipunctureAdult62mmhg();
	afx_msg void OnSetVenipunctureAdult72mmhg();
	afx_msg void OnSetVenipunctureAdult82mmhg();
	afx_msg void OnSetVenipunctureAdult92mmhg();
	afx_msg void OnSetVenipunctureAdult102mmhg();
	afx_msg void OnSetVenipunctureAdult112mmhg();
	afx_msg void OnSetVenipunctureAdult122mmhg();
	afx_msg void OnSetVenipunctureChild22mmhg();
	afx_msg void OnSetVenipunctureChild32mmhg();
	afx_msg void OnSetVenipunctureChild42mmhg();
	afx_msg void OnSetVenipunctureChild52mmhg();
	afx_msg void OnSetVenipunctureChild62mmhg();
	afx_msg void OnSetVenipunctureChild72mmhg();
	afx_msg void OnSetVenipunctureChild82mmhg();
	afx_msg void OnSetVenipunctureNeon22mmhg();
	afx_msg void OnSetVenipunctureNeon32mmhg();
	afx_msg void OnSetVenipunctureNeon42mmhg();
	afx_msg void OnSetVenipunctureNeon52mmhg();
	afx_msg void OnNbpReset();
	afx_msg void OnSetPatienttype();
	afx_msg void OnSpo2Patienttype();
	afx_msg void OnEcgPatienttype();
	afx_msg void OnEnableSoftProtect();
	afx_msg void OnDisableSoftProtect();
	afx_msg void OnNibpModuleInfo();
	afx_msg void OnRequestTestResult();
	afx_msg void OnRequestPostResult();
	afx_msg void OnRequestCuffPrs();
	afx_msg void OnNibpPrscalibrate();
	afx_msg void OnUpdate();
	afx_msg void OnNbpStartUpdate();
	void SetCommPort(int Num);
	void MenuDefaultSel(void);
	afx_msg void OnSettingapneatime20s();
	afx_msg void OnChanneliLeadi();
	afx_msg void OnChanneliLeadii();
	afx_msg void OnChanneliLeadiii();
	afx_msg void OnChanneliLeadavr();
	afx_msg void OnChanneliLeadavl();
	afx_msg void OnChanneliLeadavf();
	afx_msg void OnChanneliiLeadi();
	afx_msg void OnChanneliiLeadii();
	afx_msg void OnChanneliiLeadiii();
	afx_msg void OnChanneliiLeadavr();
	afx_msg void OnChanneliiLeadavl();
	afx_msg void OnChanneliiLeadavf();
};
