using System;
using UnityEngine.Purchasing.Stores.Util;

namespace UnityEngine.Purchasing
{
	internal class GoogleConnectionRetryPolicy : IRetryPolicy
	{
		private readonly int m_BaseRetryDelay;

		private readonly int m_MaxRetryDelay;

		private readonly int m_ExponentialFactor;

		public GoogleConnectionRetryPolicy(int baseRetryDelay = 2000, int maxRetryDelay = 30000, int exponentialFactor = 2)
		{
		}

		public void Invoke(Action<Action> actionToTry, Action? onRetryAction)
		{
		}

		private int AdjustDelay(int delay)
		{
			return 0;
		}
	}
}
