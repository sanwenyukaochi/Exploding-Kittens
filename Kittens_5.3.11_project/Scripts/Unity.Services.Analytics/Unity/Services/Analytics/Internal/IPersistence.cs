namespace Unity.Services.Analytics.Internal
{
	internal interface IPersistence
	{
		void SaveValue(string key, int value);

		int LoadValue(string key);
	}
}
