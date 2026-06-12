using System.Configuration;

namespace System.Net.Configuration
{
	public sealed class HttpListenerTimeoutsElement : ConfigurationElement
	{
		public TimeSpan DrainEntityBody => default(TimeSpan);

		public TimeSpan EntityBody => default(TimeSpan);

		public TimeSpan HeaderWait => default(TimeSpan);

		public TimeSpan IdleConnection => default(TimeSpan);

		public long MinSendBytesPerSecond => 0L;

		protected override ConfigurationPropertyCollection Properties => null;

		public TimeSpan RequestQueue => default(TimeSpan);
	}
}
