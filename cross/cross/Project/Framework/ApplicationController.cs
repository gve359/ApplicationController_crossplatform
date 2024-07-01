using System;

using Project.Framework.ViewMain;
using Project.Framework.ViewStart;
using Project.Framework.ViewPage1;
using Project.Framework.ViewPage2;
using Project.Framework.ViewPage3;
using Project.Infrastructure;


namespace Project.Framework
{
	public class ApplicationController
	{
		private IGLApplication application;
		private IViewStart viewStart;
		private IViewMain viewMain;
		private INavigationNode_Page1 viewPage1;
		private INavigationNode_Page2 viewPage2;
		private INavigationNode_Page3 viewPage3;
		
		
		private void SetLinks(IGLApplication application, IViewStart viewStart, IViewMain viewMain, INavigationNode_Page1 viewPage1, INavigationNode_Page2 viewPage2, INavigationNode_Page3 viewPage3)
		{
			this.application = application;			
			this.viewStart = viewStart;
			this.viewMain = viewMain;
			this.viewPage1 = viewPage1;
			this.viewPage2 = viewPage2;
			this.viewPage3 = viewPage3;				
		}
		
		private void SetNavigation()
		{
			viewStart.IWindowClosed += ()  => {
				this.application.FinishProgram();
			};
			viewStart.PressedContinue += () => {
				viewMain.SetContent(viewPage1);
				viewStart.IWindowHide();
				viewMain.IWindowShow();
			};
			
			viewMain.IWindowClosed += () => {
				this.application.FinishProgram();
			};
						
			viewPage1.PressedForward += () => {
				viewMain.SetContent(viewPage2);
			};
			
			viewPage2.PressedForward += () => {
				viewMain.SetContent(viewPage3);
			};
			viewPage2.PressedBack += () => {
				viewMain.SetContent(viewPage1);
			};
			
			viewPage3.PressedBack += () => {
				viewMain.SetContent(viewPage2);
			};			
		}
		
		public ApplicationController(IGLApplication application, IViewStart viewStart, IViewMain viewMain, INavigationNode_Page1 viewPage1, INavigationNode_Page2 viewPage2, INavigationNode_Page3 viewPage3)
		{
			this.SetLinks(application, viewStart, viewMain, viewPage1, viewPage2, viewPage3);
			this.SetNavigation();			
		}
		
		public void Run()
		{	
			this.viewStart.IWindowShow();
			this.application.StartProgram();
		}			
	}
}
