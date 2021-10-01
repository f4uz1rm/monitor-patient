#pragma once


// CStaticEcgWave
#include "StaticWave.h"
#include "enumerate.h"

class CStaticEcgWave : public CStaticWave
{
	DECLARE_DYNAMIC(CStaticEcgWave)

public:
	CStaticEcgWave();
	virtual ~CStaticEcgWave();

protected:
	DECLARE_MESSAGE_MAP()

protected:
	ECG_CHANNEL m_tChannel;
	ECG_LEAD_NAME m_tLead;
	ECG_GAIN_MODE m_tGain;
	ECG_FILTER_MODE m_tFilter;

public:
	void SetChannel(ECG_CHANNEL tChannel);
	void SetLead(ECG_LEAD_NAME tLead);
	void SetGain(ECG_GAIN_MODE tGain);
	afx_msg void OnPaint();
	void ShowInfo(CPaintDC * pDC);
	void SetFilter(ECG_FILTER_MODE tEcgFilter);
};


