// StaticWave.cpp : implementation file
//

#include "stdafx.h"
#include "Multi_Para Monitor.h"
#include "SpO2Wave.h"

// CStaticWave

IMPLEMENT_DYNAMIC(CSpO2Wave, CStatic)

CSpO2Wave::CSpO2Wave()
{
	for ( int i = 0; i < MAX_COUNT; i ++ ) 
		m_puiData[i] = SPO2_DEFAULT_VALUE;

	m_uiCurrentPoint = 0;

	m_uiWidth = 1;
	m_uiHeight = 1;

	m_uiRefreshFreq = 0;

	m_iShowGain = 1;

	m_StrRESPStatus =_T("");
}

CSpO2Wave::~CSpO2Wave()
{
}


BEGIN_MESSAGE_MAP(CSpO2Wave, CStatic)
	ON_WM_PAINT()
END_MESSAGE_MAP()



// CStaticWave message handlers



void CSpO2Wave::OnPaint()
{
	CPaintDC dc(this); // device context for painting
	// TODO: Add your message handler code here
	// Do not call CStatic::OnPaint() for painting messages

	DrawGrid(&dc);
	DrawWave(&dc);
	ShowSpO2Status(&dc);

	ReleaseDC(&dc);
}

void CSpO2Wave::RcvOneData(unsigned int uiData)
{
	static UCHAR temp=0;

	temp++;
	if (temp>=m_uiRefreshFreq)
	{
		temp = 0;
	}
	else
		return;
	
	if (uiData == 0xFF)
	{
		m_puiData[m_uiCurrentPoint] = SPO2_DEFAULT_VALUE;
	}
	else
	m_puiData[m_uiCurrentPoint] = uiData*2+150;

	m_uiCurrentPoint ++;

	if ( m_uiCurrentPoint == m_uiWidth )
	{
		m_uiCurrentPoint = m_uiCurrentPoint;
	}
	
	for ( int i = 0; i < 10; i ++ ) 
	{
		unsigned int uiTemp = m_uiCurrentPoint + i;
		if ( uiTemp >= m_uiWidth )
			uiTemp = uiTemp - m_uiWidth;
		m_puiData[uiTemp] = INVALID_PULSE_WAVE;
	}

	CRect cRect(m_uiCurrentPoint - 2, 0, m_uiCurrentPoint + 1,m_uiHeight);
	InvalidateRect(cRect, false);

	if ( m_uiCurrentPoint >= m_uiWidth )
		m_uiCurrentPoint = 0;

}

void CSpO2Wave::SetRegion(unsigned int uiWidth, unsigned int uiHeight)
{
	m_uiWidth = uiWidth;
	m_uiHeight = uiHeight;
}

void CSpO2Wave::ResetData(void)
{
	for ( int i = 0; i < MAX_COUNT; i ++ ) 
		m_puiData[i] = SPO2_DEFAULT_VALUE;

	m_uiCurrentPoint = 0;

//	m_uiRefreshFreq = 0;
}

void CSpO2Wave::DrawWave(CPaintDC * pDC)
{
	CRect tRect(0, 0, m_uiWidth, m_uiHeight);

	CBrush cNewBrush;
	cNewBrush.CreateSolidBrush(RGB(0, 0, 0));
	pDC->FillRect(&tRect, &cNewBrush);
	DeleteObject(cNewBrush);
	CPen cNewPen,cNewPen1;
	cNewPen.CreatePen(PS_SOLID, 0, RGB(0, 255, 0));
	cNewPen1.CreatePen(PS_SOLID, 0, RGB(255, 0, 0));
	CPen * pcOldPen = pDC->SelectObject(&cNewPen);
	
	for ( unsigned int i = 0; i < m_uiWidth - 1; i ++ ) 
	{
		if ( (INVALID_PULSE_WAVE == m_puiData[i]) || (INVALID_PULSE_WAVE == m_puiData[i + 1]) ) 
		{
			continue;
		}
		int y1 = (m_uiHeight - (((m_puiData[i] - 256) * m_iShowGain) + 256) * m_uiHeight / 512);
		int y2 = (m_uiHeight - (((m_puiData[i + 1] - 256) * m_iShowGain) + 256) * m_uiHeight / 512);
				
		pDC->MoveTo(i, y1);
		pDC->LineTo(i + 1, y2);
	}

	pDC->SelectObject(pcOldPen);
	DeleteObject(cNewPen);
}

