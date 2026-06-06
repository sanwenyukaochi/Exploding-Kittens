using UnityEngine;

namespace OnePF
{
	public class OpenIAB
	{
		private static IOpenIAB _billing;

		public static GameObject EventManager => null;

		static OpenIAB()
		{
		}

		public static void mapSku(string sku, string storeName, string storeSku)
		{
		}

		public static void init(Options options)
		{
		}

		public static void unbindService()
		{
		}

		public static bool areSubscriptionsSupported()
		{
			return false;
		}

		public static void queryInventory()
		{
		}

		public static void queryInventory(string[] skus)
		{
		}

		public static void purchaseProduct(string sku, string developerPayload = "")
		{
		}

		public static void purchaseSubscription(string sku, string developerPayload = "")
		{
		}

		public static void consumeProduct(Purchase purchase)
		{
		}

		public static void restoreTransactions()
		{
		}

		public static bool isDebugLog()
		{
			return false;
		}

		public static void enableDebugLogging(bool enabled)
		{
		}

		public static void enableDebugLogging(bool enabled, string tag)
		{
		}
	}
}
