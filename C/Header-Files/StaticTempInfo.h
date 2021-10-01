#pragma once


// CStaticTempInfo

class CStaticTempInfo : public CStatic
{
	DECLARE_DYNAMIC(CStaticTempInfo)

public:
	CStaticTempInfo();
	virtual ~CStaticTempInfo();

protected:
	DECLARE_MESSAGE_MAP()
public:
	void SetRegion(unsigned int uiWidth, unsigned int uiHeight);
private:
	unsigned int m_uiWidth;
	unsigned int m_uiHeight;
	unsigned int m_uiTemp1;
	unsigned int m_uiTemp2;
public:
	void SetTemp(unsigned int uiTemp1 , unsigned int uiTemp2);
	afx_msg void OnPaint();
};


