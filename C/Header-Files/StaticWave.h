#pragma once


// CStaticWave
#include "enumerate.h"

#define MAX_COUNT	1200
#define DEFAULT_VALUE	100
#define INVALID_VALUE	10000

typedef enum _WAVE_STYLE_
{
	WAVE_STYLE_ONE,
	WAVE_STYLE_TWO,
	WAVE_STYLE_MAX
}WAVE_STYLE;
class CStaticWave : public CStatic
{
	DECLARE_DYNAMIC(CStaticWave)

public:
	CStaticWave();
	virtual ~CStaticWave();

protected:
	DECLARE_MESSAGE_MAP()
public:
	afx_msg void OnPaint();
protected:
	unsigned int m_puiData[MAX_COUNT];
	unsigned int m_uiCurrentPoint;
	unsigned int m_uiWidth;
	unsigned int m_uiHeight;
	unsigned int m_uiRefreshFreq;
	CString m_strTitle;
	
protected:
	SCAN_SPEED_MODE m_tScanSpeed;
	int m_iShowGain;
	int m_WaveStyle;
public:
	void RcvOneData(unsigned int uiData);
	void SetRegion(unsigned int uiWidth, unsigned int uiHeight);
	void ResetData(void);
	void DrawWave(CPaintDC * pDC);
	void TitleShow(CPaintDC * pDC);
	void SetScanSpeed(SCAN_SPEED_MODE tScanSpeed);
	void SetShowGain(int iShowGain);
	void SetData(unsigned int uiLength, unsigned int * puiData);
	void SetTitle(CString str);
	void SetWaveStyle(WAVE_STYLE style);
};


