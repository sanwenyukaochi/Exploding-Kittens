public class AppConfig
{
	public string AppVersion;

	private static AppConfig instance;

	public int ApiVersion => 0;

	public static AppConfig Instance => null;
}
