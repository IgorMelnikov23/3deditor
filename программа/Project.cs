/* Проект */
public class Project{
	string caption; //наименование
	string author; //автор
	uint size = 0; //размер в байтах
	List<Item> items = new List<Item>(); //объекты в проекте
	
	//создание проекта
	public Project(string name, string author){
		this.name = name;
		this.author = author;
	}
	
	//добавить объект в проект
	public void AddItem(Item item){
		items.Add(item);
	}
	
	//добавить несколько объектов в проект
	public void AddItem(List<Item> items){
		this.items.AddRange(items);
	}
	
	//удалить объект в проекте
	public void AddItem(Item item){
		items.Remove(item);
	}
}