using System;

using Project.Infrastructure;
using Project.Framework.ViewMain;
using Project.Framework.ViewStart;
using Project.Framework.ViewPage1;
using Project.Framework.ViewPage2;
using Project.Framework.ViewPage3;

namespace Project.Framework
{
	public class FactoryWinForms : IFactoryGUI
	{
		public IGLApplication GetIGLApplication()
		{
			return new ApplicationWinForm();
		}
		public IViewStart GetViewStart()
		{
			return new FormStart();
		}
		public IViewMain GetViewMain()
		{
			return new FormMain();
		}
		public INavigationNode_Page1 GetViewPage1()
		{
			return new Control1();
		}
		public INavigationNode_Page2 GetViewPage2 ()
		{
			return new Control2();
		}
		public INavigationNode_Page3 GetViewPage3 ()
		{
			return new Control3();
		}
	}
}