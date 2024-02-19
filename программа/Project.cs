/* Проект */
public class Project{
	string name; //название
	string author; //автор
	uint size = 0; //размер в байтах
	List<Item> items = new List<Item>(); //объекты в проекте
	
	//создание проекта
	public Project(string name, string author){
		this.name = name;
		this.author = author;
	}
}