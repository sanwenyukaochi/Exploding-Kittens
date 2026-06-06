using UnityEngine;

public class PlayerAvatarLabelController : MonoBehaviour
{
	public PlayerProvider PlayerProvider;

	public UILabel Label;

	private Player Player => null;

	private Color AvatarOutlineColor => default(Color);

	private void Start()
	{
	}
}
