// SetPatientDlg.cpp : ʵ���ļ�
//

#include "stdafx.h"
#include "Multi_Para Monitor.h"
#include "SetPatientDlg.h"
#include "Multi_Para MonitorDlg.h"


// CSetPatientDlg �Ի���

IMPLEMENT_DYNAMIC(CSetPatientDlg, CDialog)

CSetPatientDlg::CSetPatientDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CSetPatientDlg::IDD, pParent)
{
}

CSetPatientDlg::CSetPatientDlg(CMulti_ParaMonitorDlg *pDlg)
{
	m_pDlg = pDlg;
}

CSetPatientDlg::~CSetPatientDlg()
{
}

void CSetPatientDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	DDX_Radio(pDX, IDC_RADIO_ADULT, m_PatientTypeInfo.m_Num);

}


BEGIN_MESSAGE_MAP(CSetPatientDlg, CDialog)
	ON_BN_CLICKED(IDOK, &CSetPatientDlg::OnBnClickedOk)
END_MESSAGE_MAP()


// CSetPatientDlg ��Ϣ�������

void CSetPatientDlg::OnBnClickedOk()
{
	// TODO: �ڴ���ӿؼ�֪ͨ����������
	UpdateData(TRUE);

	CButton* pBtnEcg = (CButton*)GetDlgItem(IDC_CHECK_ECG);
	CButton* pBtnNibp = (CButton*)GetDlgItem(IDC_CHECK_NIBP);
	CButton* pBtnSpO2 = (CButton*)GetDlgItem(IDC_CHECK_SPO2);

	int num = m_PatientTypeInfo.m_Num;
	m_PatientTypeInfo.m_stateEcg = pBtnEcg->GetCheck();
	m_PatientTypeInfo.m_stateNibp = pBtnNibp->GetCheck();
	m_PatientTypeInfo.m_stateSpO2 = pBtnSpO2->GetCheck();

	if (num == 1)
	{
		m_pDlg->SetPatientType(m_PatientTypeInfo.m_stateEcg,m_PatientTypeInfo.m_stateNibp,m_PatientTypeInfo.m_stateSpO2,PATIENTTYPE_PEDIATRIC);
	}
	else if (num == 2)
	{
		m_pDlg->SetPatientType(m_PatientTypeInfo.m_stateEcg,m_PatientTypeInfo.m_stateNibp,m_PatientTypeInfo.m_stateSpO2,PATIENTTYPE_NEONATE);
	} 
	else
	{
		m_pDlg->SetPatientType(m_PatientTypeInfo.m_stateEcg,m_PatientTypeInfo.m_stateNibp,m_PatientTypeInfo.m_stateSpO2,PATIENTTYPE_ADULT);
	}

	OnOK();
}

BOOL CSetPatientDlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	// TODO:  �ڴ���Ӷ���ĳ�ʼ��
	
	CButton* pBtnEcg = (CButton*)GetDlgItem(IDC_CHECK_ECG);
	CButton* pBtnNibp = (CButton*)GetDlgItem(IDC_CHECK_NIBP);
	CButton* pBtnSpO2 = (CButton*)GetDlgItem(IDC_CHECK_SPO2);
	
	pBtnEcg->SetCheck(m_PatientTypeInfo.m_stateEcg);
	pBtnNibp->SetCheck(m_PatientTypeInfo.m_stateNibp);
	pBtnSpO2->SetCheck(m_PatientTypeInfo.m_stateSpO2);

	return TRUE;  // return TRUE unless you set the focus to a control
	// �쳣: OCX ����ҳӦ���� FALSE
}
