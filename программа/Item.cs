/* Объект (абстрактный) */
public abstract class Item{
	
	Point position; //позиция x, y, z
	Size size; //размер объекта (длина, ширина, высота)
	Rotation rotation; // углы поворота объекта в градусах (по x, y и z)
	List<Variable> variables;//список переменных
	
	//конструктор
	public Item(){
		variables = new List<Variable>()
	}
	
	/* Изменение позиции объекта */
	public void ChangePosition(Point position){
		this.position = position;
	}
	
	/* Изменение размера объекта */
	public void ChangeSize(Size size){
		this.size = size;
	}
	
	/* Изменение угла поворота объекта */
	public void ChangeRotate(Rotation rotation){
		this.rotation = rotation;
	}
	
}