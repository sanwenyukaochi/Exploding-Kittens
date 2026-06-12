using System;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class BillingClientStateListener : AndroidJavaProxy, IBillingClientStateListener
	{
		private const string k_AndroidBillingClientStateListenerClassName = "com.android.billingclient.api.BillingClientStateListener";

		private Action m_OnConnected;

		private Action<GoogleBillingResponseCode> m_Disconnect;

		internal BillingClientStateListener()
			: base((string)null)
		{
		}

		public void RegisterOnConnected(Action onConnected)
		{
		}

		public void RegisterOnDisconnected(Action<GoogleBillingResponseCode> onDisconnected)
		{
		}

		[Preserve]
		public void onBillingSetupFinished(AndroidJavaObject billingResult)
		{
		}

		[Preserve]
		public void onBillingServiceDisconnected()
		{
		}
	}
}
