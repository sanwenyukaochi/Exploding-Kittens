using System;
using UnityEngine.Purchasing.Models;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class GoogleConsumeResponseListener : AndroidJavaProxy
	{
		private const string k_AndroidConsumeResponseListenerClassName = "com.android.billingclient.api.ConsumeResponseListener";

		private readonly Action<IGoogleBillingResult> m_OnConsumeResponse;

		internal GoogleConsumeResponseListener(Action<IGoogleBillingResult> onConsumeResponseAction)
			: base((string)null)
		{
		}

		[Preserve]
		private void onConsumeResponse(AndroidJavaObject billingResult, string purchaseToken)
		{
		}
	}
}
