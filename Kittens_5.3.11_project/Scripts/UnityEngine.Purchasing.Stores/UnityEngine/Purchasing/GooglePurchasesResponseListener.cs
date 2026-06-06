using System;
using System.Collections.Generic;
using UnityEngine.Purchasing.Models;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class GooglePurchasesResponseListener : AndroidJavaProxy
	{
		private const string k_AndroidPurchasesResponseListenerClassName = "com.android.billingclient.api.PurchasesResponseListener";

		private readonly Action<IGoogleBillingResult, IEnumerable<AndroidJavaObject>> m_OnQueryPurchasesResponse;

		internal GooglePurchasesResponseListener(Action<IGoogleBillingResult, IEnumerable<AndroidJavaObject>> onQueryPurchasesResponse)
			: base((string)null)
		{
		}

		[Preserve]
		public void onQueryPurchasesResponse(AndroidJavaObject billingResult, AndroidJavaObject purchases)
		{
		}
	}
}
