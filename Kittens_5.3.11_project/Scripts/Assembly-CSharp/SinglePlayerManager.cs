using System.Collections.Generic;
using ExplodingKittensAI;
using UnityEngine;

public class SinglePlayerManager : MonoBehaviour
{
	public static SinglePlayerManager m;

	public EndTurnController EndTurnController;

	public TurnQueue TurnQueue;

	public GameDeck GameDeck;

	public PlayerHud[] PlayerHuds;

	public PlayerInterfaceRepository PlayerInterfaceRepository;

	public AIGameState m_AIGameState;

	public int DefuseKittenPlacement;

	public bool NewDifficultyUnlocked;

	public int m_NextCardDrawIndex;

	public bool m_PlayerCatbutted;

	public Card LastCardDiscarded;

	public UICamera UICameraObject;

	private List<CardAction> AIDeck;

	private List<CardAction> AIHand;

	private List<CardAction> PlayerHand;

	private List<CardAction> PlayerActions;

	private float PressedTimer;

	private void Awake()
	{
	}

	public void Setup()
	{
	}

	public void KittenPlacement(int index)
	{
	}

	public void AddCardAction(string name, string type)
	{
	}

	public void SetKittenLocation(int index)
	{
	}

	public void AddCardAction(Card card)
	{
	}

	public void UpdateCurrentDeck()
	{
	}

	public bool CheckAIHands()
	{
		return false;
	}

	public IList<CardAction> DoAI()
	{
		return null;
	}

	public void ClearPlayerActions()
	{
	}

	public IList<CardAction> DoAIGiveStealCard(bool shuffle)
	{
		return null;
	}

	public void DoPlayerGiveStealCard(Card card)
	{
	}

	public void UpdateAIDeck()
	{
	}

	private List<CardAction> GetAIDeck()
	{
		return null;
	}

	public void UpdateAIHand()
	{
	}

	private void UpdatePlayerHand()
	{
	}

	public string GetAICardType(CardCategory category)
	{
		return null;
	}

	public void AddRecord(bool win)
	{
	}

	public void SwapDeckCardPositions(int index1, int index2)
	{
	}

	public int GetTurnsRemaining()
	{
		return 0;
	}

	public Card GetTopCard()
	{
		return null;
	}

	public Card GetDeckCard(int index)
	{
		return null;
	}

	private void Update()
	{
	}
}
