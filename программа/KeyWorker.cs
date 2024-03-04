namespace ConsoleApp1;

/// <summary>
/// Модуль для работы с горячими клавишами
/// </summary>
public static class KeyWorker{
	
	/// <summary>
	/// Нажатие клавиши "S"
	/// </summary>
	public static void PressKeyS(){
		if (new OS().name == "Window")
			 new Animation().Play();
	}
	
	/// <summary>
	/// нажатие клавиши "T"
	/// </summary>
	public static void PressKeyT(){
		if (new OS().name == "MacOS")
            new Animation().Play();
    }
	
}