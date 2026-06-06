using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Security;
using UnityEngine.Purchasing.Telemetry;

namespace UnityEngine.Purchasing
{
	internal class GooglePlayStoreExtensions : IGooglePlayStoreExtensions, IStoreExtension, IGooglePlayStoreExtensionsInternal
	{
		private readonly IGooglePlayStoreService m_GooglePlayStoreService;

		private readonly IGooglePurchaseStateEnumProvider m_GooglePurchaseStateEnumProvider;

		private readonly ITelemetryDiagnostics m_TelemetryDiagnostics;

		private readonly ILogger m_Logger;

		private IStoreCallback? m_StoreCallback;

		internal GooglePlayStoreExtensions(IGooglePlayStoreService googlePlayStoreService, IGooglePurchaseStateEnumProvider googlePurchaseStateEnumProvider, ILogger logger, ITelemetryDiagnostics telemetryDiagnostics)
		{
		}

		public void SetStoreCallback(IStoreCallback storeCallback)
		{
		}

		public bool IsPurchasedProductDeferred(Product product)
		{
			return false;
		}

		private bool TryIsPurchasedProductDeferred(Product product)
		{
			return false;
		}

		public GooglePurchaseState GetPurchaseState(Product product)
		{
			return default(GooglePurchaseState);
		}

		private IGooglePurchase GooglePurchaseFromProduct(Product product)
		{
			return null;
		}
	}
}
