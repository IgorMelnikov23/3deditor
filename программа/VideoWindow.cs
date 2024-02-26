//окно для просмотра видеоуроков
class VideoWindow: BaseWindow{
	
	//список видеоуроков
	List<Video> videos = new List<Video>();
	
	//запуск видео по его номеру
	public void PlayVideo(int index)
	{
		videos[index].Play();
	}
	
}