using System;

namespace UnityEngine.Purchasing
{
	internal class FakeAppleExtensions : IAppleExtensions, IStoreExtension
	{
		public void RestoreTransactions(Action<bool, string?>? callback)
		{
		}
	}
}
