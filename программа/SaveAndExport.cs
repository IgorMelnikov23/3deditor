namespace ConsoleApp1;

/// <summary>
/// Тип видео
/// </summary>
public enum VideoType{
	/// <summary>
	/// Формат .mp4
	/// </summary>
	MP4 = 0,
    /// <summary>
    /// Формат .mov
    /// </summary>
    MOV = 1,
    /// <summary>
    /// Формат .avi
    /// </summary>
    AVI = 2,
    /// <summary>
    /// Формат .mvk
    /// </summary>
    MKV = 3
}

/// <summary>
/// Модуль для экспорта и сохранения проекта
/// </summary>
public static class SaveAndExport{
	
	/// <summary>
	/// Сохранить проект
	/// </summary>
	/// <param name="project">Проект</param>
	public static void SaveProject(Project project){
		File.WriteAllText(project.caption +".proj", project.Serialize());
	}
	
	/// <summary>
	/// Открыть проект
	/// </summary>
	/// <returns>Проект</returns>
	public static Project OpenProject(){
		/*OpenFileDialog ofd = new OpenFileDialog();
		if (ofd.DialogResult == DialogResult.Yes)
			return Deserialize(ofd.FileName);*/
		return null!;
	}
	
	/// <summary>
	/// Экспорт анимации в видео
	/// </summary>
	/// <param name="project">Проект</param>
	/// <param name="type">Тип видео</param>
	public static void ExportProject(Project project, VideoType type){
		File.WriteAllText(project.caption +$".{type}" , project.Serialize());
	}
	
}