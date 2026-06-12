using System.Configuration;

namespace System.Net.Configuration
{
	public sealed class ConnectionManagementElement : ConfigurationElement
	{
		public string Address
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int MaxConnection
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		protected override ConfigurationPropertyCollection Properties => null;

		public ConnectionManagementElement()
		{
		}

		public ConnectionManagementElement(string address, int maxConnection)
		{
		}
	}
}
