// StaticWave.cpp : implementation file
//

#include "stdafx.h"
#include "StaticWave.h"

// CStaticWave

IMPLEMENT_DYNAMIC(CStaticWave, CStatic)

CStaticWave::CStaticWave()
{
	for ( int i = 0; i < MAX_COUNT; i ++ ) 
		m_puiData[i] = DEFAULT_VALUE;

	m_uiCurrentPoint = 0;

	m_uiWidth = 100;
	m_uiHeight = 10;

	m_uiRefreshFreq = 0;

	m_iShowGain = 1;

	m_strTitle.Format(L"Wave");
	m_WaveStyle = WAVE_STYLE_ONE;
}

CStaticWave::~CStaticWave()
{
}


BEGIN_MESSAGE_MAP(CStaticWave, CStatic)
	ON_WM_PAINT()
END_MESSAGE_MAP()



// CStaticWave message handlers



void CStaticWave::OnPaint()
{
	CPaintDC dc(this); // device context for painting
	// TODO: Add your message handler code here
	// Do not call CStatic::OnPaint() for painting messages

	DrawWave(&dc);
	TitleShow(&dc);
	ReleaseDC(&dc);
}

void CStaticWave::RcvOneData(unsigned int uiData)
{
	m_puiData[m_uiCurrentPoint] = uiData+100;
	m_uiCurrentPoint ++;
	
	if ( m_uiCurrentPoint == m_uiWidth ) {
		m_uiCurrentPoint = m_uiCurrentPoint;
	}
	
	for ( int i = 0; i < 10; i ++ ) {
		unsigned int uiTemp = m_uiCurrentPoint + i;
		if ( uiTemp >= m_uiWidth )
			uiTemp = uiTemp - m_uiWidth;
		m_puiData[uiTemp] = INVALID_VALUE;
	}

	if ( m_uiCurrentPoint % 2 == 0 ) {
		CRect cRect(m_uiCurrentPoint - 5, 0, m_uiCurrentPoint + 4,m_uiHeight);
		InvalidateRect(cRect, TRUE);
	}

	if ( m_uiCurrentPoint >= m_uiWidth )
		m_uiCurrentPoint = 0;

}

void CStaticWave::SetRegion(unsigned int uiWidth, unsigned int uiHeight)
{
	m_uiWidth = uiWidth;
	m_uiHeight = uiHeight;
}

void CStaticWave::ResetData(void)
{
	for ( int i = 0; i < MAX_COUNT; i ++ ) 
		m_puiData[i] = DEFAULT_VALUE;

	m_uiCurrentPoint = 0;

	m_uiRefreshFreq = 0;
}

void CStaticWave::TitleShow(CPaintDC * pDC)
{
	CString str;
	CSize tSize;
	CFont tFont;
	tFont.CreateFont(
		18,			//height
		0,			//average character width
		0,			//angle of escapement
		0,			//base-line orientation angle
		FW_LIGHT,	//font weight
		0,			//italic attribute option
		0,			//underline attribute option
		0,			//strikeout attribute option
		DEFAULT_CHARSET,	//character set identifier
		OUT_DEFAULT_PRECIS,	//output precision
		CLIP_DEFAULT_PRECIS,//clipping precision
		DEFAULT_QUALITY,	//output quality
		DEFAULT_PITCH,		//pitch and family
		_T("Times New Roman")			//typeface name
		);
	if (m_strTitle != L"")
	{
		pDC->SelectObject(tFont);
		pDC->SetBkMode(TRANSPARENT);
		pDC->SetTextColor(RGB(255, 0, 255));
		pDC->TextOut(8,2,m_strTitle);
	}
}

void CStaticWave::DrawWave(CPaintDC * pDC)
{
	CRect tRect(0, 0, m_uiWidth, m_uiHeight);

	CBrush cNewBrush;
	cNewBrush.CreateSolidBrush(RGB(0, 0, 0));
	pDC->FillRect(&tRect, &cNewBrush);
	DeleteObject(cNewBrush);
	
/*	CPen cNewPen1(PS_SOLID, 1, RGB(255, 255, 255));
	CPen * pcOldPen1 = dc.SelectObject(&cNewPen1);

	dc.MoveTo(0, 0);
	dc.LineTo(m_uiWidth, 0);*/

	CPen cNewPen;
	cNewPen.CreatePen(PS_SOLID, 0, RGB(0, 255, 0));
	CPen * pcOldPen = pDC->SelectObject(&cNewPen);
	
	for ( unsigned int i = 0; i < m_uiWidth - 1; i ++ ) {
		if ( (INVALID_VALUE == m_puiData[i]) || (INVALID_VALUE == m_puiData[i + 1]) ) {
			continue;
		}
		int y1 = (m_uiHeight - (((m_puiData[i] - 2048) * m_iShowGain) + 2048) * m_uiHeight / 4096);
		int y2 = (m_uiHeight - (((m_puiData[i + 1] - 2048) * m_iShowGain) + 2048) * m_uiHeight / 4096);
		
		if (m_WaveStyle == WAVE_STYLE_ONE)
		{
			pDC->MoveTo(i, y1);
			pDC->LineTo(i + 1, y2);
		}
		else
		{
			pDC->MoveTo(i, m_uiHeight-8);
			pDC->LineTo(i + 1, y1);

			pDC->MoveTo(i+ 1, m_uiHeight-8);
			pDC->LineTo(i + 1, y2);
		}
	}

	pDC->SelectObject(pcOldPen);
	DeleteObject(cNewPen);
}

void CStaticWave::SetScanSpeed(SCAN_SPEED_MODE tScanSpeed)
{
	m_tScanSpeed = tScanSpeed;
}

void CStaticWave::SetShowGain(int iShowGain)
{
	m_iShowGain = iShowGain;
}

void CStaticWave::SetData(unsigned int uiLength, unsigned int * puiData)
{
	for ( int i = 0; i < uiLength; i ++ ) {
		m_puiData[i] = puiData[i];
	}

	Invalidate();
}

void CStaticWave::SetTitle(CString str)
{
	m_strTitle = str;
	Invalidate();
}

void CStaticWave::SetWaveStyle(WAVE_STYLE style)
{
	m_WaveStyle = style;
	Invalidate();
}
