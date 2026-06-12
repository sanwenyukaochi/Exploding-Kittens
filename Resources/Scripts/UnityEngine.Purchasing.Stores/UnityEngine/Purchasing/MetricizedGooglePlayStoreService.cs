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
	internal class MetricizedGooglePlayStoreService : GooglePlayStoreService
	{
		private readonly ITelemetryMetricsService m_TelemetryMetricsService;

		private readonly ITelemetryDiagnostics m_TelemetryDiagnostics;

		internal MetricizedGooglePlayStoreService(IGoogleBillingClient billingClient, IQueryProductDetailsService queryProductDetailsService, IGooglePurchaseService purchaseService, IGoogleFinishTransactionService finishTransactionService, IGoogleQueryPurchasesService queryPurchasesService, IBillingClientStateListener billingClientStateListener, IGoogleLastKnownProductService lastKnownProductService, ITelemetryDiagnostics telemetryDiagnostics, ITelemetryMetricsService telemetryMetricsService, ILogger logger, IRetryPolicy retryPolicy, IUtil util)
			: base(null, null, null, null, null, null, null, null, null, null, null)
		{
		}

		protected override void DequeueQueryProducts(GoogleBillingResponseCode googleBillingResponseCode)
		{
		}

		protected override void DequeueFetchPurchases()
		{
		}

		public override void RetrieveProducts(ReadOnlyCollection<ProductDefinition> products, Action<List<ProductDescription>, IGoogleBillingResult> onProductsReceived, Action<GoogleRetrieveProductsFailureReason, GoogleBillingResponseCode> onRetrieveProductsFailed)
		{
		}

		public override void Purchase(ProductDefinition product, Product? oldProduct, GooglePlayReplacementMode? desiredReplacementMode)
		{
		}
	}
}
