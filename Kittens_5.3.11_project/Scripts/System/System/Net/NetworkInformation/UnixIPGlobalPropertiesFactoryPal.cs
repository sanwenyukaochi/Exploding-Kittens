namespace System.Net.NetworkInformation
{
	internal static class UnixIPGlobalPropertiesFactoryPal
	{
		private static bool PlatformNeedsLibCWorkaround { get; }

		public static IPGlobalProperties Create()
		{
			return null;
		}
	}
}
