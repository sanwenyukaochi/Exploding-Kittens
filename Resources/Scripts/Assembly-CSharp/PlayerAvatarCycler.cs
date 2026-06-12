using UnityEngine;

public class PlayerAvatarCycler : MonoBehaviour
{
	public PlayerAvatarRepository PlayerAvatarRepository;

	private int currentIndex;

	public PlayerAvatar Next => null;

	private int Index
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public PlayerAvatar[] Avatars => null;

	public void Reset(int index)
	{
	}
}
