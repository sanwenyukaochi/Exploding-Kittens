using System;
using System.Collections.Generic;
using UnityEngine.Purchasing.Interfaces;

namespace UnityEngine.Purchasing.Utils
{
	internal class GooglePurchaseBuilder : IGooglePurchaseBuilder
	{
		private readonly IGoogleCachedQueryProductDetailsService m_CachedQueryProductDetailsService;

		private readonly ILogger m_Logger;

		public GooglePurchaseBuilder(IGoogleCachedQueryProductDetailsService cachedQueryProductDetailsService, ILogger logger)
		{
		}

		public IEnumerable<IGooglePurchase> BuildPurchases(IEnumerable<AndroidJavaObject> purchases)
		{
			return null;
		}

		private void LogWarningForException(Exception exception)
		{
		}

		public IGooglePurchase BuildPurchase(AndroidJavaObject purchase)
		{
			return null;
		}

		private static IEnumerable<AndroidJavaObject> TryFindAllProductDetails(IEnumerable<string> skus, IEnumerable<AndroidJavaObject> productDetails)
		{
			return null;
		}
	}
}
