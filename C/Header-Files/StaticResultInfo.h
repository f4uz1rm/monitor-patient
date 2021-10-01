#pragma once


// CStaticResultInfo

class CStaticResultInfo : public CStatic
{
	DECLARE_DYNAMIC(CStaticResultInfo)

public:
	CStaticResultInfo();
	virtual ~CStaticResultInfo();

protected:
	DECLARE_MESSAGE_MAP()
protected:
	unsigned int m_uiWidth;
	unsigned int m_uiHeight;
	CString m_strTitle;
	CString m_strContent;
public:
	void SetRegion(unsigned int uiWidth, unsigned int uiHeight);
	void SetTitle(CString strTitle);
	void SetContent(CString strContent);
	afx_msg void OnPaint();
	void ShowTitle(CPaintDC * pDC);
	void ShowContent(CPaintDC * pDC);
};


