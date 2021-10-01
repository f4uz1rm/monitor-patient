// ColorStatic.cpp : implementation file
//

#include "stdafx.h"
#include "ColorStatic.h"

// CColorStatic

IMPLEMENT_DYNAMIC(CColorStatic, CStatic)

CColorStatic::CColorStatic()
:m_mask(0)
,m_bHover(FALSE)
,m_bPressed(FALSE)
,m_bTextBkTransparent(FALSE)
,m_bBkTransparent(FALSE)
,m_hCursor(NULL)
{
	for(int i=0;i<COLOR_MAX_NUM;++i)
	{
		m_crText[i]=GetSysColor(COLOR_BTNTEXT);
		m_crTextBk[i]=GetSysColor(COLOR_BTNFACE);
		m_crBk[i]=GetSysColor(COLOR_BTNFACE);
	}
}

CColorStatic::~CColorStatic()
{
	if (m_dcBk.m_hDC && m_pbmpOldBk)
		m_dcBk.SelectObject(m_pbmpOldBk);
}

BEGIN_MESSAGE_MAP(CColorStatic, CStatic)
	ON_CONTROL_REFLECT_EX(STN_CLICKED,OnStnClicked)
	ON_WM_MOUSEMOVE()
	ON_WM_PAINT()
	ON_WM_SETCURSOR()
END_MESSAGE_MAP()

void CColorStatic::SetTextColor(COLORREF color,UINT uStatusFlag)
{
	if (uStatusFlag&stateNormal)
		m_crText[COLOR_NORMAL] = color;
	if (uStatusFlag&stateHover)
		m_crText[COLOR_HOVER] = color;
	if (uStatusFlag&statePressed)
		m_crText[COLOR_PRESSED] = color;
}

void CColorStatic::SetTextBkColor(COLORREF color,UINT uStatusFlag)
{
	if (uStatusFlag&stateNormal)
		m_crTextBk[COLOR_NORMAL] = color;
	if (uStatusFlag&stateHover)
		m_crTextBk[COLOR_HOVER] = color;
	if (uStatusFlag&statePressed)
		m_crTextBk[COLOR_PRESSED] = color;
}

void CColorStatic::SetBkColor(COLORREF color,UINT uStatusFlag)
{
	if (uStatusFlag&stateNormal)
		m_crBk[COLOR_NORMAL] = color;
	if (uStatusFlag&stateHover)
		m_crBk[COLOR_HOVER] = color;
	if (uStatusFlag&statePressed)
		m_crBk[COLOR_PRESSED] = color;
}

void CColorStatic::GetTextColor(COLORREF* color,UINT uStateFlag)
{
	if (uStateFlag&stateNormal)
		*color++ = m_crText[COLOR_NORMAL];
	if (uStateFlag&stateHover)
		*color++ = m_crText[COLOR_HOVER];
	if (uStateFlag&statePressed)
		*color = m_crText[COLOR_PRESSED];
}

void CColorStatic::GetTextBkColor(COLORREF* color,UINT uStateFlag)
{
	if (uStateFlag&stateNormal)
		*color++ = m_crTextBk[COLOR_NORMAL];
	if (uStateFlag&stateHover)
		*color++ = m_crTextBk[COLOR_HOVER];
	if (uStateFlag&statePressed)
		*color = m_crTextBk[COLOR_PRESSED];
}

void CColorStatic::GetBkColor(COLORREF* color,UINT uStateFlag)
{
	if (uStateFlag&stateNormal)
		*color++ = m_crBk[COLOR_NORMAL];
	if (uStateFlag&stateHover)
		*color++ = m_crBk[COLOR_HOVER];
	if (uStateFlag&statePressed)
		*color = m_crBk[COLOR_PRESSED];
}

BOOL CColorStatic::SetBold(BOOL bBold,BOOL bRedraw)
{
	ASSERT((HFONT)m_font);
	bBold ? (m_mask|=BOLD_MASK):(m_mask&=~BOLD_MASK);
	LOGFONT lf;
	m_font.GetLogFont(&lf);
	lf.lfWeight = (m_mask&BOLD_MASK)?FW_BOLD:FW_NORMAL;
	return SetFont(lf,bRedraw);
}

