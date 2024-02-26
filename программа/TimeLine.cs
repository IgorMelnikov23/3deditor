/* Временная линия */
public class TimeLine{
	//список кадров
	List<Frame> frames = new List<Frame>();
	
	//запустить кадры (play)
	public void Play(){
		foreach(Frame frame in frames)
			frame.display();
	}
}