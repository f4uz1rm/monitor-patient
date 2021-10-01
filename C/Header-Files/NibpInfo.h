#pragma once
#include "PackID.h"

// CNibpInfo

class CNibpInfo : public CStatic
{
	DECLARE_DYNAMIC(CNibpInfo)

public:
	CNibpInfo();
	virtual ~CNibpInfo();
	afx_msg void OnPaint();

protected:
	DECLARE_MESSAGE_MAP()

private:
	unsigned int m_uiWidth;
	unsigned int m_uiHeight;
public:
	UINT m_uiSp;
	UINT m_uiDp;
	UINT m_uiMp;
	UINT m_uiPulseRate;

public:
	void SetRegion(unsigned int uiWidth, unsigned int uiHeight);
	void SetNibpInfo(UINT tSp,UINT tMp,UINT tDp,UINT tPr);
	void ShowNibpInfo(CPaintDC* pdc);
	void InitBK(CPaintDC* pdc);
};


