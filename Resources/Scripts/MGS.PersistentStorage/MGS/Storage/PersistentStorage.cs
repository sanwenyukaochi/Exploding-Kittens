namespace MGS.Storage
{
	public abstract class PersistentStorage
	{
		private static PersistentStorage s_PersistentStorageHandler;

		public static void Init(PersistentStorage persistentStorageHandler)
		{
		}

		public abstract void Initialize();

		public static int GetInt(string key, int defaultValue)
		{
			return 0;
		}

		public static void SetInt(string key, int value)
		{
		}

		public abstract int ReadInt(string key, int defaultValue);

		public abstract void WriteInt(string key, int value);
	}
}
