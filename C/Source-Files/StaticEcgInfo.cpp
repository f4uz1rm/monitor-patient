// StaticEcgInfo.cpp : implementation file
//

#include "stdafx.h"
#include "Multi_Para Monitor.h"
#include "StaticEcgInfo.h"
#include "PackID.h"

// CStaticEcgInfo

IMPLEMENT_DYNAMIC(CStaticEcgInfo, CStatic)

CStaticEcgInfo::CStaticEcgInfo()
: m_bBeatInfoFlag(false)
{
	m_uiHr = 65436;
	
	m_uiWidth = 0;
	m_uiHeight = 0;

	for ( int i = 0; i < 12; i ++ ) {
		m_iStValues[i] = 65436;
	}

	for ( int i = 0; i < 12; i ++ ) {
		m_ptLeadNameForSt[i] = ECG_LEAD_MAX;
	}

//	m_strArrCode.Format(_T("22:正常窦性心律"));
	m_strArrCode.Format(_T(""));

	m_bRWaveFlag = false;
	m_bBeatInfoFlag = false;
}

CStaticEcgInfo::~CStaticEcgInfo()
{
}


BEGIN_MESSAGE_MAP(CStaticEcgInfo, CStatic)
	ON_WM_PAINT()
END_MESSAGE_MAP()



// CStaticEcgInfo message handlers



