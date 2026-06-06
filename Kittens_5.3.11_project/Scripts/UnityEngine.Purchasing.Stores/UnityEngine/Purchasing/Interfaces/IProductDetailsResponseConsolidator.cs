using System.Collections.Generic;
using UnityEngine.Purchasing.Models;

namespace UnityEngine.Purchasing.Interfaces
{
	internal interface IProductDetailsResponseConsolidator
	{
		void Consolidate(IGoogleBillingResult billingResult, IEnumerable<AndroidJavaObject> productDetails);
	}
}
