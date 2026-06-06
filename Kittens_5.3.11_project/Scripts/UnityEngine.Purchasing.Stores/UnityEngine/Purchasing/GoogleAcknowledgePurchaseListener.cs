using System;
using UnityEngine.Purchasing.Models;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class GoogleAcknowledgePurchaseListener : AndroidJavaProxy
	{
		private const string k_AndroidAcknowledgePurchaseResponseListenerClassName = "com.android.billingclient.api.AcknowledgePurchaseResponseListener";

		private readonly Action<IGoogleBillingResult> m_OnAcknowledgePurchaseResponse;

		internal GoogleAcknowledgePurchaseListener(Action<IGoogleBillingResult> onAcknowledgePurchaseResponseAction)
			: base((string)null)
		{
		}

		[Preserve]
		private void onAcknowledgePurchaseResponse(AndroidJavaObject billingResult)
		{
		}
	}
}
