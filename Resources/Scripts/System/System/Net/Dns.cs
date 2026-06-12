using System.Threading.Tasks;

namespace System.Net
{
	public static class Dns
	{
		private delegate IPAddress[] GetHostAddressesCallback(string hostName);

		public static IAsyncResult BeginGetHostAddresses(string hostNameOrAddress, AsyncCallback requestCallback, object state)
		{
			return null;
		}

		public static IPAddress[] EndGetHostAddresses(IAsyncResult asyncResult)
		{
			return null;
		}

		private static bool GetHostByName_icall(string host, out string h_name, out string[] h_aliases, out string[] h_addr_list, int hint)
		{
			h_name = null;
			h_aliases = null;
			h_addr_list = null;
			return false;
		}

		private static bool GetHostByAddr_icall(string addr, out string h_name, out string[] h_aliases, out string[] h_addr_list, int hint)
		{
			h_name = null;
			h_aliases = null;
			h_addr_list = null;
			return false;
		}

		private static bool GetHostName_icall(out string h_name)
		{
			h_name = null;
			return false;
		}

		private static void Error_11001(string hostName)
		{
		}

		private static IPHostEntry hostent_to_IPHostEntry(string originalHostName, string h_name, string[] h_aliases, string[] h_addrlist)
		{
			return null;
		}

		private static IPHostEntry GetHostByAddressFromString(string address, bool parse)
		{
			return null;
		}

		public static IPHostEntry GetHostEntry(string hostNameOrAddress)
		{
			return null;
		}

		public static IPHostEntry GetHostEntry(IPAddress address)
		{
			return null;
		}

		public static IPAddress[] GetHostAddresses(string hostNameOrAddress)
		{
			return null;
		}

		[Obsolete("Use GetHostEntry instead")]
		public static IPHostEntry GetHostByName(string hostName)
		{
			return null;
		}

		public static string GetHostName()
		{
			return null;
		}

		public static Task<IPAddress[]> GetHostAddressesAsync(string hostNameOrAddress)
		{
			return null;
		}
	}
}
