using System;
using System.Collections.Generic;

public class Deck
{
	public List<Card> Cards;

	public DeckEvent OnChange;

	public List<string> CardIds => null;

	public List<Card> Bombs => null;

	public Card TopCard => null;

	public Card RandomCard => null;

	public bool IsDeckEmpty => false;

	public int Count => 0;

	public Deck()
	{
	}

	public Deck(List<Card> cards)
	{
	}

	public int IndexOfCard(Card card)
	{
		return 0;
	}

	public List<Card> Top(int n)
	{
		return null;
	}

	public void ClearPlacingPlayers()
	{
	}

	public void Truncate(int count)
	{
	}

	public void RemoveTopCard(CardCategory category)
	{
	}

	public Card Draw()
	{
		return null;
	}

	public Card DrawFromBottom()
	{
		return null;
	}

	public void NotifyChange()
	{
	}

	public List<Card> FindAllCardsInCategory(CardCategory category)
	{
		return null;
	}

	public int NumberOfCardsInCategory(CardCategory category)
	{
		return 0;
	}

	public void Shuffle()
	{
	}

	public void OrderByDescending(Func<Card, IComparable> comparator)
	{
	}

	public void Add(Deck other)
	{
	}

	public void Add(Card card)
	{
	}

	public void Insert(int index, Card card)
	{
	}

	public void Replace(Deck deck)
	{
	}

	public void MoveCardsToTop(List<Card> topCards)
	{
	}

	public void Remove(Card card)
	{
	}

	public void Swap(int index1, int index2)
	{
	}
}
