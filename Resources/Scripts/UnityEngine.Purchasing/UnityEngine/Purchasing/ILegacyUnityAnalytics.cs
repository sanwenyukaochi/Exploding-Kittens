using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	internal interface ILegacyUnityAnalytics
	{
		void SendTransactionEvent(string productId, decimal amount, string currency, string receiptPurchaseData, string signature);

		void SendCustomEvent(string name, Dictionary<string, object> data);
	}
}
