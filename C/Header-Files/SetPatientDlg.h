#pragma once
#include "enumerate.h"
// CSetPatientDlg �Ի���

class CMulti_ParaMonitorDlg;

typedef struct _PATIENT_TYPE_INFO_
{
	int m_Num;
	int m_stateEcg;
	int m_stateNibp;
	int m_stateSpO2;
	
	_PATIENT_TYPE_INFO_()
	{
		m_Num = 0;
		m_stateEcg = 1;
		m_stateNibp = 1;
		m_stateSpO2 = 1;
	}

}PATIENT_TYPE_INFO;

class CSetPatientDlg : public CDialog
{
	DECLARE_DYNAMIC(CSetPatientDlg)

public:
	CSetPatientDlg(CWnd* pParent = NULL);   // ��׼���캯��
	CSetPatientDlg(CMulti_ParaMonitorDlg *pDlg);
	virtual ~CSetPatientDlg();

// �Ի�������
	enum { IDD = IDD_SETPATIENT_DIALOG };

protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV ֧��

	DECLARE_MESSAGE_MAP()

public:
	PATIENT_TYPE_INFO m_PatientTypeInfo;

	afx_msg void OnBnClickedOk();
	CMulti_ParaMonitorDlg *m_pDlg;
	virtual BOOL OnInitDialog();
};
