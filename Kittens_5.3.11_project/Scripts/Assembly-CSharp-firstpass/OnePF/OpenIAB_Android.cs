using System;
using System.Collections.Generic;
using UnityEngine;

namespace OnePF
{
	public class OpenIAB_Android : IOpenIAB
	{
		public static readonly string STORE_GOOGLE;

		public static readonly string STORE_AMAZON;

		public static readonly string STORE_SAMSUNG;

		public static readonly string STORE_NOKIA;

		public static readonly string STORE_SKUBIT;

		public static readonly string STORE_SKUBIT_TEST;

		public static readonly string STORE_YANDEX;

		public static readonly string STORE_APPLAND;

		public static readonly string STORE_SLIDEME;

		public static readonly string STORE_APTOIDE;

		private static AndroidJavaObject _plugin;

		private IntPtr ConvertToStringJNIArray(string[] array)
		{
			return (IntPtr)0;
		}

		static OpenIAB_Android()
		{
		}

		private bool IsDevice()
		{
			return false;
		}

		private AndroidJavaObject CreateJavaHashMap(Dictionary<string, string> storeKeys)
		{
			return null;
		}

		public void init(Options options)
		{
		}

		public void init(Dictionary<string, string> storeKeys = null)
		{
		}

		public void mapSku(string sku, string storeName, string storeSku)
		{
		}

		public void unbindService()
		{
		}

		public bool areSubscriptionsSupported()
		{
			return false;
		}

		public void queryInventory()
		{
		}

		public void queryInventory(string[] skus)
		{
		}

		private void queryInventory(string[] inAppSkus, string[] subsSkus)
		{
		}

		public void purchaseProduct(string sku, string developerPayload = "")
		{
		}

		public void purchaseSubscription(string sku, string developerPayload = "")
		{
		}

		public void consumeProduct(Purchase purchase)
		{
		}

		public void restoreTransactions()
		{
		}

		public bool isDebugLog()
		{
			return false;
		}

		public void enableDebugLogging(bool enabled)
		{
		}

		public void enableDebugLogging(bool enabled, string tag)
		{
		}
	}
}
