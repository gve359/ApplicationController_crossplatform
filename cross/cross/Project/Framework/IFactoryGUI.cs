using System;

using Project.Infrastructure;
using Project.Framework.ViewMain;
using Project.Framework.ViewStart;
using Project.Framework.ViewPage1;
using Project.Framework.ViewPage2;
using Project.Framework.ViewPage3;

namespace Project.Framework
{
	public interface IFactoryGUI
	{
		IGLApplication GetIGLApplication();

		IViewStart GetViewStart();
		IViewMain GetViewMain();
		INavigationNode_Page1 GetViewPage1();
		INavigationNode_Page2 GetViewPage2();
		INavigationNode_Page3 GetViewPage3();			
	}
}


