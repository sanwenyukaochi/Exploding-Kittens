using System;
using System.Collections.Generic;
using Uniject;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;
using UnityEngine.Purchasing.Telemetry;

namespace UnityEngine.Purchasing
{
	internal class ProductDetailsResponseConsolidator : IProductDetailsResponseConsolidator
	{
		private int m_NumberReceivedCallbacks;

		private readonly Action<IProductDetailsQueryResponse> m_OnProductDetailsResponseConsolidated;

		private readonly IProductDetailsQueryResponse m_Responses;

		private readonly IUtil m_Util;

		private readonly ITelemetryDiagnostics m_TelemetryDiagnostics;

		internal ProductDetailsResponseConsolidator(IUtil util, ITelemetryDiagnostics telemetryDiagnostics, Action<IProductDetailsQueryResponse> onProductDetailsResponseConsolidated)
		{
		}

		public void Consolidate(IGoogleBillingResult billingResult, IEnumerable<AndroidJavaObject> productDetails)
		{
		}
	}
}
