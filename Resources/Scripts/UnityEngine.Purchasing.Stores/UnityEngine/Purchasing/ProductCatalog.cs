using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	[Serializable]
	public class ProductCatalog
	{
		private static IProductCatalogImpl instance;

		public bool enableCodelessAutoInitialization;

		[SerializeField]
		private List<ProductCatalogItem> products;

		public ICollection<ProductCatalogItem> allProducts => null;

		internal static void Initialize()
		{
		}

		public static void Initialize(IProductCatalogImpl productCatalogImpl)
		{
		}

		public static ProductCatalog Deserialize(string catalogJSON)
		{
			return null;
		}

		public static ProductCatalog FromTextAsset(TextAsset asset)
		{
			return null;
		}

		public static ProductCatalog LoadDefaultCatalog()
		{
			return null;
		}
	}
}
