using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Unity.Services.Core.Telemetry.Internal
{
	internal class Metrics : IMetrics
	{
		[CompilerGenerated]
		private readonly IDictionary<string, string> _003CPackageTags_003Ek__BackingField;

		void IMetrics.SendGaugeMetric(string name, double value, IDictionary<string, string> tags)
		{
		}

		void IMetrics.SendHistogramMetric(string name, double time, IDictionary<string, string> tags)
		{
		}

		void IMetrics.SendSumMetric(string name, double value, IDictionary<string, string> tags)
		{
		}
	}
}
