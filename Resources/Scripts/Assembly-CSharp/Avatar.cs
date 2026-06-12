using UnityEngine;

public class Avatar : MonoBehaviour
{
	public UISprite Sprite;

	public UILabel Label;

	public PlayMakerFSM DyingFsm;

	public PlayMakerFSM WinFsm;

	public PlayerProvider PlayerProvider;

	public Transform rematchStatusIconsParent;

	public Player player;

	public GameObject m_EmoteObject;

	public void Initialize(Player player)
	{
	}

	public void Remove()
	{
	}

	public void SmileForVictoryModal()
	{
	}

	public void Win()
	{
	}

	public void StartFire()
	{
	}

	public void SetRematchStatusIcon(RematchGamePlayerState rematchState)
	{
	}

	public void PlayEmote()
	{
	}
}
