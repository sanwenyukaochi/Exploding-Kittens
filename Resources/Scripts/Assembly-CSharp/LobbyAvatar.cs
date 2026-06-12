using UnityEngine;

public class LobbyAvatar : MonoBehaviour
{
	private Spinner spinner;

	public SpinnerFactory SpinnerFactory;

	[Header("Avatar")]
	public GameObject AvatarContainer;

	public UISprite AvatarSprite;

	public UILabel AvatarLabel;

	public void Initialize()
	{
	}

	public void Upgrade(Player player)
	{
	}

	private void OnPlayerAvatarChanged(Player _, PlayerAvatar playerAvatar)
	{
	}

	private void OnPlayerUsernameChanged(Player player)
	{
	}
}
