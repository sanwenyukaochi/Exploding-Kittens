using System;
using System.Collections.Generic;
using Uniject;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Telemetry;

namespace UnityEngine.Purchasing.Models
{
	internal class GoogleBillingClient : IGoogleBillingClient
	{
		private static AndroidJavaClass s_AndroidProductClassName;

		private static AndroidJavaClass s_AndroidQueryProductDetailsParamsClassName;

		private static AndroidJavaClass s_BillingFlowParamsClass;

		private static AndroidJavaClass s_ProductDetailsParamsClass;

		private static AndroidJavaClass s_SubscriptionUpdateParamsClass;

		private static AndroidJavaClass s_ConsumeParamsClass;

		private static AndroidJavaClass s_AcknowledgePurchaseParamsClass;

		private static AndroidJavaClass s_BillingClientClass;

		private readonly AndroidJavaObject m_BillingClient;

		private string m_ObfuscatedAccountId;

		private string m_ObfuscatedProfileId;

		private readonly IUtil m_Util;

		private readonly ITelemetryDiagnostics m_TelemetryDiagnostics;

		private static AndroidJavaClass GetProductParamsClass()
		{
			return null;
		}

		private static AndroidJavaClass GetQueryProductDetailsParamsParamsClass()
		{
			return null;
		}

		private static AndroidJavaClass GetBillingFlowParamClass()
		{
			return null;
		}

		private static AndroidJavaClass GetProductDetailsParamsClass()
		{
			return null;
		}

		private static AndroidJavaClass GetSubscriptionUpdateParamClass()
		{
			return null;
		}

		private static AndroidJavaClass GetConsumeParamsClass()
		{
			return null;
		}

		private static AndroidJavaClass GetAcknowledgePurchaseParamsClass()
		{
			return null;
		}

		private static AndroidJavaClass GetBillingClientClass()
		{
			return null;
		}

		internal GoogleBillingClient(IGooglePurchaseUpdatedListener googlePurchaseUpdatedListener, IUtil util, ITelemetryDiagnostics telemetryDiagnostics)
		{
		}

		public void StartConnection(IBillingClientStateListener billingClientStateListener)
		{
		}

		public GoogleBillingConnectionState GetConnectionState()
		{
			return default(GoogleBillingConnectionState);
		}

		public void QueryPurchasesAsync(string skuType, Action<IGoogleBillingResult, IEnumerable<AndroidJavaObject>> onQueryPurchasesResponse)
		{
		}

		public void QueryProductDetailsAsync(List<string> products, string type, Action<IGoogleBillingResult, List<AndroidJavaObject>> onProductDetailsResponseAction)
		{
		}

		private static AndroidJavaObject QueryProductDetailsParams(List<string> products, string type)
		{
			return null;
		}

		private static AndroidJavaObject QueryProductDetailsParamsProductList(List<string> products, string type)
		{
			return null;
		}

		private static AndroidJavaObject QueryProductDetailsParamsProduct(string type, string product)
		{
			return null;
		}

		public AndroidJavaObject LaunchBillingFlow(AndroidJavaObject productDetails, string oldPurchaseToken, GooglePlayReplacementMode? replacementMode)
		{
			return null;
		}

		private AndroidJavaObject MakeBillingFlowParams(AndroidJavaObject productDetailsParamsList, string oldPurchaseToken, GooglePlayReplacementMode? replacementMode)
		{
			return null;
		}

		private static AndroidJavaObject BuildSubscriptionUpdateParams(string oldPurchaseToken, GooglePlayReplacementMode replacementMode)
		{
			return null;
		}

		private AndroidJavaObject SetObfuscatedProfileIdIfNeeded(AndroidJavaObject billingFlowParams)
		{
			return null;
		}

		private AndroidJavaObject SetObfuscatedAccountIdIfNeeded(AndroidJavaObject billingFlowParams)
		{
			return null;
		}

		public void ConsumeAsync(string purchaseToken, Action<IGoogleBillingResult> onConsume)
		{
		}

		public void AcknowledgePurchase(string purchaseToken, Action<IGoogleBillingResult> onAcknowledge)
		{
		}
	}
}
