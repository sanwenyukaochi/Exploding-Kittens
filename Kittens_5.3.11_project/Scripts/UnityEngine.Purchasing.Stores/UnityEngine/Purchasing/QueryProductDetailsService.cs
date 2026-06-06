using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Uniject;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;
using UnityEngine.Purchasing.Stores.Util;
using UnityEngine.Purchasing.Telemetry;

namespace UnityEngine.Purchasing
{
	internal class QueryProductDetailsService : IQueryProductDetailsService
	{
		private readonly IGoogleBillingClient m_BillingClient;

		private readonly IGoogleCachedQueryProductDetailsService m_GoogleCachedQueryProductDetailsService;

		private readonly IProductDetailsConverter m_ProductDetailsConverter;

		private readonly IRetryPolicy m_RetryPolicy;

		private readonly IGoogleProductCallback m_GoogleProductCallback;

		private readonly IUtil m_Util;

		private readonly ITelemetryDiagnostics m_TelemetryDiagnostics;

		internal QueryProductDetailsService(IGoogleBillingClient billingClient, IGoogleCachedQueryProductDetailsService googleCachedQueryProductDetailsService, IProductDetailsConverter productDetailsConverter, IRetryPolicy retryPolicy, IGoogleProductCallback googleProductCallback, IUtil util, ITelemetryDiagnostics telemetryDiagnostics)
		{
		}

		public void QueryAsyncProduct(ProductDefinition product, Action<List<AndroidJavaObject>, IGoogleBillingResult> onProductDetailsResponse)
		{
		}

		public void QueryAsyncProduct(ReadOnlyCollection<ProductDefinition> products, Action<List<ProductDescription>, IGoogleBillingResult> onProductDetailsResponse)
		{
		}

		public void QueryAsyncProduct(ReadOnlyCollection<ProductDefinition> products, Action<List<AndroidJavaObject>, IGoogleBillingResult> onProductDetailsResponse)
		{
		}

		private void QueryAsyncProductWithRetries(IReadOnlyCollection<ProductDefinition> products, Action<List<AndroidJavaObject>, IGoogleBillingResult> onProductDetailsResponse, Action retryQuery)
		{
		}

		private void TryQueryAsyncProductWithRetries(IReadOnlyCollection<ProductDefinition> products, Action<List<AndroidJavaObject>, IGoogleBillingResult> onProductDetailsResponse, Action retryQuery)
		{
		}

		private bool ShouldRetryQuery(IEnumerable<ProductDefinition> requestedProducts, IProductDetailsQueryResponse queryResponse)
		{
			return false;
		}

		private bool AreAllProductDetailsCached(IEnumerable<ProductDefinition> products)
		{
			return false;
		}

		private IEnumerable<AndroidJavaObject> GetCachedProductDetails(IEnumerable<ProductDefinition> products)
		{
			return null;
		}

		private void QueryInAppsAsync(IEnumerable<ProductDefinition> products, IProductDetailsResponseConsolidator consolidator)
		{
		}

		private void QuerySubsAsync(IEnumerable<ProductDefinition> products, IProductDetailsResponseConsolidator consolidator)
		{
		}

		private void QueryProductDetails(List<string> productList, string type, IProductDetailsResponseConsolidator consolidator)
		{
		}
	}
}
