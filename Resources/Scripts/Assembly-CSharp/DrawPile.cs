using System.Collections.Generic;
using UnityEngine;

public class DrawPile : MonoBehaviour
{
	public GameDeck GameDeck;

	public CardBackFactory CardBackFactory;

	public UILabel CardsLeftLabel;

	public PlayerProvider PlayerProvider;

	public PlayMakerFSM DrawCardHintFSM;

	public List<CardBack> cardBacks;

	public CardStackPositionCalculator CardStackPositionCalculator;

	private float PressedTimer;

	public CardBack TopCard => null;

	public bool HasCardsRemaining => false;

	private Deck Deck => null;

	public void Start()
	{
	}

	public CardBack DrawFromTop()
	{
		return null;
	}

	public CardBack DrawFromBottom()
	{
		return null;
	}

	public void Remove(CardBack cardBack)
	{
	}

	private void OnPlayerPhaseChange(Player player, PlayerPhase phase)
	{
	}

	private void OnDeckChange(Deck _)
	{
	}

	private void OnCardBackTapped(CardBack _)
	{
	}

	private void UpdateCardsLeftLabel()
	{
	}

	private void UpdateCardDepths()
	{
	}

	private void Update()
	{
	}
}
