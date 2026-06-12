using System;
using UnityEngine;

public class StartingHandDistributor : MonoBehaviour
{
	private int CARDS_IN_STARTING_HAND;

	public GameMessages GameMessages;

	public TurnQueue TurnQueue;

	private Deck defuseDeck;

	private Deck gameDeck;

	public void Initialize(Deck defuseDeck, Deck gameDeck)
	{
	}

	public void Deal(Action<Deck> onComplete)
	{
	}

	private void SendCardToPlayers(Func<Card> cardProvider)
	{
	}
}
