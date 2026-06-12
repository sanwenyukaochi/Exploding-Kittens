using UnityEngine;

public class OpponentDefusableKittenController : MonoBehaviour
{
	public PlayerProvider PlayerProvider;

	public GameObject Kitten;

	public Texture ExplodingKitten;

	public Texture BarkingKitten;

	private Player player => null;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnPlayCard(Player player, Card card)
	{
	}

	private void OnDisconnect(Player player)
	{
	}

	private void OnDeath(Player player)
	{
	}

	private void OnDrawExplodingKitten(Player _, Card card)
	{
	}
}
