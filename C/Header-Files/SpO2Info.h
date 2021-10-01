#pragma once
#include "PackID.h"

// CSpO2Info

class CSpO2Info : public CStatic
{
	DECLARE_DYNAMIC(CSpO2Info)

public:
	CSpO2Info();
	virtual ~CSpO2Info();

protected:
	DECLARE_MESSAGE_MAP()
public:
	afx_msg void OnPaint();
	
private:
	unsigned int m_uiWidth;
	unsigned int m_uiHeight;
public:
	UINT m_uiSpO2;
	UINT m_uiPulseRate;
	UINT m_uiPi;

public:
	void SetRegion(unsigned int uiWidth, unsigned int uiHeight);
	void SetSpO2Info(UINT tSpo2,UINT tPr,UINT tpi,UCHAR tstatus1,UCHAR tstatus2);	
	void ShowSpO2Info(CPaintDC* pdc);
	void InitBK(CPaintDC* pdc);
};


