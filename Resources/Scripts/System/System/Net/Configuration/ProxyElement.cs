using System.Configuration;

namespace System.Net.Configuration
{
	public sealed class ProxyElement : ConfigurationElement
	{
		public enum AutoDetectValues
		{
			False = 0,
			True = 1,
			Unspecified = -1
		}

		public enum BypassOnLocalValues
		{
			False = 0,
			True = 1,
			Unspecified = -1
		}

		public enum UseSystemDefaultValues
		{
			False = 0,
			True = 1,
			Unspecified = -1
		}

		public AutoDetectValues AutoDetect
		{
			get
			{
				return default(AutoDetectValues);
			}
			set
			{
			}
		}

		public BypassOnLocalValues BypassOnLocal
		{
			get
			{
				return default(BypassOnLocalValues);
			}
			set
			{
			}
		}

		protected override ConfigurationPropertyCollection Properties => null;

		public Uri ProxyAddress
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Uri ScriptLocation
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public UseSystemDefaultValues UseSystemDefault
		{
			get
			{
				return default(UseSystemDefaultValues);
			}
			set
			{
			}
		}
	}
}
