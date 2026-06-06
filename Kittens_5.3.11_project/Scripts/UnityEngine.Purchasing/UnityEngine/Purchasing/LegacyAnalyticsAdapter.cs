using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	internal class LegacyAnalyticsAdapter : IAnalyticsAdapter
	{
		private readonly ILegacyUnityAnalytics m_LegacyAnalytics;

		public LegacyAnalyticsAdapter(ILegacyUnityAnalytics legacyAnalytics)
		{
		}

		public void SendTransactionEvent(Product product)
		{
		}

		public void SendTransactionFailedEvent(Product product, PurchaseFailureDescription description)
		{
		}
	}
}
