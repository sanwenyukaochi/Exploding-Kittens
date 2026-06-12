using UnityEngine;

public class OpponentExplodedEventHandler : MonoBehaviour
{
	public ModalQueue ModalQueue;

	public OpponentExplodedModal OpponentExplodedModal;

	public PlayerProvider PlayerProvider;

	public PlayerRepository PlayerRepository;

	public void Start()
	{
	}

	private void OnDeath(Player player)
	{
	}
}
