using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing.Models
{
	internal class ProductDescriptionQuery
	{
		internal ReadOnlyCollection<ProductDefinition> products;

		internal Action<List<ProductDescription>, IGoogleBillingResult> onProductsReceived;

		internal Action<GoogleRetrieveProductsFailureReason, GoogleBillingResponseCode> onRetrieveProductsFailed;

		internal ProductDescriptionQuery(ReadOnlyCollection<ProductDefinition> products, Action<List<ProductDescription>, IGoogleBillingResult> onProductsReceived, Action<GoogleRetrieveProductsFailureReason, GoogleBillingResponseCode> onRetrieveProductsFailed)
		{
		}
	}
}
