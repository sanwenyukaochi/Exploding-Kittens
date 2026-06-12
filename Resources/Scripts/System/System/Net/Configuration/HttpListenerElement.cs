using System.Configuration;

namespace System.Net.Configuration
{
	public sealed class HttpListenerElement : ConfigurationElement
	{
		protected override ConfigurationPropertyCollection Properties => null;

		public HttpListenerTimeoutsElement Timeouts => null;

		public bool UnescapeRequestUrl => false;
	}
}
