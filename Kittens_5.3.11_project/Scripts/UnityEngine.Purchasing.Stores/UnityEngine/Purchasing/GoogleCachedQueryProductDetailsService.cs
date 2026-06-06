using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	internal class GoogleCachedQueryProductDetailsService : IGoogleCachedQueryProductDetailsService
	{
		private readonly Dictionary<string, AndroidJavaObject> m_CachedQueriedProductDetails;

		~GoogleCachedQueryProductDetailsService()
		{
		}

		public IEnumerable<AndroidJavaObject> GetCachedQueriedProducts()
		{
			return null;
		}

		private AndroidJavaObject GetCachedQueriedProductDetails(string productId)
		{
			return null;
		}

		private IEnumerable<AndroidJavaObject> GetCachedQueriedProductDetails(IEnumerable<string> productIds)
		{
			return null;
		}

		public IEnumerable<AndroidJavaObject> GetCachedQueriedProductDetails(IEnumerable<ProductDefinition> products)
		{
			return null;
		}

		private bool Contains(string productId)
		{
			return false;
		}

		public bool Contains(ProductDefinition products)
		{
			return false;
		}

		public void AddCachedQueriedProductDetails(IEnumerable<AndroidJavaObject> queriedProducts)
		{
		}
	}
}
