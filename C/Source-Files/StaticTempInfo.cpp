// StaticTempInfo.cpp : implementation file
//

#include "stdafx.h"
#include "Multi_Para Monitor.h"
#include "StaticTempInfo.h"
#include "PackID.h"

// CStaticTempInfo

IMPLEMENT_DYNAMIC(CStaticTempInfo, CStatic)

CStaticTempInfo::CStaticTempInfo()
{
	m_uiWidth = 0;
	m_uiHeight = 0;

	m_uiTemp1 = 550;
	m_uiTemp2 = 550;
}

CStaticTempInfo::~CStaticTempInfo()
{
}


BEGIN_MESSAGE_MAP(CStaticTempInfo, CStatic)
	ON_WM_PAINT()
END_MESSAGE_MAP()



// CStaticTempInfo message handlers



void CStaticTempInfo::SetRegion(unsigned int uiWidth, unsigned int uiHeight)
{
	m_uiWidth = uiWidth;
	m_uiHeight = uiHeight;
}

void CStaticTempInfo::SetTemp(unsigned int uiTemp1 , unsigned int uiTemp2)
{
	m_uiTemp1 = uiTemp1;
	m_uiTemp2 = uiTemp2;

	Invalidate();
}

void CStaticTempInfo::OnPaint()
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
	dc.TextOutW(5, 5, _T("TEMP"));

	CString strTemp1;
	CString strTemp2;
	if ( m_uiTemp1 == 550 ) {
		strTemp1.Format(_T("--.-"));
	}
	else {
		strTemp1.Format(_T("%.1f"), (float)m_uiTemp1 / 10);
	}

	if ( m_uiTemp2 == 550 ) {
		strTemp2.Format(_T("--.-"));
	}
	else {
		strTemp2.Format(_T("%.1f"), (float)m_uiTemp2 / 10);
	}

	CFont tFont;
	tFont.CreateFont(
		50,			//height
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
	
	CString strTemp;
	strTemp.Format(_T("99.99"));
	CSize tSize = dc.GetTextExtent(strTemp);

	CSize tSize1 = dc.GetTextExtent(strTemp1);
	int iLeft = m_uiWidth - (m_uiWidth - tSize.cx) / 2 - tSize1.cx;
	int iTop = (m_uiHeight / 2 - tSize.cy) / 2;
	dc.SetBkMode(TRANSPARENT);
	dc.TextOutW(iLeft, iTop, strTemp1);

	tSize1 = dc.GetTextExtent(strTemp2);
	iLeft = m_uiWidth - (m_uiWidth - tSize.cx) / 2 - tSize1.cx;
	iTop = m_uiHeight / 2 + (m_uiHeight / 2 - tSize.cy) / 2;
	dc.SetBkMode(TRANSPARENT);
	dc.TextOutW(iLeft, iTop, strTemp2);

	dc.SelectObject(pcOldFont);
	ReleaseDC(&dc);
}
