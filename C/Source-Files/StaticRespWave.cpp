// StaticRespWave.cpp : implementation file
//

#include "stdafx.h"
#include "Multi_Para Monitor.h"
#include "StaticRespWave.h"


// CStaticRespWave

IMPLEMENT_DYNAMIC(CStaticRespWave, CStaticWave)

CStaticRespWave::CStaticRespWave()
{

}

CStaticRespWave::~CStaticRespWave()
{
}


BEGIN_MESSAGE_MAP(CStaticRespWave, CStaticWave)
	ON_WM_PAINT()
END_MESSAGE_MAP()



// CStaticRespWave message handlers



void CStaticRespWave::OnPaint()
{
	CPaintDC dc(this); // device context for painting
	// TODO: Add your message handler code here
	// Do not call CStaticWave::OnPaint() for painting messages
	DrawWave(&dc);

	ShowInfo(&dc);

	ReleaseDC(&dc);
}

void CStaticRespWave::ShowInfo(CPaintDC * pDC)
{
	CString strInfo;
	
	strInfo = _T("Resp, ");

	switch ( m_tScanSpeed ) {
		case SCAN_SPEED_2MS:
			strInfo += _T("500 dot/s");
			break;
		case SCAN_SPEED_4MS:
			strInfo += _T("250 dot/s");
			break;
		case SCAN_SPEED_10MS:
			strInfo += _T("100 dot/s");
			break;
		case SCAN_SPEED_20MS:
			strInfo += _T("50 dot/s");
			break;
		default:
			break;
	}

	CFont tFont;
	tFont.CreateFont(
		13,			//height
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
	pDC->TextOutW(5, 5, strInfo);

	pDC->SelectObject(pcOldFont);
	

}