void CSpO2Wave::SetShowGain(int iShowGain)
{
	m_iShowGain = iShowGain;

}

void CSpO2Wave::SetData(unsigned int uiLength, unsigned int * puiData)
{
	for (unsigned int i = 0; i < uiLength; i ++ ) 
	{
		m_puiData[i] = puiData[i];
	}

	Invalidate();
}

void CSpO2Wave::SetSpO2Status(UCHAR ucStatu1,UCHAR ucStatu2)
{
	BOOL wrongFlag = FALSE;
	CString str = L"";

	if((ucStatu1&SYS_HYPOPERFUSION)==SYS_HYPOPERFUSION)
	{
		str ="Hypoperfusion" ;
		wrongFlag = true;
	}
	if((ucStatu1&SYS_MOVEMEMT_DISTURB)==SYS_MOVEMEMT_DISTURB)
	{
		str ="Movement disturbance" ;
		wrongFlag = true;
	}
	if((ucStatu1&SYS_HYPER_MOVEMEMT_DISTURB)==SYS_HYPER_MOVEMEMT_DISTURB)
	{
		str ="Excessive movement disturbance" ;
		wrongFlag = true;
	}
	if((ucStatu1&SYS_SEARCH_PULSE)==SYS_SEARCH_PULSE)
	{
		str ="Search for pulse wave" ;
		wrongFlag = true;
	}
	if((ucStatu1&SYS_LONGTIME_SEARCH_PULSE_NO)==SYS_LONGTIME_SEARCH_PULSE_NO)
	{
		str ="The pulse of search time is too long/no pulse wave" ;
		wrongFlag = true;
	}
	if((ucStatu1&SYS_LED_DITACHED)==SYS_LED_DITACHED)
	{
		str ="Sensor disconnected" ;
		wrongFlag = true;
	}
	if((ucStatu1&SYS_FIGURE_NOT_IN)==SYS_FIGURE_NOT_IN)
	{
		str ="Finger Off" ;
		wrongFlag = true;
	}
	if((ucStatu1&SYS_LED_ERROR)==SYS_LED_ERROR)
	{
		str ="Sensor fault" ;
		wrongFlag = true;
	}
	if((ucStatu2&SYS_HARDWARE_ERROR)==SYS_HARDWARE_ERROR)
	{
		str ="Hardware fault" ;
		wrongFlag = true;
	}
	if((ucStatu2&SYS_BACKLIGHT_TOOBRIGHT)==SYS_BACKLIGHT_TOOBRIGHT)
	{
		str ="Background light is too strong" ;
		wrongFlag = true;
	}
	if((ucStatu2&SYS_LED_UNMATCHING)==SYS_LED_UNMATCHING)
	{
		str ="Sensor does not match" ;
		wrongFlag = true;
	}
	if(!wrongFlag)
	{
		str = "Module working properly";
	}
//////////////////////////////////////////////////////////////////////////
	if (m_StrRESPStatus == str)
	{
		return;
	}
	else
	{
		m_StrRESPStatus = str;	
	/*	CRect cRect(m_uiWidth - 500, 0,m_uiWidth, 25);
		InvalidateRect(cRect, false);*/
		Invalidate();
	}
}

void CSpO2Wave::ShowSpO2Status(CPaintDC * pDC)
{
	CFont tFont;

	tFont.CreateFont(
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

	CFont * pcOldFont = pDC->SelectObject(&tFont);
	pDC->SetTextColor(INFO_FONTCOLOR);
	pDC->SetBkMode(TRANSPARENT);
	
	CSize strSize = pDC->GetTextExtent(m_StrRESPStatus);
	pDC->TextOut(m_uiWidth-strSize.cx-10,3,m_StrRESPStatus);
	pDC->SetTextColor(INFO_FONTCOLOR);
	pDC->TextOut(10,3,_T("Pulse Wave"));
	

}

void CSpO2Wave::DrawGrid(CPaintDC* pDC)
{
}
