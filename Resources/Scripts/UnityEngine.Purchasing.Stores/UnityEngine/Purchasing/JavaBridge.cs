namespace UnityEngine.Purchasing
{
	internal class JavaBridge : AndroidJavaProxy, IUnityCallback
	{
		private readonly IUnityCallback forwardTo;

		public JavaBridge(IUnityCallback forwardTo)
			: base((string)null)
		{
		}

		public JavaBridge(IUnityCallback forwardTo, string javaInterface)
			: base((string)null)
		{
		}

		public void OnSetupFailed(string json)
		{
		}

		public void OnProductsRetrieved(string json)
		{
		}

		public void OnPurchaseSucceeded(string id, string receipt, string transactionID)
		{
		}

		public void OnPurchaseFailed(string json)
		{
		}
	}
}
