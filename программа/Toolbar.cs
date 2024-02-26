// Панель инструментов
static class Toolbar{
	
	//инструменты из панели инстурментов
	Dictinary<string, Instrument> intruments = new Dictionary<string, Instrument>();
	
	//запустить инструмент по его названию
	public void RunIntrument(string caption){
		intruments[caption].Run();
	}
}