using System;

namespace UnityEngine.Purchasing
{
	public interface IAppleExtensions : IStoreExtension
	{
		void RestoreTransactions(Action<bool, string> callback);
	}
}
