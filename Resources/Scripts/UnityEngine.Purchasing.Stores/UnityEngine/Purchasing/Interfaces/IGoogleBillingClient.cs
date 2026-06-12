using System;
using System.Collections.Generic;
using UnityEngine.Purchasing.Models;

namespace UnityEngine.Purchasing.Interfaces
{
	internal interface IGoogleBillingClient
	{
		void StartConnection(IBillingClientStateListener billingClientStateListener);

		GoogleBillingConnectionState GetConnectionState();

		void QueryPurchasesAsync(string skuType, Action<IGoogleBillingResult, IEnumerable<AndroidJavaObject>> onQueryPurchasesResponse);

		void QueryProductDetailsAsync(List<string> skus, string type, Action<IGoogleBillingResult, List<AndroidJavaObject>> onProductDetailsResponseAction);

		AndroidJavaObject LaunchBillingFlow(AndroidJavaObject productDetails, string oldPurchaseToken, GooglePlayReplacementMode? replacementMode);

		void ConsumeAsync(string purchaseToken, Action<IGoogleBillingResult> onConsume);

		void AcknowledgePurchase(string purchaseToken, Action<IGoogleBillingResult> onAcknowledge);
	}
}
