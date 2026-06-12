using System;
using UnityEngine;

public class GameSetup : MonoBehaviour
{
	public CardRepository CardRepository;

	public StartingHandDistributor StartingHandDistributor;

	public GameDeck GameDeck;

	public GameMessages GameMessages;

	public void Initialize(Action<Deck> onSetupComplete)
	{
	}
}
