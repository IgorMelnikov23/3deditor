/* типы для экспорта анимации */
enum VideoType{
	MP4 = 0,
	MOV = 1,
	AVI = 2
}

// Модуль для экспорта и сохранения проекта
public static class SaveAndExport{
	
	//сохранение проекта
	public static void SaveProject(Project project){
		File.WriteAllText(project.name +".proj", project.Serialize());
	}
	
	//открытие проекта
	public static Project OpenProject(){
		OpenFileDialog ofd = new OpenFileDialog();
		if (ofd.DialogResult == DialogResult.Yes)
			return Deserialize(ofd.FileName);
		return null;
	}
	
	//экспорт анимации в виде видео
	public static void ExportProject(Project project, VideoType type){
		File.WriteAllText(project.name +$".{type}" prject.Serialize(type));
	}
	
}