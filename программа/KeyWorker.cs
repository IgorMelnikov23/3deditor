/* работа с горячими клавишами */
public static class KeyWorker{
	
	//если нажата клавиша "S" и ОС = "Window"
	public void PressKeyS(){
		if (OS.Name == "Window")
			Animation.Play();
	}
	
	//если нажата клавиша "T" и ОС = "MacOS"
	public void PressKeyT(){
		if (OS.Name == "MacOS")
			Animation.Play();
	}
	
}