#pragma once


// CColorStatic

class CColorStatic : public CStatic
{
	DECLARE_DYNAMIC(CColorStatic)

	enum  
	{
		COLOR_NORMAL=0,
		COLOR_HOVER,
		COLOR_PRESSED,
		COLOR_MAX_NUM
	};

	enum 
	{
		BOLD_MASK=1,
		ITALIC_MASK=2,
		UNDERLINE_MASK=4
	};

public:
	enum 
	{
		stateNormal=1,
		stateHover=2,
		statePressed=4,
		stateAll=7
	};

public:
	CColorStatic();
	virtual ~CColorStatic();

public:
	void SetTextColor(COLORREF color,UINT uStateFlag=stateAll);
	void SetTextBkColor(COLORREF color,UINT uStateFlag=stateAll);
	void SetBkColor(COLORREF color,UINT uStateFlag=stateAll);

	void GetTextColor(COLORREF* color,UINT uStateFlag=stateAll);
	void GetTextBkColor(COLORREF* color,UINT uStateFlag=stateAll);
	void GetBkColor(COLORREF* color,UINT uStateFlag=stateAll);

	BOOL SetBold(BOOL bBold,BOOL bRedraw=TRUE);
	BOOL SetItalic(BOOL bItalic,BOOL bRedraw=TRUE);
	BOOL SetUnderline(BOOL bUnderline,BOOL bRedraw=TRUE);
	BOOL SetFont(LOGFONT& logFont,BOOL bRedraw=TRUE);
	BOOL SetFont(CFont& font,BOOL bRedraw=TRUE);
	BOOL SetFont(LPCTSTR lpFaceName,int nPointSize,BOOL bRedraw=TRUE);

	BOOL IsBold() const
	{ return m_mask&BOLD_MASK; }

	BOOL IsItalic() const
	{ return m_mask&ITALIC_MASK; }

	BOOL IsUnderline() const
	{ return m_mask&UNDERLINE_MASK; }

	CFont* GetFont()
	{ return &m_font; }

	const CFont* GetFont() const
	{ return &m_font; }

	BOOL SetCursor(LPCTSTR lpName);
	BOOL SetCursor(UINT uID);
	void SetCursor(HCURSOR hCursor)
	{  m_hCursor = hCursor;  }

	HCURSOR GetCursor() const
	{  return m_hCursor; }

	void SetTextBkTransparent(BOOL bTransparent);
	void SetBkTransparent(BOOL bTransparent);

protected:
	DECLARE_MESSAGE_MAP()
	afx_msg void OnMouseMove(UINT nFlags, CPoint point);
	afx_msg void OnPaint();
	afx_msg BOOL OnStnClicked();
	afx_msg BOOL OnSetCursor(CWnd* pWnd, UINT nHitTest, UINT message);

protected:
	virtual void PreSubclassWindow();
	virtual void PaintBk(CDC* pDC);
	virtual void DrawText(CDC* pDC);
	virtual void DrawTextColor(CDC* pDC);
	virtual void DrawTextBkColor(CDC* pDC);
	virtual void DrawBkColor(CDC* pDC);

protected:
	COLORREF  m_crText[COLOR_MAX_NUM]; 
	COLORREF  m_crTextBk[COLOR_MAX_NUM];
	COLORREF  m_crBk[COLOR_MAX_NUM];

	CFont    m_font;
	HCURSOR  m_hCursor;
	UINT     m_mask;
	BOOL     m_bHover;
	BOOL     m_bPressed;
	BOOL     m_bTextBkTransparent;
	BOOL     m_bBkTransparent;

	CDC      m_dcBk;
	CBitmap     m_bmpBk;
	CBitmap* m_pbmpOldBk;

};


