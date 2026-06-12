using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine.Analytics
{
	[StructLayout((LayoutKind)0)]
	[NativeHeader("Modules/UnityAnalytics/Public/UnityAnalytics.h")]
	[NativeHeader("Modules/UnityConnect/UnityConnectSettings.h")]
	[NativeHeader("Modules/UnityAnalytics/Public/Events/UserCustomEvent.h")]
	public static class Analytics
	{
		[ThreadSafe]
		internal static bool IsInitialized()
		{
			return false;
		}

		[StaticAccessor("GetUnityAnalytics()", StaticAccessorType.Dot)]
		private static AnalyticsResult Transaction(string productId, double amount, string currency, string receiptPurchaseData, string signature, bool usingIAPService)
		{
			return default(AnalyticsResult);
		}

		[StaticAccessor("GetUnityAnalytics()", StaticAccessorType.Dot)]
		private static AnalyticsResult SendCustomEventName(string customEventName)
		{
			return default(AnalyticsResult);
		}

		[StaticAccessor("GetUnityAnalytics()", StaticAccessorType.Dot)]
		private static AnalyticsResult SendCustomEvent(CustomEventData eventData)
		{
			return default(AnalyticsResult);
		}

		public static AnalyticsResult Transaction(string productId, decimal amount, string currency, string receiptPurchaseData, string signature)
		{
			return default(AnalyticsResult);
		}

		public static AnalyticsResult Transaction(string productId, decimal amount, string currency, string receiptPurchaseData, string signature, bool usingIAPService)
		{
			return default(AnalyticsResult);
		}

		public static AnalyticsResult CustomEvent(string customEventName, IDictionary<string, object> eventData)
		{
			return default(AnalyticsResult);
		}
	}
}
