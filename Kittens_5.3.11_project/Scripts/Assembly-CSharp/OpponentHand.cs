using System.Collections.Generic;
using UnityEngine;

public class OpponentHand : MonoBehaviour
{
	public GameObject Hand;

	public GameObject CardBackPrefab;

	public int StartDepth;

	public Vector2 DesiredCardSize;

	public CardBackFactory CardBackFactory;

	public PlayerProvider PlayerProvider;

	public DrawPileProvider DrawPileProvider;

	private List<CardBack> cardBacks;

	private const int CARD_COMPRESSION_THRESHOLD = 6;

	private const float INITIAL_CARD_SPACING = 20f;

	private const float HAND_SLOPE = 1.3f;

	private const float ROTATION_SLOPE = 2f;

	private float CardSpacing => 0f;

	private Player player => null;

	private DrawPile drawPile => null;

	public void Start()
	{
	}

	public void OnReceiveCardFromPlayer(Player player, Player otherPlayer, Card card)
	{
	}

	public void OnDrawCard(Player player, Card card)
	{
	}

	public void OnRemoveCard(Player player, Card card)
	{
	}

	private void Reposition(bool instant = false)
	{
	}
}
