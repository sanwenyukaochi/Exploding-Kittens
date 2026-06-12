using UnityEngine;

public class InventoryAvatar : MonoBehaviour
{
	public UISprite AvatarSprite;

	public PlayMakerFSM IconFsm;

	public PlayMakerFSM SelectionFSM;

	public AvatarPackEvent OnPurchaseRequested;

	public PlayerAvatar PlayerAvatar;

	public UILabel NameLabel;

	public bool IsLocked;

	private AvatarPack avatarPack;

	public void Initialize(PlayerAvatar playerAvatar, AvatarPack avatarPack)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Remove()
	{
	}

	private void Refresh()
	{
	}

	private void Lock()
	{
	}

	private void Unlock()
	{
	}

	private void Select()
	{
	}

	private void Deselect()
	{
	}

	public void TapAvatar()
	{
	}

	private void OnSavePurchaseItem(string sku)
	{
	}

	private void OnFeatureSeen(string sku)
	{
	}

	private void OnPlayerAvatarChanged(PlayerAvatar avatar)
	{
	}
}
