using System.Collections.Generic;

namespace ConsoleApp1;

/// <summary>
/// Панель инструментов
/// </summary>
static class Toolbar{
	
	/// <summary>
	/// Список инструментов
	/// </summary>
	static Dictionary<string, Instrument> intruments = new Dictionary<string, Instrument>();
	
	/// <summary>
	/// Запустить инструмент (по названию)
	/// </summary>
	/// <param name="caption">Название инструмента</param>
	public static void RunIntrument(string caption){
		intruments[caption].Run();
	}
}