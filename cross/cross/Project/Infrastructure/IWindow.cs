
using System;

namespace Project.Infrastructure
{
	/// <summary>
	/// Интерфейс форм.
	/// Всюду префикс "IWindow" чтобы названия интерфейсных методов не накладывались 
	/// на названия родных методов.
	/// </summary>
	
	public interface IWindow
	{
		event Action IWindowShowed;
		event Action IWindowClosed;
		
		void IWindowShow();
		void IWindowClose();
		void IWindowHide();
	}
}
