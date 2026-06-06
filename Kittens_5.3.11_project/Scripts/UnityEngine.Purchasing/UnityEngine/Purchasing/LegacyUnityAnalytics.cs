using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	internal class LegacyUnityAnalytics : ILegacyUnityAnalytics
	{
		public void SendTransactionEvent(string productId, decimal amount, string currency, string receiptPurchaseData, string signature)
		{
		}

		public void SendCustomEvent(string name, Dictionary<string, object> data)
		{
		}
	}
}
