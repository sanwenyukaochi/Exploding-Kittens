using System.Configuration;

namespace System.Net.Configuration
{
	public sealed class SettingsSection : ConfigurationSection
	{
		public HttpListenerElement HttpListener => null;

		public HttpWebRequestElement HttpWebRequest => null;

		public Ipv6Element Ipv6 => null;

		public PerformanceCountersElement PerformanceCounters => null;

		protected override ConfigurationPropertyCollection Properties => null;

		public ServicePointManagerElement ServicePointManager => null;

		public SocketElement Socket => null;

		public WebProxyScriptElement WebProxyScript => null;

		public WebUtilityElement WebUtility => null;

		public WindowsAuthenticationElement WindowsAuthentication => null;
	}
}
