#pragma once


// CStaticRespInfo

class CStaticRespInfo : public CStatic
{
	DECLARE_DYNAMIC(CStaticRespInfo)

public:
	CStaticRespInfo();
	virtual ~CStaticRespInfo();

protected:
	DECLARE_MESSAGE_MAP()
private:
	unsigned int m_uiWidth;
	unsigned int m_uiHeight;
	unsigned int m_uiRr;
public:
	void SetRegion(unsigned int uiWidth, unsigned int uiHeight);
	void SetRr(unsigned int uiRr);
	afx_msg void OnPaint();
	void SetApneaFlag(bool bApneaFlag);
	void SetCvaFlag(bool bCvaFlag);
private:
	bool m_bApneaFlag;
	bool m_bCvaFlag;
};


