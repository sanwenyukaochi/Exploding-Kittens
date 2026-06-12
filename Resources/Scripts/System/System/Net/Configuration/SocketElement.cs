using System.Configuration;
using System.Net.Sockets;

namespace System.Net.Configuration
{
	public sealed class SocketElement : ConfigurationElement
	{
		public bool AlwaysUseCompletionPortsForAccept
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool AlwaysUseCompletionPortsForConnect
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public IPProtectionLevel IPProtectionLevel
		{
			get
			{
				return default(IPProtectionLevel);
			}
			set
			{
			}
		}

		protected override ConfigurationPropertyCollection Properties => null;

		protected override void PostDeserialize()
		{
		}
	}
}
