using System;

using Project.Infrastructure;
using Project.Framework.ViewMain;
using Project.Framework.ViewStart;
using Project.Framework.ViewPage1;
using Project.Framework.ViewPage2;
using Project.Framework.ViewPage3;

namespace Project.Framework
{
	public class FactoryGUI_GTK : IFactoryGUI
	{
		public IGLApplication GetIGLApplication()
		{
			return new ApplicationGTK();
		}
		public IViewStart GetViewStart()
		{
			return new WindowStart();
		}
		public IViewMain GetViewMain()
		{
			return new WindowMain();
		}
		public INavigationNode_Page1 GetViewPage1()
		{
			return new WidgetPage1();
		}
		public INavigationNode_Page2 GetViewPage2 ()
		{
			return new WidgetPage2();
		}
		public INavigationNode_Page3 GetViewPage3 ()
		{
			return new WidgetPage3();
		}				
	}
}

