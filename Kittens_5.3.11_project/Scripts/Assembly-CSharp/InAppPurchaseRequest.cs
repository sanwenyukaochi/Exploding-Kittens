using OnePF;

public class InAppPurchaseRequest
{
	public GenericEvent OnPurchaseSucceeded;

	public GenericEvent OnPurchasedItemAlreadyOwned;

	public GenericEvent OnPurchaseFailed;

	public string sku;

	private const string TRANSACTION_CANCELLED_REASON = "Transaction cancelled";

	private const int GOOGLE_PLAY_ITEM_ALREADY_OWNED_ERROR_CODE = 7;

	public InAppPurchaseRequest(string sku)
	{
	}

	public void Execute()
	{
	}

	private void RegisterForPurchaseEvents()
	{
	}

	private void DeregisterForPurchaseEvents()
	{
	}

	private void PurchaseSucceeded(Purchase purchase)
	{
	}

	private void PurchaseFailed(int code, string reason)
	{
	}

	private void DispatchPurchaseCallback(GenericEvent callback)
	{
	}
}
