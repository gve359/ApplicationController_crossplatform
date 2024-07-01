
using System;

namespace Project.Infrastructure
{
	/// <summary>
	/// Это интерфейс для Application - главного класса управления программой т.к. в Net и Mono он отличается.
	/// Должен быть создан перед созданием форм.
	/// </summary>
	public interface IGLApplication
	{
		void StartProgram();
		void FinishProgram();
	}
}
