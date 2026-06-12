using System.Configuration;

namespace System.Net.Configuration
{
	public sealed class PerformanceCountersElement : ConfigurationElement
	{
		public bool Enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected override ConfigurationPropertyCollection Properties => null;
	}
}
