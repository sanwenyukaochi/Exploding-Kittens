using UnityEngine;

public class PlayerHandDropTarget : MonoBehaviour
{
	public PlayerProvider PlayerProvider;

	public NextDrawnCardProvider NextDrawnCardProvider;

	public GameMessages GameMessages;

	[SerializeField]
	private DrawPile drawPile;

	[SerializeField]
	private CardSpawnLocationProvider SpawnLocationProvider;

	private Player player => null;

	public void DropCard(CardBack cardBack)
	{
	}

	private Vector3 OffscreenTargetFor(CardBack cardBack)
	{
		return default(Vector3);
	}
}
