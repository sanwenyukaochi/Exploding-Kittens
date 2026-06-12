using System.Configuration;

namespace System.Net.Configuration
{
	public sealed class WebRequestModuleElement : ConfigurationElement
	{
		public string Prefix
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override ConfigurationPropertyCollection Properties => null;

		public Type Type
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public WebRequestModuleElement()
		{
		}

		public WebRequestModuleElement(string prefix, string type)
		{
		}

		public WebRequestModuleElement(string prefix, Type type)
		{
		}
	}
}
