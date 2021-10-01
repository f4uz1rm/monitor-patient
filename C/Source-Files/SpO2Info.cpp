// SpO2Info.cpp : 实现文件
//

#include "stdafx.h"
#include "Multi_Para Monitor.h"
#include "SpO2Info.h"


// CSpO2Info

IMPLEMENT_DYNAMIC(CSpO2Info, CStatic)

CSpO2Info::CSpO2Info()
{
	m_uiHeight = 1;
	m_uiWidth = 1;

	m_uiSpO2 = INVALID_SPO2_VALUE;
	m_uiPulseRate = INVALID_PR_VALUE;
	m_uiPi = INVALID_PI_VALUE;

}

CSpO2Info::~CSpO2Info()
{
}


BEGIN_MESSAGE_MAP(CSpO2Info, CStatic)
	ON_WM_PAINT()
END_MESSAGE_MAP()



// CSpO2Info 消息处理程序



void CSpO2Info::OnPaint()
{
	CPaintDC dc(this); // device context for painting
	// TODO: 在此处添加消息处理程序代码
	// 不为绘图消息调用 CStatic::OnPaint()
	InitBK(&dc);
	ShowSpO2Info(&dc);
	ReleaseDC(&dc);
}

void CSpO2Info::SetRegion(unsigned int uiWidth, unsigned int uiHeight)
{
	m_uiHeight = uiHeight;
	m_uiWidth = uiWidth;
}

void CSpO2Info::SetSpO2Info(UINT tSpo2,UINT tPr,UINT tpi,UCHAR tstatus1,UCHAR tstatus2)
{
	m_uiSpO2 = tSpo2;
	m_uiPulseRate = tPr;
	m_uiPi = tpi;

	if (tpi != 0)
	{
		CRect cRect(20, 0, m_uiWidth,m_uiHeight);
		InvalidateRect(cRect, TRUE);
	}
	else
		Invalidate();
}
void CSpO2Info::InitBK(CPaintDC* pdc)
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
	pdc->MoveTo(m_uiWidth*0.6, 0);
	pdc->LineTo(m_uiWidth*0.6, m_uiHeight);
	pdc->MoveTo(m_uiWidth*0.6, m_uiHeight/2);
	pdc->LineTo(m_uiWidth, m_uiHeight/2);
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
	pdc->TextOutW(5, 5, _T("SpO2"));

}

void CSpO2Info::ShowSpO2Info(CPaintDC* pdc)
{
	CString strSpO2,strPr,strPi;

	if(m_uiSpO2 == INVALID_SPO2_VALUE)
	{
		strSpO2.Format(_T("--"));
	}else strSpO2.Format(_T("%d"), m_uiSpO2);

	if(m_uiPulseRate == INVALID_PR_VALUE)
	{
		strPr.Format(_T("--"));
	}else strPr.Format(_T("%d"), m_uiPulseRate);

	if(m_uiPi == INVALID_PI_VALUE)
	{
		strPi.Format(_T("-.--"));
	}else strPi.Format(_T("%.2f"), m_uiPi/1000.0);

	CFont tFont,tFont1,tFont2;
	tFont.CreateFont(
		70,			//height
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
		_T("Waukegan LDO")
		//_T("Times New Roman")			//typeface name
		);
	tFont1.CreateFont(
		45,			//height
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
		_T("Waukegan LDO")
		//_T("Times New Roman")			//typeface name
		);
	tFont2.CreateFont(
		30,			//height
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
		_T("Waukegan LDO")
		//_T("Times New Roman")			//typeface name
		);

	pdc->SelectObject(&tFont);
	pdc->SetTextColor(INFO_FONTCOLOR);
	pdc->SetBkMode(TRANSPARENT);

	CSize tSize = pdc->GetTextExtent(strSpO2);
	int iLeft = (m_uiWidth*3/5 - tSize.cx) / 2+10;
	int iTop = (m_uiHeight  - tSize.cy) / 2;
	pdc->TextOutW(iLeft, iTop, strSpO2);

	pdc->SelectObject(&tFont1);
	tSize = pdc->GetTextExtent(strPr);
	iLeft = m_uiWidth*3/5+(m_uiWidth*2/5 - tSize.cx) / 2;
	iTop = (m_uiHeight/2 - tSize.cy)/2;
	pdc->TextOutW(iLeft, iTop, strPr);

	pdc->SelectObject(&tFont2);
	tSize = pdc->GetTextExtent(strPi);
	iLeft = m_uiWidth*3/5+(m_uiWidth*2/5 - tSize.cx) / 2;
	iTop = m_uiHeight/2+(m_uiHeight/2 - tSize.cy) / 2;
	pdc->TextOutW(iLeft, iTop, strPi);
}
