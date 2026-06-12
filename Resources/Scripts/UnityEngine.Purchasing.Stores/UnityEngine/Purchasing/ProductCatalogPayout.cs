using System;

namespace UnityEngine.Purchasing
{
	[Serializable]
	public class ProductCatalogPayout
	{
		public enum ProductCatalogPayoutType
		{
			Other = 0,
			Currency = 1,
			Item = 2,
			Resource = 3
		}

		[SerializeField]
		private string t;

		[SerializeField]
		private string st;

		[SerializeField]
		private string d;
	}
}
