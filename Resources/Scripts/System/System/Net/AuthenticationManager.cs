using System.Collections;

namespace System.Net
{
	public class AuthenticationManager
	{
		private static ArrayList modules;

		private static object locker;

		private static ICredentialPolicy credential_policy;

		private static void EnsureModules()
		{
		}

		public static Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials)
		{
			return null;
		}

		private static Authorization DoAuthenticate(string challenge, WebRequest request, ICredentials credentials)
		{
			return null;
		}

		public static Authorization PreAuthenticate(WebRequest request, ICredentials credentials)
		{
			return null;
		}
	}
}
