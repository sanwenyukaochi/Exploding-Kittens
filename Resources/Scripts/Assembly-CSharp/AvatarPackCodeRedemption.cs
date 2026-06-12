using UnityEngine;

public class AvatarPackCodeRedemption : MonoBehaviour
{
	public GameObject UiMain;

	public GameObject UiAvatarPack;

	public EnterCodeInputController EnterCodeInput;

	public MessageBoxModal MessageBox;

	public AvatarPackType AvatarPackToRedeem;

	public AvatarPackRepository AvatarPackRepository;

	public PlayerAvatarRepository PlayerAvatarRepository;

	public UILabel HeaderLabel;

	public UILabel AvatarCountLabel;

	public UISprite AvatarPackPreviewSprite;

	private AvatarPack AvatarPack;

	private void Start()
	{
	}

	private void OnCodeVerified(bool isValid)
	{
	}

	public void OnMessageBoxComplete()
	{
	}

	private void DisplayAvatarPack()
	{
	}

	public string AvatarCountStringForPack(AvatarPack avatarPack)
	{
		return null;
	}
}
