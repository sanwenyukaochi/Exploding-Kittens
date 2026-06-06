using UnityEngine;

public class OpponentDiscardController : MonoBehaviour
{
	public Vector3 InitialCardScale;

	public PlayerProvider PlayerProvider;

	public DiscardPileProvider DiscardPileProvider;

	private Player player => null;

	private DiscardPile DiscardPile => null;

	public void Start()
	{
	}

	private void DiscardCardWithTooltip(Player player, Card card)
	{
	}

	private void DiscardCardBlind(Player player, Card card)
	{
	}
}
