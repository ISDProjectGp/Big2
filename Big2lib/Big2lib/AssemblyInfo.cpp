#include "stdafx.h"

using namespace System;
using namespace System::Reflection;
using namespace System::Runtime::CompilerServices;
using namespace System::Runtime::InteropServices;
using namespace System::Security::Permissions;

//
// �M����һ���YӍ�������еČ��Լ����ơ�
// ׃���@Щ���Ե�ֵ�����޸ĽM�������P
// �YӍ��
//
[assembly:AssemblyTitleAttribute(L"Big2lib")];
[assembly:AssemblyDescriptionAttribute(L"")];
[assembly:AssemblyConfigurationAttribute(L"")];
[assembly:AssemblyCompanyAttribute(L"")];
[assembly:AssemblyProductAttribute(L"Big2lib")];
[assembly:AssemblyCopyrightAttribute(L"Copyright (c)  2016")];
[assembly:AssemblyTrademarkAttribute(L"")];
[assembly:AssemblyCultureAttribute(L"")];

//
// �M���İ汾�YӍ�������Ă�ֵ���M��: 
//
//      ��Ҫ�汾
//      ��Ҫ�汾
//      �M����̖
//      ��ӆ��̖
//
// ������ָ�����е�ֵ��Ҳ�����������µķ�ʽ��ʹ�� '*' ����ӆ�ͽM����̖
// ָ�����A�Oֵ: 

[assembly:AssemblyVersionAttribute("1.0.*")];

[assembly:ComVisible(false)];

[assembly:CLSCompliantAttribute(true)];