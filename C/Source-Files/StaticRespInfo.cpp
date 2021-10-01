// StaticRespInfo.cpp : implementation file
//

#include "stdafx.h"
#include "Multi_Para Monitor.h"
#include "StaticRespInfo.h"
#include "PackID.h"

// CStaticRespInfo

IMPLEMENT_DYNAMIC(CStaticRespInfo, CStatic)

CStaticRespInfo::CStaticRespInfo()
{
	m_uiWidth = 0;
	m_uiHeight = 0;

	m_uiRr = 65436;
	
	m_bApneaFlag= false;
	m_bCvaFlag = false;
}

CStaticRespInfo::~CStaticRespInfo()
{
}


BEGIN_MESSAGE_MAP(CStaticRespInfo, CStatic)
	ON_WM_PAINT()
END_MESSAGE_MAP()



// CStaticRespInfo message handlers



void CStaticRespInfo::SetRegion(unsigned int uiWidth, unsigned int uiHeight)
{
	m_uiWidth = uiWidth;
	m_uiHeight = uiHeight;
}

void CStaticRespInfo::SetRr(unsigned int uiRr)
{
	m_uiRr = uiRr;

	Invalidate();
}

void CStaticRespInfo::OnPaint()
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
	dc.TextOutW(5, 5, _T("RESP"));

	CString strRr;
	if ( m_uiRr == 65436 ) {
		strRr.Format(_T("--"));
	}
	else {
		strRr.Format(_T("%d"), m_uiRr);
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
	
	CSize tSize = dc.GetTextExtent(strRr);
	int iLeft = (m_uiWidth - tSize.cx) / 2;
	int iTop = (m_uiHeight - tSize.cy) / 2;
	dc.SetBkMode(TRANSPARENT);
	dc.TextOutW(iLeft, iTop, strRr);

	if ( m_bApneaFlag )
	{
		CFont tFont3;
		tFont3.CreateFont(
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

		dc.SelectObject(&tFont3);
		dc.SetTextColor(RGB(0,255, 255));

		dc.SetBkMode(TRANSPARENT);
		dc.TextOutW(m_uiWidth - 45, m_uiHeight - 45, _T("Asphyxia"));
	}

	if ( m_bCvaFlag )
	{
		CFont tFont4;
		tFont4.CreateFont(
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

		dc.SelectObject(&tFont4);
		dc.SetTextColor(RGB(255, 0, 0));

		dc.SetBkMode(TRANSPARENT);
		dc.TextOutW(m_uiWidth - 45, m_uiHeight - 25, _T("CVA"));
	}

	dc.SelectObject(pcOldFont);
	ReleaseDC(&dc);

}

void CStaticRespInfo::SetApneaFlag(bool bApneaFlag)
{
	if ( m_bApneaFlag != bApneaFlag )
	{
		m_bApneaFlag = bApneaFlag;
		Invalidate();
	}
}

void CStaticRespInfo::SetCvaFlag(bool bCvaFlag)
{
	if ( m_bCvaFlag != bCvaFlag )
	{
		m_bCvaFlag = bCvaFlag;
		Invalidate();
	}
}
