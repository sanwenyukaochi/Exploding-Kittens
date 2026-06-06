using System.Collections.Generic;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;

namespace UnityEngine.Purchasing
{
	internal class GooglePurchaseService : IGooglePurchaseService
	{
		private readonly IGoogleBillingClient m_BillingClient;

		private readonly IGooglePurchaseCallback m_GooglePurchaseCallback;

		private readonly IQueryProductDetailsService m_QueryProductDetailsService;

		internal GooglePurchaseService(IGoogleBillingClient billingClient, IGooglePurchaseCallback googlePurchaseCallback, IQueryProductDetailsService queryProductDetailsService)
		{
		}

		public void Purchase(ProductDefinition product, Product? oldProduct, GooglePlayReplacementMode? desiredProrationMode)
		{
		}

		private void OnQueryProductDetailsResponse(List<AndroidJavaObject> productDetailsList, ProductDefinition productToBuy, Product? oldProduct, GooglePlayReplacementMode? desiredProrationMode)
		{
		}

		private bool ValidateQueryProductDetailsResponseParams(List<AndroidJavaObject> skus, ProductDefinition productToBuy, Product? oldProduct)
		{
			return false;
		}

		private bool ValidateSkus(List<AndroidJavaObject>? skus)
		{
			return false;
		}

		private static void VerifyAndWarnIfMoreThanOneSku(List<AndroidJavaObject>? skus)
		{
		}

		private void PurchaseFailedSkuNotFound(ProductDefinition productToBuy)
		{
		}

		private bool ValidateOldProduct(Product? oldProduct)
		{
			return false;
		}

		private void PurchaseFailedInvalidOldProduct(ProductDefinition productToBuy, Product? oldProduct)
		{
		}

		private void LaunchGoogleBillingFlow(AndroidJavaObject productToPurchase, Product? oldProduct, GooglePlayReplacementMode? desiredProrationMode)
		{
		}

		private void HandleBillingFlowResult(IGoogleBillingResult billingResult, AndroidJavaObject sku)
		{
		}
	}
}
