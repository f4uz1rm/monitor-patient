#pragma once


// CStaticRespWave
#include "StaticWave.h"

class CStaticRespWave : public CStaticWave
{
	DECLARE_DYNAMIC(CStaticRespWave)

public:
	CStaticRespWave();
	virtual ~CStaticRespWave();

protected:
	DECLARE_MESSAGE_MAP()
public:
	afx_msg void OnPaint();
	void ShowInfo(CPaintDC * pDC);
};


