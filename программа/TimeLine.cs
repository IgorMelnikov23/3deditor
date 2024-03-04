namespace ConsoleApp1;

/// <summary>
/// Временная линия
/// </summary>
public class TimeLine{
	/// <summary>
	/// Список кадров
	/// </summary>
	List<Frame> frames = new List<Frame>();
	
	/// <summary>
	/// Запустить кадры
	/// </summary>
	public void Play(){
		foreach(Frame frame in frames)
			frame.Display();
	}
}