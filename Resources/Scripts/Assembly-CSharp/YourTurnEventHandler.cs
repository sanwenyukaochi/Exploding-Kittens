using UnityEngine;

public class YourTurnEventHandler : MonoBehaviour
{
	public ModalQueue ModalQueue;

	public YourTurnModal YourTurnModal;

	public PlayerProvider PlayerProvider;

	public void Start()
	{
	}

	private void OnStartTurn(Player player, int _)
	{
	}
}
