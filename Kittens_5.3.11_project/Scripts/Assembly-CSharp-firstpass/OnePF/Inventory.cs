using System.Collections.Generic;

namespace OnePF
{
	public class Inventory
	{
		private Dictionary<string, SkuDetails> _skuMap;

		private Dictionary<string, Purchase> _purchaseMap;

		public Inventory(string json)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public SkuDetails GetSkuDetails(string sku)
		{
			return null;
		}

		public Purchase GetPurchase(string sku)
		{
			return null;
		}

		public bool HasPurchase(string sku)
		{
			return false;
		}

		public bool HasDetails(string sku)
		{
			return false;
		}

		public void ErasePurchase(string sku)
		{
		}

		public List<string> GetAllOwnedSkus()
		{
			return null;
		}

		public List<string> GetAllOwnedSkus(string itemType)
		{
			return null;
		}

		public List<Purchase> GetAllPurchases()
		{
			return null;
		}

		public List<SkuDetails> GetAllAvailableSkus()
		{
			return null;
		}

		public void AddSkuDetails(SkuDetails d)
		{
		}

		public void AddPurchase(Purchase p)
		{
		}
	}
}
