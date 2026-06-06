using UnityEngine;

public class IapButtonLabelUpdater : MonoBehaviour
{
	public UILabel ButtonLabel;

	public UISprite ButtonSprite;

	public Color ItemIsPurchasableButtonColor;

	public Color ItemIsOwnedButtonColor;

	public string PurchasedButtonText;

	public string NotAvailableButtonText;

	public string PurchaseModalText;

	private string sku;

	public bool RequiresPurchase;

	private bool HasSku => false;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Initialize(string sku)
	{
	}

	private void OnSavePurchaseItem(string sku)
	{
	}

	private void Update()
	{
	}

	private void UpdateLabel()
	{
	}
}
