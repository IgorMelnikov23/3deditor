using System.Drawing;

namespace ConsoleApp1;

/// <summary>
/// Объект (базовая реализация)
/// </summary>
public abstract class Item{
	
	/// <summary>
	/// Позиция
	/// </summary>
	Point position;

	/// <summary>
	/// Размер
	/// </summary>
	Size size;

	/// <summary>
	/// Углы поворота
	/// </summary>
	Rotation rotation;

	/// <summary>
	/// Список переменных
	/// </summary>
	List<Variable> variables;//список переменных
	
	/// <summary>
	/// Конструктор без параметров
	/// </summary>
	public Item(){
		variables = new();
	}
	

	/// <summary>
	/// Изменение позиции
	/// </summary>
	/// <param name="position">Новая позиция</param>
	public void ChangePosition(Point position){
		this.position = position;
	}
	
	/// <summary>
	/// Изменение размера
	/// </summary>
	/// <param name="size">Новый размер</param>
	public void ChangeSize(Size size){
		this.size = size;
	}
	
	/// <summary>
	/// Изменение угла поворота объекта
	/// </summary>
	/// <param name="rotation">Новый угол поворота</param>
	public void ChangeRotate(Rotation rotation){
		this.rotation = rotation;
	}
	
}