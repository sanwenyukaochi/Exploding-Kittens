using Unity.Services.Analytics;

namespace UnityEngine.Purchasing
{
	internal static class UnifiedReceiptExtensions
	{
		public static AnalyticsTransactionReceipt ToReceiptAndSignature(this UnifiedReceipt receipt)
		{
			return null;
		}

		private static TransactionServer? ToTransactionServer(this UnifiedReceipt receipt)
		{
			return null;
		}
	}
}
