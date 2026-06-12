public abstract class SA_NonMonoSingleton<T> where T : SA_NonMonoSingleton<T>, new()
{
	private static T _Instance;

	public static T Instance => null;
}
