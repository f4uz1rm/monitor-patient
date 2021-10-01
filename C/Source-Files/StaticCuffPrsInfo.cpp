// StaticCuffPrsInfo.cpp : implementation file
//

#include "stdafx.h"
#include "StaticCuffPrsInfo.h"


// CStaticCuffPrsInfo

IMPLEMENT_DYNAMIC(CStaticCuffPrsInfo, CStaticResultInfo)

CStaticCuffPrsInfo::CStaticCuffPrsInfo()
{
	m_bCuffErrorFlag = false;
	m_tSystemStatus = SYSTEM_STATUS_MAX;
	m_tNotifyStatus = ZUGMED_NOTIFY_MODE_MAX;
}

CStaticCuffPrsInfo::~CStaticCuffPrsInfo()
{
}


BEGIN_MESSAGE_MAP(CStaticCuffPrsInfo, CStaticResultInfo)
	ON_WM_PAINT()
END_MESSAGE_MAP()



// CStaticCuffPrsInfo message handlers

void CStaticCuffPrsInfo::OnPaint()
{
	CPaintDC dc(this); // device context for painting
	// TODO: Add your message handler code here
	// Do not call CStaticResultInfo::OnPaint() for painting messages

	ShowTitle(&dc);
	ShowContent(&dc);
	if ( m_bCuffErrorFlag ) {
		ShowCuffErrorFlag(&dc);
	}
	if ( SYSTEM_STATUS_MAX != m_tSystemStatus ) {
		ShowSystemStatus(&dc);
	}else if(ZUGMED_NOTIFY_MODE_MAX != m_tNotifyStatus){
		ShowSystemStatus(&dc);
	}

	ReleaseDC(&dc);
}

void CStaticCuffPrsInfo::ShowCuffErrorFlag(CPaintDC * pDC)
{
	CRect tRect;
	GetClientRect(&tRect);

	CFont tFontContent;
	tFontContent.CreateFont(
		m_uiHeight / 8,			//height
		0,			//average character width
		0,			//angle of escapement
		0,			//base-line orientation angle
		FW_NORMAL,	//font weight
		0,			//italic attribute option
		0,			//underline attribute option
		0,			//strikeout attribute option
		DEFAULT_CHARSET,	//character set identifier
		OUT_DEFAULT_PRECIS,	//output precision
		CLIP_DEFAULT_PRECIS,//clipping precision
		DEFAULT_QUALITY,	//output quality
		DEFAULT_PITCH,		//pitch and family
		_T("Waukegan LDO")
		//_T("Times New Roman")			//typeface name
		);

	CFont * pcOldFont = pDC->SelectObject(&tFontContent);

//	CString strCuffError = _T("Ðä´øÀàÐÍ´íÎó");
	CString strCuffError = _T("Cuff Type Err");
	pDC->SetTextColor(RGB(255, 0, 0));
	
	CSize tSize = pDC->GetTextExtent(strCuffError);

	int iLeft = (m_uiWidth - tSize.cx - 10);
	int iTop = (m_uiHeight - tSize.cy - 10);
	pDC->SetBkMode(TRANSPARENT);
	pDC->TextOutW(iLeft, iTop, strCuffError);

	pDC->SelectObject(pcOldFont);
	
}

void CStaticCuffPrsInfo::SetCuffErrorFlag(bool bCuffErrorFlag)
{
	m_bCuffErrorFlag = bCuffErrorFlag;

	Invalidate();
}

void CStaticCuffPrsInfo::ShowSystemStatus(CPaintDC * pDC)
{
	CRect tRect;
	GetClientRect(&tRect);

	CFont tFontContent;
	tFontContent.CreateFont(
		m_uiHeight / 8,			//height
		0,			//average character width
		0,			//angle of escapement
		0,			//base-line orientation angle
		FW_NORMAL,	//font weight
		0,			//italic attribute option
		0,			//underline attribute option
		0,			//strikeout attribute option
		DEFAULT_CHARSET,	//character set identifier
		OUT_DEFAULT_PRECIS,	//output precision
		CLIP_DEFAULT_PRECIS,//clipping precision
		DEFAULT_QUALITY,	//output quality
		DEFAULT_PITCH,		//pitch and family
		_T("Waukegan LDO")
		//_T("Times New Roman")			//typeface name
		);

	CFont * pcOldFont = pDC->SelectObject(&tFontContent);

	CString strSystemStatus = _T("");
		switch(m_tNotifyStatus){
			case ZUGMED_NOTIFY_MODE_BP:
			//	strSystemStatus = _T("ÑªÑ¹²âÁ¿");
				strSystemStatus = _T("Measure");
				break;
			case ZUGMED_NOTIFY_MODE_VP:
		//		strSystemStatus = //_T("¾²Âö´©´Ì");
				strSystemStatus = _T("Venipuncture");
				break;
			case ZUGMED_NOTIFY_MODE_CHECK_LEAK:
	//			strSystemStatus = _T("Â©Æø¼ì²â");
				strSystemStatus = _T("Leak Check");
				break;
			case ZUGMED_NOTIFY_MODE_CALIBRATE_PRS:
	//			strSystemStatus = _T("Ð£×¼Ä£Ê½");
				strSystemStatus = _T("Calibration Mode");
				break;
			default:
		//		strSystemStatus = _T("Î´Öª×´Ì¬");
				strSystemStatus = _T("Unknown");
				break; 
		}

	pDC->SetTextColor(RGB(0, 255, 255));
	
	CSize tSize = pDC->GetTextExtent(strSystemStatus);

	int iLeft = 10;
	int iTop = (m_uiHeight - tSize.cy - 10);
	pDC->SetBkMode(TRANSPARENT);
	pDC->TextOutW(iLeft, iTop, strSystemStatus);

	pDC->SelectObject(pcOldFont);
	
}

void CStaticCuffPrsInfo::SetCuffInfo(int iCuffPrs, bool bCuffErrorFlag, SYSTEM_STATUS_LIST tSystemStatus)
{
	CString tTemp;
	tTemp.Format(_T("%d"), iCuffPrs);
	SetContent(tTemp);

	m_bCuffErrorFlag = bCuffErrorFlag;

	m_tSystemStatus = tSystemStatus;

	Invalidate();
}
void CStaticCuffPrsInfo::ZugMedSetCuffInfo(int iCuffPrs, bool bCuffErrorFlag, ZUGMED_NOTIFY_LIST tNotifyStatus)
{
	CString tTemp;
	tTemp.Format(_T("%d"), iCuffPrs);
	SetContent(tTemp);

	m_bCuffErrorFlag = bCuffErrorFlag;

	m_tNotifyStatus = tNotifyStatus;

	Invalidate();
}