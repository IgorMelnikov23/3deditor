namespace ConsoleApp1;

/// <summary>
/// Проект
/// </summary>
public class Project{

	/// <summary>
	/// Наименование
	/// </summary>
	public string caption;

	/// <summary>
	/// Автор
	/// </summary>
	string author;

	/// <summary>
	/// Размер (байты)
	/// </summary>
	uint size = 0;

	/// <summary>
	/// Список объектов
	/// </summary>
	List<Item> items;

    /// <summary>
    /// Конструктор с параметрами
    /// </summary>
    /// <param name="caption">Наименование проекта</param>
    /// <param name="author">Автор проекта</param>
    public Project(string caption, string author){
		this.caption = caption;
		this.author = author;
		items = new List<Item>();
	}
	
	/// <summary>
	/// Добавить объект в проект
	/// </summary>
	/// <param name="item">Объект</param>
	public void AddItem(Item item){
		items.Add(item);
	}
	
	/// <summary>
	/// Добавить несколько объектов в проект
	/// </summary>
	/// <param name="items">Список объектов</param>
	public void AddItem(List<Item> items){
		this.items.AddRange(items);
	}
	
	/// <summary>
	/// Удалить объект из проекта
	/// </summary>
	/// <param name="item">Объект</param>
	public void RemoveItem(Item item){
		items.Remove(item);
	}

	/// <summary>
	/// Сохранить проект
	/// </summary>
	/// <returns>Название проекта</returns>
	public string Serialize()
	{
		return "";
	}
}