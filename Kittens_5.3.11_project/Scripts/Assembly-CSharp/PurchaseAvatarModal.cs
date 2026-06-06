using UnityEngine;

public class PurchaseAvatarModal : MonoBehaviour
{
	private const string TRANSACTION_CANCELLED_REASON = "Transaction cancelled";

	private const int GOOGLE_PLAY_ITEM_ALREADY_OWNED_ERROR_CODE = 7;

	public WindowTransitioner WindowTransitioner;

	public UILabel HeaderLabel;

	public UILabel AvatarCountLabel;

	public UILabel PurchaseButtonLabel;

	public UISprite AvatarPackPreviewSprite;

	public PlayerAvatarRepository PlayerAvatarRepository;

	public AvatarPackRepository AvatarPackRepository;

	public AvatarPackPurchaseEvent OnAvatarPackPurchased;

	public AvatarPackPurchaseEvent OnAvatarPackAlreadyOwned;

	public GenericEvent OnCancelled;

	public SpinnyButton PurchaseAvatarPackSpinnyButton;

	public MessageBoxModal MessageBoxModal;

	public InAppPurchaseController InAppPurchaseController;

	private AvatarPack avatarPack;

	public void Initialize(AvatarPack avatarPack)
	{
	}

	public string AvatarCountStringForPack(AvatarPack avatarPack)
	{
		return null;
	}

	public void OnPurchaseAvatarClicked()
	{
	}

	private void OnPurchaseSucceeded()
	{
	}

	private void OnPurchasedItemAlreadyOwned()
	{
	}

	private void OnPurchaseFailed()
	{
	}

	private void CompletePurchase(AvatarPackPurchaseEvent onPurchaseCompleted)
	{
	}

	public void CancelModal()
	{
	}
}
