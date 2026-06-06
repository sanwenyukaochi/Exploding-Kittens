using System.Collections.Generic;
using Unity.Services.Analytics;
using Unity.Services.Core.Analytics.Internal;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	internal class CoreAnalyticsAdapter : IAnalyticsAdapter
	{
		private readonly IAnalyticsService m_Analytics;

		private readonly ILogger m_Logger;

		private IAnalyticsStandardEventComponent? m_CoreAnalytics;

		public CoreAnalyticsAdapter(IAnalyticsService analytics, ILogger logger)
		{
		}

		public void SendTransactionEvent(Product product)
		{
		}

		private Dictionary<string, object> BuildTransactionParameters(Product product)
		{
			return null;
		}

		public void SendTransactionFailedEvent(Product product, PurchaseFailureDescription description)
		{
		}

		private IAnalyticsStandardEventComponent? CoreAnalytics()
		{
			return null;
		}

		private Dictionary<string, object> BuildTransactionFailedParameters(Product product, PurchaseFailureReason reason)
		{
			return null;
		}

		private static string GetTransactionName(Product product)
		{
			return null;
		}

		private static Dictionary<string, object> GenerateItemReceivedForPurchase(Product product)
		{
			return null;
		}

		private Dictionary<string, object> GenerateRealCurrencySpentOnPurchase(Product product)
		{
			return null;
		}

		private Dictionary<string, object> CreateRealCurrencyFromProduct(Product product)
		{
			return null;
		}

		private long CheckCurrencyCodeAndExtractRealCurrencyAmount(Product product)
		{
			return 0L;
		}

		private long ExtractRealCurrencyAmount(Product product)
		{
			return 0L;
		}
	}
}