void CStaticEcgInfo::OnPaint()
{
	CPaintDC dc(this); // device context for painting
	// TODO: Add your message handler code here
	// Do not call CStatic::OnPaint() for painting messages

	CRect tRect;
	GetClientRect(&tRect);

	CBrush cNewBrush;
	cNewBrush.CreateSolidBrush(RGB(0, 0, 0));
	dc.FillRect(&tRect, &cNewBrush);
	DeleteObject(cNewBrush);

	CPen cNewPen(PS_SOLID, 1, RGB(255, 255, 255));
	CPen * pcOldPen = dc.SelectObject(&cNewPen);

	dc.MoveTo(0, 0);
	dc.LineTo(m_uiWidth, 0);
	dc.MoveTo(0, 0);
	dc.LineTo(0, m_uiHeight);
	dc.MoveTo(0, m_uiHeight);
	dc.LineTo(m_uiWidth, m_uiHeight);
	dc.MoveTo(m_uiWidth, 0);
	dc.LineTo(m_uiWidth, m_uiHeight);

	dc.SelectObject(pcOldPen);

	CFont tFont2;
	tFont2.CreateFont(
		20,			//height
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

	CFont * pcOldFont = dc.SelectObject(&tFont2);
	dc.SetTextColor(INFO_FONTCOLOR);

	dc.SetBkMode(TRANSPARENT);
	dc.TextOutW(5, 5, _T("ECG"));

	CString strHr;
	if ( m_uiHr == 65436 ) {
		strHr.Format(_T("---"));
	}
	else {
		strHr.Format(_T("%d"), m_uiHr);
	}

	CFont tFont;
	tFont.CreateFont(
		80,			//height
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

	dc.SelectObject(&tFont);
	dc.SetTextColor(INFO_FONTCOLOR);
	CSize tSize = dc.GetTextExtent(strHr);
	
	int iLeft = (m_uiWidth - tSize.cx) / 2;
	int iTop = (m_uiHeight * 2 / 3 - tSize.cy) / 2;
	dc.SetBkMode(TRANSPARENT);
	dc.TextOutW(iLeft, iTop, strHr);
	
	CFont tFont1;
	tFont1.CreateFont(
		15,			//height
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

	dc.SelectObject(&tFont1);

/*	int iStValues[3];
	iStValues[0] = m_iStValues[0];
	iStValues[1] = m_iStValues[1];
	iStValues[2] = m_iStValues[6];
*/
	CString strSt = _T("AVF:-00.00");
	CSize tSize1 = dc.GetTextExtent(strSt);

	for ( int i = 0; i < 3; i ++ ) {
		if ( ECG_LEAD_MAX == m_ptLeadNameForSt[i] ) {
			continue;
		}

		CString strSt;
		switch ( m_ptLeadNameForSt[i] ) {
			case ECG_LEAD_I:
				strSt.Format(_T("I:"));
				break;
			case ECG_LEAD_II:
				strSt.Format(_T("II:"));
				break;
			case ECG_LEAD_III:
				strSt.Format(_T("III:"));
				break;
			case ECG_LEAD_AVR:
				strSt.Format(_T("AVR:"));
				break;
			case ECG_LEAD_AVL:
				strSt.Format(_T("AVL:"));
				break;
			case ECG_LEAD_AVF:
				strSt.Format(_T("AVF:"));
				break;
			case ECG_LEAD_V1:
				strSt.Format(_T("V1:"));
				break;
		}

		int iStValue = m_iStValues[m_ptLeadNameForSt[i] - ECG_LEAD_I];

		if ( iStValue == 65436 ) {
			strSt += _T("---");
		}
		else {
			CString strTemp;
			strTemp.Format(_T("%.2f"), (float)iStValue / 100);
			strSt += strTemp;
		}

		CSize tSize = dc.GetTextExtent(strSt);
	
		int iLeft = 5 + tSize1.cx - tSize.cx;
		int iTop = m_uiHeight * 2 / 3 + (m_uiHeight / 9 - tSize.cy) / 2 + m_uiHeight * i / 9;
		dc.SetBkMode(TRANSPARENT);
		dc.TextOutW(iLeft, iTop, strSt);
	}

	tSize = dc.GetTextExtent(m_strArrCode);
	iLeft = m_uiWidth / 2;
	iTop = m_uiHeight * 2 / 3 + (m_uiHeight / 9 - tSize.cy) / 2 + m_uiHeight * 2 / 9;
	dc.SetTextColor(RGB(255, 0, 0));
	dc.SetBkMode(TRANSPARENT);
	dc.TextOutW(iLeft, iTop, m_strArrCode);

	if ( m_bRWaveFlag ) {
		CPen cNewPen1(PS_SOLID, 1, RGB(255, 0, 0));
		dc.SelectObject(&cNewPen1);
		CBrush cNewBrush1;
		cNewBrush1.CreateSolidBrush(RGB(255, 0, 0));
		dc.SelectObject(&cNewBrush1);
		dc.Ellipse(m_uiWidth - 5 - 10 - 10, 5 + 10 - 10, m_uiWidth - 5 - 10 + 10, 5 + 10 + 10);
	}

	if ( m_bBeatInfoFlag ) {
		m_bBeatInfoFlag = false;
		CPen cNewPen2(PS_SOLID, 1, RGB(0, 0, 255));
		dc.SelectObject(&cNewPen2);
		CBrush cNewBrush2;
		cNewBrush2.CreateSolidBrush(RGB(0, 0, 255));
		dc.SelectObject(&cNewBrush2);
		dc.Ellipse(m_uiWidth - 5 - 10 - 10, 35, m_uiWidth - 5 - 10 + 10, 55);
	}

	if ( m_bPaceFlag ) {
		m_bPaceFlag = false;
		CPen cNewPen3(PS_SOLID, 1, RGB(0, 255, 0));
		dc.SelectObject(&cNewPen3);
		CBrush cNewBrush3;
		cNewBrush3.CreateSolidBrush(RGB(0, 255, 0));
		dc.SelectObject(&cNewBrush3);
		dc.Ellipse(m_uiWidth - 5 - 10 - 10, 70, m_uiWidth - 5 - 10 + 10, 90);
	}

	dc.SelectObject(pcOldFont);
	ReleaseDC(&dc);

}

void CStaticEcgInfo::SetRegion(unsigned int uiWidth, unsigned int uiHeight)
{
	m_uiWidth = uiWidth;
	m_uiHeight = uiHeight;
}

void CStaticEcgInfo::SetHr(unsigned int uiHr)
{
	m_uiHr = uiHr;

	Invalidate();
}

void CStaticEcgInfo::SetStValues(unsigned char uchGroup, int iStValue1, int iStValue2, int iStValue3)
{
	m_iStValues[uchGroup * 3] = iStValue1;
	m_iStValues[uchGroup * 3 + 1] = iStValue2;
	m_iStValues[uchGroup * 3 + 2] = iStValue3;

	Invalidate();

}

void CStaticEcgInfo::SetArrCode(CString strArrCode)
{
	m_strArrCode = strArrCode;

	Invalidate();
}

void CStaticEcgInfo::SetLeadNameForSt(ECG_LEAD_NAME tLead1, ECG_LEAD_NAME tLead2, ECG_LEAD_NAME tLead3)
{
	m_ptLeadNameForSt[0] = tLead1;
	m_ptLeadNameForSt[1] = tLead2;
	m_ptLeadNameForSt[2] = tLead3;

	Invalidate();
}

void CStaticEcgInfo::SetRWaveFlag(bool bFlag)
{
	if ( m_bRWaveFlag == bFlag ) {
		return;
	}

	m_bRWaveFlag = bFlag;

	Invalidate();	
}

void CStaticEcgInfo::SetBeatInfoFlag(bool bFlag)
{
	m_bBeatInfoFlag = bFlag;

	Invalidate();
}

void CStaticEcgInfo::SetPaceFlag(bool bFlag)
{
	if ( m_bPaceFlag == bFlag ) {
		return;
	}

	m_bPaceFlag = bFlag;

	Invalidate();
}
