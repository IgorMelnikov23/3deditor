using System.Drawing;

namespace ConsoleApp1;

/// <summary>
/// Окно программы (базовая реализация)
/// </summary>
abstract class BaseWindow{
	/// <summary>
	/// Описание (заголовок)
	/// </summary>
	string title;
	
	/// <summary>
	/// Список виджетов в окне
	/// </summary>
	List<Widget> widgets = new List<Widget>();

	/// <summary>
	/// Позиция окна
	/// </summary>
	Point position;

	/// <summary>
	/// Размер окна
	/// </summary>
	Size size;

    /// <summary>
    /// Показать окно
    /// </summary>
    public void Show()
    {

    }

}