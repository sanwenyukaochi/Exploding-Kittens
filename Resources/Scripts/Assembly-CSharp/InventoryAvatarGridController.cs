using System.Collections.Generic;
using System.Linq;

public class InventoryAvatarGridController : WindowController
{
	public NavigationController NavigationController;

	public GridController GridController;

	public InventoryAvatarFactory InventoryAvatarFactory;

	public PlayerAvatarRepository PlayerAvatarRepository;

	public AvatarPackRepository AvatarPackRepository;

	public PurchaseAvatarModal PurchaseAvatarModal;

	public MessageBoxModal MessageBoxModal;

	private Dictionary<PlayerAvatar, InventoryAvatar> inventoryAvatars;

	private IOrderedEnumerable<PlayerAvatar> SortedAvatars => null;

	public override void OnLoad()
	{
	}

	public override void OnUnload()
	{
	}

	private void CreateAvatars()
	{
	}

	private void RemoveAvatars()
	{
	}

	private void OnPurchaseRequested(AvatarPack avatarPack)
	{
	}

	private void ShowPurchaseModal(AvatarPack avatarPack)
	{
	}

	private void ShowBillingErrorModal()
	{
	}

	private void OnPurchaseModalSucceeded(AvatarPack avatarPack)
	{
	}

	private void OnAvatarPackAlreadyOwned(AvatarPack avatarPack)
	{
	}

	private void ShowDialog(DialogId dialogId)
	{
	}

	private void OnPurchaseModalCancelled()
	{
	}
}
