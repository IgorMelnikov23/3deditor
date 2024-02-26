/* окно прогарммы */
abstract class BaseWindow{
	string title; //описание окна
	//виджеты (элементы) в окне
	List<Widget> widgets = new List<Widget>();
	Point position; //позиция x, y, z окна
	Size size; //размер окна
	
}