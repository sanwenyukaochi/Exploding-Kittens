namespace UnityEngine.Purchasing
{
	public class FakeGooglePlayStoreExtensions : IGooglePlayStoreExtensions, IStoreExtension
	{
		public bool IsPurchasedProductDeferred(Product product)
		{
			return false;
		}
	}
}
