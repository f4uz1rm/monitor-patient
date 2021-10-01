// NbpCaliDlg.cpp : ʵ���ļ�
//

#include "stdafx.h"
#include "Multi_Para Monitor.h"
#include "NbpCaliDlg.h"
#include "Multi_Para MonitorDlg.h"


// CNbpCaliDlg �Ի���

IMPLEMENT_DYNAMIC(CNbpCaliDlg, CDialog)

CNbpCaliDlg::CNbpCaliDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CNbpCaliDlg::IDD, pParent)
	, m_CaliType(0)
{

}

CNbpCaliDlg::CNbpCaliDlg(CMulti_ParaMonitorDlg *pDlg)
{
	m_pMultiDlg = pDlg;
	m_CaliType = 0;
}

CNbpCaliDlg::~CNbpCaliDlg()
{
}

void CNbpCaliDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	DDX_Radio(pDX, IDC_RADIO_MANUAL, m_CaliType);
}


BEGIN_MESSAGE_MAP(CNbpCaliDlg, CDialog)
	ON_BN_CLICKED(IDC_BUTTON_START, &CNbpCaliDlg::OnBnClickedButtonStart)
	ON_BN_CLICKED(IDC_BUTTON_STOP, &CNbpCaliDlg::OnBnClickedButtonStop)
	ON_BN_CLICKED(IDC_BUTTON_SET, &CNbpCaliDlg::OnBnClickedButtonSet)
END_MESSAGE_MAP()


// CNbpCaliDlg ��Ϣ�������

void CNbpCaliDlg::OnBnClickedButtonStart()
{
	// TODO: �ڴ���ӿؼ�֪ͨ����������
	UpdateData();
	
	if (m_CaliType == 0)
	{
		m_pMultiDlg->ZugMedSndCmdForCalibrate(0);
	}
	else
	{
		int CaliPrs = GetDlgItemInt(IDC_EDIT_CALIPRS);
		m_pMultiDlg->ZugMedSndCmdForCalibrate(CaliPrs);
	}
}


void CNbpCaliDlg::OnBnClickedButtonStop()
{
	// TODO: �ڴ���ӿؼ�֪ͨ����������
	m_pMultiDlg->OnNibpStopCmd();
}

void CNbpCaliDlg::OnBnClickedButtonSet()
{
	// TODO: �ڴ���ӿؼ�֪ͨ����������
	UpdateData();
	
	UINT CurrentCuffPrs = GetDlgItemInt(IDC_EDIT_PRS1);
	UINT ActualCuffPrs  = GetDlgItemInt(IDC_EDIT_PRS2);

	if ( (0 == CurrentCuffPrs) || (0 == ActualCuffPrs) ) 
	{
	//	AfxMessageBox(_T("Ѫѹ�ƶ�����У׼��������Ϊ0��"));
		AfxMessageBox(_T("The zero Point Is Inadequacy!"));
		return;
	}

	if ( IDOK == AfxMessageBox(_T("Are you Sure to Set the Index��"), MB_OKCANCEL) ) 
//		if ( IDOK == AfxMessageBox(_T("��ȷ����Ҫ�����µ����ѹ���������"), MB_OKCANCEL) ) 
	{
		m_pMultiDlg->ZugMedSndCmdForCuffPrsPara(CurrentCuffPrs, ActualCuffPrs);
	}
}

BOOL CNbpCaliDlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	// TODO:  �ڴ���Ӷ���ĳ�ʼ��
	SetDlgItemInt(IDC_EDIT_CALIPRS,200);
	SetDlgItemInt(IDC_EDIT_PRS1,0);
	SetDlgItemInt(IDC_EDIT_PRS2,0);
//	m_pMultiDlg = NULL;

	return TRUE;  // return TRUE unless you set the focus to a control
	// �쳣: OCX ����ҳӦ���� FALSE
}
