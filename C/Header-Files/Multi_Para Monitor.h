// Multi_Para Monitor.h : PROJECT_NAME Ӧ�ó������ͷ�ļ�
//

#pragma once

#ifndef __AFXWIN_H__
	#error "�ڰ������ļ�֮ǰ������stdafx.h�������� PCH �ļ�"
#endif

#include "resource.h"		// ������
#include "PackID.h"

// CMulti_ParaMonitorApp:
// �йش����ʵ�֣������ Multi_Para Monitor.cpp
//

class CMulti_ParaMonitorApp : public CWinApp
{
public:
	CMulti_ParaMonitorApp();

// ��д
	public:
	virtual BOOL InitInstance();

// ʵ��

	DECLARE_MESSAGE_MAP()
};

extern CMulti_ParaMonitorApp theApp;