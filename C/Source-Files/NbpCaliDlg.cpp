// NbpCaliDlg.cpp : 实现文件
//

#include "stdafx.h"
#include "Multi_Para Monitor.h"
#include "NbpCaliDlg.h"
#include "Multi_Para MonitorDlg.h"


// CNbpCaliDlg 对话框

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


// CNbpCaliDlg 消息处理程序

void CNbpCaliDlg::OnBnClickedButtonStart()
{
	// TODO: 在此添加控件通知处理程序代码
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
	// TODO: 在此添加控件通知处理程序代码
	m_pMultiDlg->OnNibpStopCmd();
}

void CNbpCaliDlg::OnBnClickedButtonSet()
{
	// TODO: 在此添加控件通知处理程序代码
	UpdateData();
	
	UINT CurrentCuffPrs = GetDlgItemInt(IDC_EDIT_PRS1);
	UINT ActualCuffPrs  = GetDlgItemInt(IDC_EDIT_PRS2);

	if ( (0 == CurrentCuffPrs) || (0 == ActualCuffPrs) ) 
	{
	//	AfxMessageBox(_T("血压计读数和校准读数不能为0。"));
		AfxMessageBox(_T("The zero Point Is Inadequacy!"));
		return;
	}

	if ( IDOK == AfxMessageBox(_T("Are you Sure to Set the Index？"), MB_OKCANCEL) ) 
//		if ( IDOK == AfxMessageBox(_T("你确定需要设置新的袖带压计算参数吗？"), MB_OKCANCEL) ) 
	{
		m_pMultiDlg->ZugMedSndCmdForCuffPrsPara(CurrentCuffPrs, ActualCuffPrs);
	}
}

BOOL CNbpCaliDlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	// TODO:  在此添加额外的初始化
	SetDlgItemInt(IDC_EDIT_CALIPRS,200);
	SetDlgItemInt(IDC_EDIT_PRS1,0);
	SetDlgItemInt(IDC_EDIT_PRS2,0);
//	m_pMultiDlg = NULL;

	return TRUE;  // return TRUE unless you set the focus to a control
	// 异常: OCX 属性页应返回 FALSE
}
