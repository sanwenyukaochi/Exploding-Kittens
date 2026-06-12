using UnityEngine;

public class AvatarTurnSelectionController : MonoBehaviour
{
	public PlayerProvider PlayerProvider;

	public PlayMakerFSM PlayMakerFsm;

	private Player player => null;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnStartTurn(Player player, int _)
	{
	}

	private void OnEndTurn(Player player)
	{
	}
}
