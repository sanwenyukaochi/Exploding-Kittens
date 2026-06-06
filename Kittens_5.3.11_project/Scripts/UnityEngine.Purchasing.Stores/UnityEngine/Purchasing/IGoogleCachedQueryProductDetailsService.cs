using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	internal interface IGoogleCachedQueryProductDetailsService
	{
		IEnumerable<AndroidJavaObject> GetCachedQueriedProducts();

		IEnumerable<AndroidJavaObject> GetCachedQueriedProductDetails(IEnumerable<ProductDefinition> products);

		bool Contains(ProductDefinition products);

		void AddCachedQueriedProductDetails(IEnumerable<AndroidJavaObject> queriedProducts);
	}
}
