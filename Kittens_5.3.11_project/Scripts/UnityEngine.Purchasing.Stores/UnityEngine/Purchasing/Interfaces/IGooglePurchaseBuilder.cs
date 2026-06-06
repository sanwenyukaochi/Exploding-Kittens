using System.Collections.Generic;

namespace UnityEngine.Purchasing.Interfaces
{
	internal interface IGooglePurchaseBuilder
	{
		IEnumerable<IGooglePurchase> BuildPurchases(IEnumerable<AndroidJavaObject> purchases);

		IGooglePurchase BuildPurchase(AndroidJavaObject purchase);
	}
}