BOOL CColorStatic::SetItalic(BOOL bItalic,BOOL bRedraw)
{
	ASSERT((HFONT)m_font);
	bItalic ? (m_mask|=ITALIC_MASK):(m_mask&=~ITALIC_MASK);
	LOGFONT lf;
	m_font.GetLogFont(&lf);
	lf.lfItalic = (m_mask&ITALIC_MASK)?TRUE:FALSE;
	return SetFont(lf,bRedraw);
}

BOOL CColorStatic::SetUnderline(BOOL bUnderline,BOOL bRedraw)
{
	ASSERT((HFONT)m_font);
	bUnderline ? (m_mask|=UNDERLINE_MASK):(m_mask&=~UNDERLINE_MASK);
	LOGFONT lf;
	m_font.GetLogFont(&lf);
	lf.lfUnderline = (m_mask&UNDERLINE_MASK)?TRUE:FALSE;
	return SetFont(lf,bRedraw);
}

BOOL CColorStatic::SetFont(CFont& font,BOOL bRedraw)
{
	ASSERT((HFONT)font);
	LOGFONT lf;
	font.GetLogFont(&lf);
	return SetFont(lf,bRedraw);
}

BOOL CColorStatic::SetFont(LOGFONT& logFont,BOOL bRedraw)
{
	m_font.DeleteObject();
	if (!m_font.CreateFontIndirect(&logFont))
		return FALSE;
	if (bRedraw) RedrawWindow();
	return TRUE;
}


BOOL CColorStatic::SetFont(LPCTSTR lpFaceName,int nPointSize,BOOL bRedraw)
{
	ASSERT((HFONT)m_font);
	LOGFONT lf;
	m_font.GetLogFont(&lf);
	if (lpFaceName)
	{
		_tcsncpy(lf.lfFaceName, lpFaceName, sizeof(lf.lfFaceName)/sizeof(TCHAR)-1);
	}
	lf.lfHeight = nPointSize;//GetFontHeight(nPointSize);
	return SetFont(lf, bRedraw);
}

void CColorStatic::SetTextBkTransparent(BOOL bTransparent)
{
	m_bTextBkTransparent = bTransparent;
	RedrawWindow();
}

void CColorStatic::SetBkTransparent(BOOL bTransparent)
{
	m_bBkTransparent = bTransparent;
	RedrawWindow();
}

BOOL CColorStatic::SetCursor(UINT uID)
{
	return SetCursor(MAKEINTRESOURCE(uID));
}

BOOL CColorStatic::SetCursor(LPCTSTR lpName)
{
	m_hCursor = (HCURSOR)::LoadImage(AfxFindResourceHandle(lpName, RT_GROUP_CURSOR),
		lpName,IMAGE_CURSOR,0,0,LR_SHARED);
	return NULL!=m_hCursor;
}

//////////////////////////////////////////////////////////////////////////
void CColorStatic::PreSubclassWindow()
{
	CFont* pFont = GetFont();
	if (NULL==pFont||NULL==pFont->GetSafeHandle())
	{
		HFONT hFont = (HFONT)GetStockObject(DEFAULT_GUI_FONT);
		if (NULL==hFont)
			hFont = (HFONT) GetStockObject(ANSI_VAR_FONT);
		if (hFont)
			pFont = CFont::FromHandle(hFont);
	}
	ASSERT(pFont->GetSafeHandle());

	LOGFONT lf;
	pFont->GetLogFont(&lf);
	m_font.CreateFontIndirect(&lf);
	ModifyStyle(0,SS_NOTIFY);

	CStatic::PreSubclassWindow();
}

//////////////////////////////////////////////////////////////////////////
BOOL CColorStatic::OnStnClicked()
{
	m_bPressed = TRUE;
	RedrawWindow();
	return FALSE;
}

