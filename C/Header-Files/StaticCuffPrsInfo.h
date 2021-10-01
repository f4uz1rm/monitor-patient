#pragma once

#include "StaticResultInfo.h"
#include "DataStructure.h"

// CStatisCuffPrsInfo

class CStaticCuffPrsInfo : public CStaticResultInfo
{
	DECLARE_DYNAMIC(CStaticCuffPrsInfo)

public:
	CStaticCuffPrsInfo();
	virtual ~CStaticCuffPrsInfo();

protected:
	DECLARE_MESSAGE_MAP()
public:
	afx_msg void OnPaint();
	void ShowCuffErrorFlag(CPaintDC * pDC);
	void ShowSystemStatus(CPaintDC * pDC);
protected:
	bool m_bCuffErrorFlag;
	ZUGMED_NOTIFY_LIST m_tNotifyStatus;
	SYSTEM_STATUS_LIST  m_tSystemStatus;
public:
	void SetCuffErrorFlag(bool bCuffErrorFlag);	
	void SetCuffInfo(int iCuffPrs, bool bCuffErrorFlag, SYSTEM_STATUS_LIST tSystemStatus);
	void ZugMedSetCuffInfo(int iCuffPrs, bool bCuffErrorFlag, ZUGMED_NOTIFY_LIST tNotifyStatus);
};


