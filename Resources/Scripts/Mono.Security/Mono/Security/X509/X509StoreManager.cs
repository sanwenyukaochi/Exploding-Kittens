namespace Mono.Security.X509
{
	public sealed class X509StoreManager
	{
		private static string _userPath;

		private static string _localMachinePath;

		private static X509Stores _userStore;

		private static X509Stores _machineStore;

		internal static string CurrentUserPath => null;

		internal static string LocalMachinePath => null;

		public static X509Stores CurrentUser => null;

		public static X509Stores LocalMachine => null;

		public static X509CertificateCollection TrustedRootCertificates => null;
	}
}
