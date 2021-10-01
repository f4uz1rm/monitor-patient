#pragma once

#include "enumerate.h"
// CStaticEcgInfo


class CStaticEcgInfo : public CStatic
{
	DECLARE_DYNAMIC(CStaticEcgInfo)

public:
	CStaticEcgInfo();
	virtual ~CStaticEcgInfo();

protected:
	DECLARE_MESSAGE_MAP()
public:
	afx_msg void OnPaint();
private:
	unsigned int m_uiHr;
	int m_iStValues[12];	// I II III AVR AVL AVF V1 V2 V3 V4 V5 V6
	CString m_strArrCode;
	unsigned int m_uiWidth;
	unsigned int m_uiHeight;
	ECG_LEAD_NAME m_ptLeadNameForSt[3];
	bool m_bRWaveFlag;
	bool m_bPaceFlag;
public:
	void SetRegion(unsigned int uiWidth, unsigned int uiHeight);
	void SetHr(unsigned int uiHr);
	void SetStValues(unsigned char uchGroup, int iStValue1, int iStValue2, int iStValue3);
	void SetArrCode(CString strArrCode);
	void SetLeadNameForSt(ECG_LEAD_NAME tLead1, ECG_LEAD_NAME tLead2, ECG_LEAD_NAME tLead3);
	void SetRWaveFlag(bool bFlag);
private:
	bool m_bBeatInfoFlag;
public:
	void SetBeatInfoFlag(bool bFlag);
	void SetPaceFlag(bool bFlag);
};


