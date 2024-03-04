namespace ConsoleApp1;

/// <summary>
/// Окно для просмотра видеоуроков
/// </summary>
class VideoWindow: BaseWindow{
	
	/// <summary>
	/// Список видеоуроков
	/// </summary>
	List<Video> videos = new List<Video>();
	
	/// <summary>
	/// Запустить видео (но номеру)
	/// </summary>
	/// <param name="index">Номер видео</param>
	public void PlayVideo(int index)
	{
		videos[index].Play();
	}
	
}