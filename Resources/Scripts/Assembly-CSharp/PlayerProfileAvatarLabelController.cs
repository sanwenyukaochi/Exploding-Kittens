using UnityEngine;

public class PlayerProfileAvatarLabelController : MonoBehaviour
{
	public UILabel Label;

	private PlayerProfileSettings PlayerProfileSettings => null;

	private Color AvatarOutlineColor => default(Color);

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnPlayerAvatarChanged(PlayerAvatar playerAvatar)
	{
	}

	private void RefreshColor()
	{
	}
}
