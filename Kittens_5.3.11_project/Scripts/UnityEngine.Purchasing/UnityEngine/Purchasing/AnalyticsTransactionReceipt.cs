using Unity.Services.Analytics;

namespace UnityEngine.Purchasing
{
	internal class AnalyticsTransactionReceipt
	{
		public string transactionReceipt { get; set; }

		public string transactionReceiptSignature { get; set; }

		public TransactionServer? transactionServer { get; set; }
	}
}
