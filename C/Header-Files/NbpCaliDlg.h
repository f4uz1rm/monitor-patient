#pragma once


// CNbpCaliDlg �Ի���
class CMulti_ParaMonitorDlg;

class CNbpCaliDlg : public CDialog
{
	DECLARE_DYNAMIC(CNbpCaliDlg)

public:
	CNbpCaliDlg(CWnd* pParent = NULL);   // ��׼���캯��
	CNbpCaliDlg(CMulti_ParaMonitorDlg *pDlg);
	virtual ~CNbpCaliDlg();

// �Ի�������
	enum { IDD = IDD_NBPCALI_DIALOG };

protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV ֧��

	DECLARE_MESSAGE_MAP()
public:
	int m_CaliType;
	afx_msg void OnBnClickedButtonStart();
	afx_msg void OnBnClickedButtonStop();
	afx_msg void OnBnClickedButtonSet();
	virtual BOOL OnInitDialog();
	CMulti_ParaMonitorDlg *m_pMultiDlg;

};