void CColorStatic::OnMouseMove(UINT nFlags, CPoint point)
{
	CStatic::OnMouseMove(nFlags, point);

	if (m_bHover) 
	{
		CRect rect;
		GetClientRect(rect);
		if (!rect.PtInRect(point))
		{
			m_bPressed = m_bHover = FALSE;
			ReleaseCapture();
			RedrawWindow();
		}
	}
	else                      
	{
		m_bHover = TRUE;
		RedrawWindow();
		SetCapture();
	}
}

BOOL CColorStatic::OnSetCursor(CWnd* pWnd, UINT nHitTest, UINT message)
{
	if (NULL!=m_hCursor)
	{
		::SetCursor(m_hCursor);
		return TRUE;
	} 
	return CStatic::OnSetCursor(pWnd, nHitTest, message);
}

void CColorStatic::PaintBk(CDC* pDC)
{
	CClientDC clDC(GetParent());
	CRect rect;

	GetClientRect(rect);
	ClientToScreen(&rect);
	GetParent()->ScreenToClient(&rect);

	if (m_dcBk.m_hDC == NULL)
	{
		m_dcBk.CreateCompatibleDC(&clDC);
		m_bmpBk.CreateCompatibleBitmap(&clDC, rect.Width(), rect.Height());
		m_pbmpOldBk = m_dcBk.SelectObject(&m_bmpBk);
		m_dcBk.BitBlt(0, 0, rect.Width(), rect.Height(), &clDC, rect.left, rect.top, SRCCOPY);
	}
	pDC->BitBlt(0,0,rect.Width(),rect.Height(),&m_dcBk,0,0,SRCCOPY);
}

void CColorStatic::DrawTextColor(CDC* pDC)
{
	ASSERT(pDC);
	if (m_bPressed)
		pDC->SetTextColor(m_crText[COLOR_PRESSED]);
	else if (m_bHover)
		pDC->SetTextColor(m_crText[COLOR_HOVER]);
	else
		pDC->SetTextColor(m_crText[COLOR_NORMAL]);
}

void CColorStatic::DrawTextBkColor(CDC* pDC)
{
	ASSERT(pDC);
	if (m_bPressed)
		pDC->SetBkColor(m_crTextBk[COLOR_PRESSED]);
	else if (m_bHover)
		pDC->SetBkColor(m_crTextBk[COLOR_HOVER]);
	else
		pDC->SetBkColor(m_crTextBk[COLOR_NORMAL]);
	pDC->SetBkMode(m_bTextBkTransparent?TRANSPARENT:OPAQUE);
}

void CColorStatic::DrawBkColor(CDC* pDC)
{
	ASSERT(pDC);
	COLORREF color;
	if (m_bPressed)
		color = m_crBk[COLOR_PRESSED];
	else if (m_bHover)
		color = m_crBk[COLOR_HOVER];
	else
		color = m_crBk[COLOR_NORMAL];

	CRect cr;
	GetClientRect(cr); 
	CBrush brush(color);
	pDC->FillRect(&cr, &brush);    
}

void CColorStatic::DrawText(CDC* pDC)
{
	ASSERT(pDC);
	DrawTextColor(pDC);
	DrawTextBkColor(pDC);

	CRect rect;
	GetClientRect(rect); 

	CFont* pOldFont = pDC->SelectObject(&m_font);
	CString strText;
	GetWindowText(strText);

	UINT nFormat = 0;
	DWORD dwStyle = GetStyle();

	if (dwStyle & SS_CENTER)
		nFormat |= DT_CENTER;
	else if (dwStyle & SS_LEFT)
		nFormat |= DT_LEFT;
	else if (dwStyle & SS_RIGHT)
		nFormat |= DT_RIGHT;

	if (dwStyle & SS_CENTERIMAGE)
		nFormat |= DT_VCENTER | DT_SINGLELINE;

	pDC->DrawText(strText, rect, nFormat);
	pDC->SelectObject(pOldFont);
}

void CColorStatic::OnPaint()
{
	CPaintDC dc(this);

	if (m_bBkTransparent)
		PaintBk(&dc);
	else
		DrawBkColor(&dc);

	DrawText(&dc);
}