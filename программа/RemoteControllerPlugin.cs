namespace ConsoleApp1;

/// <summary>
/// Плагин "Пульт управления"
/// </summary>
class RemoteControllerPlugin : BasePlugin
{

    /// <summary>
    /// Запустить плагин
    /// </summary>
    public override void Run(){
		//показать "пульт"
		new MainWindow().Show();
	}
}