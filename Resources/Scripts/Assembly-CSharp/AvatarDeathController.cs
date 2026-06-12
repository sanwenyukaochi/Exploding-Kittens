using UnityEngine;

public class AvatarDeathController : MonoBehaviour
{
	public PlayerProvider PlayerProvider;

	public PlayMakerFSM DeathFsm;

	private Player player => null;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnPlayerDeath(Player player)
	{
	}

	private void OnPlayerDisconnect(Player _)
	{
	}
}
