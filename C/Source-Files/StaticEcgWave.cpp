// StaticEcgWave.cpp : implementation file
//

#include "stdafx.h"
#include "Multi_Para Monitor.h"
#include "StaticEcgWave.h"


// CStaticEcgWave

IMPLEMENT_DYNAMIC(CStaticEcgWave, CStatic)

CStaticEcgWave::CStaticEcgWave()
{
	CStaticWave::CStaticWave();

	m_tChannel = ECG_CHANNEL_MAX;
	m_tLead = ECG_LEAD_MAX;
	m_tGain = ECG_GAIN_MAX;

}

CStaticEcgWave::~CStaticEcgWave()
{
}


BEGIN_MESSAGE_MAP(CStaticEcgWave, CStatic)
	ON_WM_PAINT()
END_MESSAGE_MAP()



// CStaticEcgWave message handlers

void CStaticEcgWave::SetChannel(ECG_CHANNEL tChannel)
{
	m_tChannel = tChannel;
}

void CStaticEcgWave::SetLead(ECG_LEAD_NAME tLead)
{
	m_tLead = tLead;
}

void CStaticEcgWave::SetGain(ECG_GAIN_MODE tGain)
{
	m_tGain = tGain;
}

void CStaticEcgWave::OnPaint()
{
	CPaintDC dc(this); // device context for painting
	// TODO: Add your message handler code here
	// Do not call CStaticWave::OnPaint() for painting messages
	DrawWave(&dc);

	ShowInfo(&dc);

	ReleaseDC(&dc);

}

void CStaticEcgWave::ShowInfo(CPaintDC * pDC)
{
	CString strInfo;
	
	switch ( m_tChannel ) {
		case ECG_CHANNEL_I:
			strInfo = _T("Channel I, ");
			break;
		case ECG_CHANNEL_II:
			strInfo = _T("Channel II, ");
			break;
		case ECG_CHANNEL_V1:
			strInfo = _T("Channel V1, ");
			break;
		default:
			strInfo = _T("");
	}
	
	switch ( m_tLead ) {
		case ECG_LEAD_CAL:
			strInfo += _T("Calibration Mode, ");
			break;
		case ECG_LEAD_I:
			strInfo += _T("Lead I, ");
			break;
		case ECG_LEAD_II:
			strInfo += _T("Lead II, ");
			break;
		case ECG_LEAD_III:
			strInfo += _T("Lead III, ");
			break;
		case ECG_LEAD_AVR:
			strInfo += _T("Lead AVR, ");
			break;
		case ECG_LEAD_AVL:
			strInfo += _T("Lead AVL, ");
			break;
		case ECG_LEAD_AVF:
			strInfo += _T("Lead AVF, ");
			break;
		case ECG_LEAD_V1:
			strInfo += _T("Lead V1, ");
			break;
		default:
			break;
	}

	switch ( m_tGain ) {
		case ECG_GAIN_0_25:
			strInfo += _T("Gain X0.25, ");
			break;
		case ECG_GAIN_0_50:
			strInfo += _T("Gain X0.50, ");
			break;
		case ECG_GAIN_1_00:
			strInfo += _T("Gain X1.00, ");
			break;
		case ECG_GAIN_2_00:
			strInfo += _T("Gain X2.00, ");
			break;
		default:
			break;
	}
	
	switch ( m_tFilter ) {
		case FILTER_DIAG:
			strInfo += _T("Diagnosis Mode, ");
			break;
		case FILTER_MONITOR:
			strInfo += _T("Monitor MOde, ");
			break;
		case FILTER_HARDEST:
			strInfo += _T("HARDEST Mode, ");
			break;
		case FILTER_SURGERY:
			strInfo += _T("Surgery Mode, ");
			break;
		default:
			break;
	}

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

void CStaticEcgWave::SetFilter(ECG_FILTER_MODE tEcgFilter)
{
	m_tFilter = tEcgFilter;
}
