// NibpInfo.cpp : 实现文件
//

#include "stdafx.h"
#include "Multi_Para Monitor.h"
#include "NibpInfo.h"

#define  NBP_INVALID_VALUE 65203


// CNibpInfo

IMPLEMENT_DYNAMIC(CNibpInfo, CStatic)

CNibpInfo::CNibpInfo()
{
	m_uiHeight = 1;
	m_uiWidth = 1;

	m_uiSp = NBP_INVALID_VALUE;
	m_uiDp = NBP_INVALID_VALUE;
	m_uiMp = NBP_INVALID_VALUE;
	m_uiPulseRate = NBP_INVALID_VALUE;
}

CNibpInfo::~CNibpInfo()
{
}


BEGIN_MESSAGE_MAP(CNibpInfo, CStatic)
	ON_WM_PAINT()
END_MESSAGE_MAP()



// CNibpInfo 消息处理程序
void CNibpInfo::SetRegion(unsigned int uiWidth, unsigned int uiHeight)
{
	m_uiHeight = uiHeight;
	m_uiWidth = uiWidth;
}

void CNibpInfo::SetNibpInfo(UINT tSp,UINT tMp,UINT tDp,UINT tPr)
{
	m_uiSp = tSp;
	m_uiDp = tDp;
	m_uiMp = tMp;
	m_uiPulseRate = tPr;
	Invalidate();
}

void CNibpInfo::ShowNibpInfo(CPaintDC* pdc)
{
	CString strSp,strPr,strDp,strMp;
	if(m_uiSp == NBP_INVALID_VALUE)
	{
		strSp.Format(_T("---"));
	}else strSp.Format(_T("%d"), m_uiSp);

	if(m_uiPulseRate == NBP_INVALID_VALUE)
	{
		strPr.Format(_T("(---)"));
	}else strPr.Format(_T("(%d)"), m_uiPulseRate);

	if(m_uiDp == NBP_INVALID_VALUE)
	{
		strDp.Format(_T("---"));
	}else strDp.Format(_T("%d"), m_uiDp);

	if(m_uiMp == NBP_INVALID_VALUE)
	{
		strMp.Format(_T("---"));
	}else strMp.Format(_T("%d"), m_uiMp);

	CFont tFont;
	tFont.CreateFont(
		55,			//height
		0,			//average character width
		0,			//angle of escapement
		0,			//base-line orientation angle
		FW_BOLD,	//font weight
		1,			//italic attribute option
		0,			//underline attribute option
		0,			//strikeout attribute option
		DEFAULT_CHARSET,	//character set identifier
		OUT_DEFAULT_PRECIS,	//output precision
		CLIP_DEFAULT_PRECIS,//clipping precision
		DEFAULT_QUALITY,	//output quality
		DEFAULT_PITCH,		//pitch and family
//		_T("Times New Roman")			//typeface name
		_T("Waukegan LDO")
	);

	pdc->SelectObject(&tFont);
	pdc->SetTextColor(INFO_FONTCOLOR);
	pdc->SetBkMode(TRANSPARENT);
	
	CString str;
	str = strSp + _T(" / ")+ strDp;

	CSize tSize = pdc->GetTextExtent(str);
	int iLeft = (m_uiWidth - tSize.cx)/2 +10;
	int iTop = (m_uiHeight/2  - tSize.cy) / 2;
	pdc->TextOutW(iLeft, iTop, str);

	str = strMp + _T(" ")+ strPr;
	tSize = pdc->GetTextExtent(str);
	iLeft = (m_uiWidth - tSize.cx) / 2+10;
	iTop = m_uiHeight/2+(m_uiHeight/2 - tSize.cy)/2;
	pdc->TextOutW(iLeft, iTop, str);
}

void CNibpInfo::InitBK(CPaintDC* pdc)
{
	CRect tRect(0,0,m_uiWidth, m_uiHeight);
	//	GetClientRect(&tRect);

	CBrush cNewBrush;
	cNewBrush.CreateSolidBrush(RGB(0, 0, 0));
	pdc->FillRect(&tRect, &cNewBrush);
	DeleteObject(cNewBrush);
	//////////////////////////////////////////////////////////////////////////
	CPen NewPen(PS_SOLID, 1, RGB(255,255, 255));
	CPen * pcOldPen = pdc->SelectObject(&NewPen);
	pdc->MoveTo(0, 0);
	pdc->LineTo(0, m_uiHeight);
	pdc->LineTo(m_uiWidth, m_uiHeight);
	pdc->LineTo(m_uiWidth, 0);
	pdc->LineTo(0, 0);

	pdc->SelectObject(&pcOldPen);
	DeleteObject(pcOldPen);

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

	CFont * pcOldFont = pdc->SelectObject(&tFont2);
	pdc->SetTextColor(INFO_FONTCOLOR);

	pdc->SetBkMode(TRANSPARENT);
	pdc->TextOutW(5, 5, _T("NBP"));

}


void CNibpInfo::OnPaint()
{
	CPaintDC dc(this); // device context for painting
	// TODO: 在此处添加消息处理程序代码
	// 不为绘图消息调用 CStatic::OnPaint()
	InitBK(&dc);
	ShowNibpInfo(&dc);
	ReleaseDC(&dc);
	
}

