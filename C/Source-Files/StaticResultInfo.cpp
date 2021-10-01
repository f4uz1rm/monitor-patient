// StaticResultInfo.cpp : implementation file
//

#include "stdafx.h"
#include "StaticResultInfo.h"


// CStaticResultInfo

IMPLEMENT_DYNAMIC(CStaticResultInfo, CStatic)

CStaticResultInfo::CStaticResultInfo()
: m_uiWidth(0)
, m_uiHeight(0)
, m_strTitle(_T(""))
, m_strContent(_T(""))
{

}

CStaticResultInfo::~CStaticResultInfo()
{
}


BEGIN_MESSAGE_MAP(CStaticResultInfo, CStatic)
	ON_WM_PAINT()
END_MESSAGE_MAP()



// CStaticResultInfo message handlers



void CStaticResultInfo::SetRegion(unsigned int uiWidth, unsigned int uiHeight)
{
	m_uiWidth = uiWidth;
	m_uiHeight = uiHeight;
}

void CStaticResultInfo::SetTitle(CString strTitle)
{
	m_strTitle = strTitle;

	Invalidate();
}

void CStaticResultInfo::SetContent(CString strContent)
{
	m_strContent = strContent;

	Invalidate();
}

void CStaticResultInfo::OnPaint()
{
	CPaintDC dc(this); // device context for painting
	// TODO: Add your message handler code here
	// Do not call CStatic::OnPaint() for painting messages
/*
	CRect tRect;
	GetClientRect(&tRect);

	CBrush cNewBrush;
	cNewBrush.CreateSolidBrush(RGB(0, 0, 0));
	dc.FillRect(&tRect, &cNewBrush);
	DeleteObject(cNewBrush);

	CPen cNewPen(PS_SOLID, 1, RGB(255, 255, 255));
	CPen * pcOldPen = dc.SelectObject(&cNewPen);

	dc.SelectObject(pcOldPen);

	CFont tFontTitle;
	tFontTitle.CreateFont(
		m_uiHeight / 6,			//height
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
		_T("ËÎÌו")			//typeface name
		);

	CFont * pcOldFont = dc.SelectObject(&tFontTitle);
	dc.SetTextColor(RGB(192, 192, 192));
	
	int iLeft = 5;
	int iTop = 5;
	dc.SetBkMode(TRANSPARENT);
	dc.TextOutW(iLeft, iTop, m_strTitle);

	CFont tFontContent;
	tFontContent.CreateFont(
		m_uiHeight / 3,			//height
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
		_T("ËÎÌו")			//typeface name
		);

	dc.SelectObject(&tFontContent);
	dc.SetTextColor(RGB(0, 255, 0));

	CSize tSize = dc.GetTextExtent(m_strContent);

	iLeft = (m_uiWidth - tSize.cx) / 2;
	iTop = (m_uiHeight - tSize.cy) / 2;
	dc.SetBkMode(TRANSPARENT);
	dc.TextOutW(iLeft, iTop, m_strContent);

	dc.SelectObject(pcOldFont);
*/	
	ShowTitle(&dc);
	ShowContent(&dc);

	ReleaseDC(&dc);

}

void CStaticResultInfo::ShowTitle(CPaintDC * pDC)
{
	CRect tRect;
	GetClientRect(&tRect);

	CBrush cNewBrush;
	cNewBrush.CreateSolidBrush(RGB(0, 0, 0));
	pDC->FillRect(&tRect, &cNewBrush);
	DeleteObject(cNewBrush);

/*	CPen cNewPen(PS_SOLID, 1, RGB(255, 255, 255));
	CPen * pcOldPen = pDC->SelectObject(&cNewPen);
	pDC->SelectObject(pcOldPen);
*/
	CFont tFontTitle;
	tFontTitle.CreateFont(
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

	CFont * pcOldFont = pDC->SelectObject(&tFontTitle);
	pDC->SetTextColor(RGB(192, 192, 192));
	
	int iLeft = 5;
	int iTop = 5;
	pDC->SetBkMode(TRANSPARENT);
	pDC->TextOutW(iLeft, iTop, m_strTitle);

	pDC->SelectObject(pcOldFont);

}

void CStaticResultInfo::ShowContent(CPaintDC * pDC)
{
	CRect tRect;
	GetClientRect(&tRect);

	CFont tFontContent;
	tFontContent.CreateFont(
		m_uiHeight / 4,			//height
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
	pDC->SetTextColor(RGB(0, 255, 0));

	CSize tSize = pDC->GetTextExtent(m_strContent);

	int iLeft = (m_uiWidth - tSize.cx) / 2;
	int iTop = (m_uiHeight - tSize.cy) / 2;
	pDC->SetBkMode(TRANSPARENT);
	pDC->TextOutW(iLeft, iTop, m_strContent);

	pDC->SelectObject(pcOldFont);
	
}
