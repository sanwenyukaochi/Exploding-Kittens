using System;
using System.Collections.Generic;
using Uniject;
using UnityEngine.Purchasing.Models;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class ProductDetailsResponseListener : AndroidJavaProxy
	{
		private const string k_AndroidProductDetailsResponseListenerClassName = "com.android.billingclient.api.ProductDetailsResponseListener";

		private readonly Action<IGoogleBillingResult, List<AndroidJavaObject>> m_OnProductDetailsResponse;

		private readonly IUtil m_Util;

		private readonly ITelemetryDiagnostics m_TelemetryDiagnostics;

		internal ProductDetailsResponseListener(Action<IGoogleBillingResult, List<AndroidJavaObject>> onProductDetailsResponseAction, IUtil util, ITelemetryDiagnostics telemetryDiagnostics)
			: base((string)null)
		{
		}

		[Preserve]
		public void onProductDetailsResponse(AndroidJavaObject billingResult, AndroidJavaObject? productDetails)
		{
		}
	}
}
