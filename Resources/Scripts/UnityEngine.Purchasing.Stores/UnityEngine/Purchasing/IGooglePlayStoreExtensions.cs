namespace UnityEngine.Purchasing
{
	public interface IGooglePlayStoreExtensions : IStoreExtension
	{
		bool IsPurchasedProductDeferred(Product product);
	}
}
