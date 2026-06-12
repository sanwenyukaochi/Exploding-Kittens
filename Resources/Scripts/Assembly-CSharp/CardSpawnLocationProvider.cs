using UnityEngine;

public class CardSpawnLocationProvider : MonoBehaviour
{
	public Transform[] InitialHandSpawnLocations;

	public Transform DrawnCardsSpawnLocation;

	private int cardsDealt;

	private Vector3? nextPosition;

	public Vector3 Next => default(Vector3);

	public void AddNextSpawnLocation(Vector3 point)
	{
	}
}
