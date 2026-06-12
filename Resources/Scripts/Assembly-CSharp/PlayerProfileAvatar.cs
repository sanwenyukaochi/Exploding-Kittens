using UnityEngine;

public class PlayerProfileAvatar : MonoBehaviour, IInitializable
{
	public UISprite AvatarSprite;

	public void Initialize()
	{
	}

	private void OnPlayerAvatarChanged(PlayerAvatar playerAvatar)
	{
	}
}
