using UnityEngine;

public class OpenIabInitializer : MonoBehaviour
{
	private static bool IsInitialized;

	private static string GOOGLE_PLAY_STORE_PUBLIC_KEY;

	public PurchasableProductRepository PurchasableProductRepository;

	public IabEvent OnBillingInitialized;

	private bool OpenIabSupportedOnThisPlatform => false;

	private PurchasableProduct[] PurchasableProducts => null;

	public void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void RegisterEvents()
	{
	}

	private void InitSkus()
	{
	}

	private void InitializeOpenIab()
	{
	}

	private void OnBillingSupportedEvent()
	{
	}

	private void OnBillingNotSupportedEvent(string reason)
	{
	}
}
