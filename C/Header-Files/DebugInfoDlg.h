#pragma once
#include "staticresultinfo.h"
#include "StaticCuffPrsInfo.h"
#include "colorstatic.h"
#include "enumerate.h"

// CDebugInfoDlg �Ի���

class CDebugInfoDlg : public CDialog
{
	DECLARE_DYNAMIC(CDebugInfoDlg)

public:
	CDebugInfoDlg(CWnd* pParent = NULL);   // ��׼���캯��
	virtual ~CDebugInfoDlg();

// �Ի�������
	enum { IDD = IDD_DEBUGINFO_DIALOG };

protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV ֧��

	DECLARE_MESSAGE_MAP()
public:
	virtual BOOL OnInitDialog();
	CStaticCuffPrsInfo m_NbpRealPrs;
	CStaticResultInfo m_NBPPatientType;
	CStaticResultInfo m_NBPMode;
	CStaticResultInfo m_NBPErr;
	void SetLeadStatus(ECG_LEAD_MODE tLeadMode, unsigned char uchLeadRaLaLlOffFlag, unsigned char uchLeadVxOffFlag, unsigned char uchChannelExistFlag);
	void SetChannelOvldStatus(unsigned char uchOvldStatus);

private:
	CColorStatic m_ctrlLeadSetTxt;
	CColorStatic m_ctrlLeadSet;

	CColorStatic m_ctrlElectrodeTxt;
	CColorStatic m_ctrlRAOff;
	CColorStatic m_ctrlLAOff;
	CColorStatic m_ctrlLLOff;
	CColorStatic m_ctrlRLOff;

	CColorStatic m_ctrlChannelExistTxt;
	CColorStatic m_ctrlCHIExist;
	CColorStatic m_ctrlCHIIExist;

	CColorStatic m_ctrlChannelOvldTxt;
	CColorStatic m_ctrlCHIOvld;
	CColorStatic m_ctrlCHIIOvld;
public:
	afx_msg void OnStnClickedStaticNibpPatenttype();
};
