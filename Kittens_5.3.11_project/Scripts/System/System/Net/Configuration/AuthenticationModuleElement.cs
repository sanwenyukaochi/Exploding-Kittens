using System.Configuration;

namespace System.Net.Configuration
{
	public sealed class AuthenticationModuleElement : ConfigurationElement
	{
		protected override ConfigurationPropertyCollection Properties => null;

		public string Type
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AuthenticationModuleElement()
		{
		}

		public AuthenticationModuleElement(string typeName)
		{
		}
	}
}
