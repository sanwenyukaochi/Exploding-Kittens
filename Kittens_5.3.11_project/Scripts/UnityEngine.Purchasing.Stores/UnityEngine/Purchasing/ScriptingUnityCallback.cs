using Uniject;

namespace UnityEngine.Purchasing
{
	internal class ScriptingUnityCallback : IUnityCallback
	{
		private readonly IUnityCallback forwardTo;

		private readonly IUtil util;

		public ScriptingUnityCallback(IUnityCallback forwardTo, IUtil util)
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
