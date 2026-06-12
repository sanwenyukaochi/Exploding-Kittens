using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Telemetry;

namespace UnityEngine.Purchasing
{
	internal class MetricizedGooglePlayStoreExtensions : GooglePlayStoreExtensions
	{
		private readonly ITelemetryMetricsService m_TelemetryMetricsService;

		internal MetricizedGooglePlayStoreExtensions(IGooglePlayStoreService googlePlayStoreService, IGooglePurchaseStateEnumProvider googlePurchaseStateEnumProvider, ILogger logger, ITelemetryDiagnostics telemetryDiagnostics, ITelemetryMetricsService telemetryMetricsService)
			: base(null, null, null, null)
		{
		}
	}
}
