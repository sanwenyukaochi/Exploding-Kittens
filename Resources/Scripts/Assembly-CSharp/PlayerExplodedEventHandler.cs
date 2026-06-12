using UnityEngine;

public class PlayerExplodedEventHandler : MonoBehaviour
{
	public PlayerProvider PlayerProvider;

	public GameObject ExplodePrefab;

	public GameObject Container;

	public ModalQueue ModalQueue;

	private Player player => null;

	public void Start()
	{
	}

	private void OnDeath(Player _)
	{
	}
}
