using System.Configuration;

namespace System.Net.Configuration
{
	public sealed class NetSectionGroup : ConfigurationSectionGroup
	{
		public AuthenticationModulesSection AuthenticationModules => null;

		public ConnectionManagementSection ConnectionManagement => null;

		public DefaultProxySection DefaultProxy => null;

		public MailSettingsSectionGroup MailSettings => null;

		public RequestCachingSection RequestCaching => null;

		public SettingsSection Settings => null;

		public WebRequestModulesSection WebRequestModules => null;

		public static NetSectionGroup GetSectionGroup(System.Configuration.Configuration config)
		{
			return null;
		}
	}
}
