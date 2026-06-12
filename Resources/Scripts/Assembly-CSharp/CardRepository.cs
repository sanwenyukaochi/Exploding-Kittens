using System.Collections.Generic;
using UnityEngine;

public class CardRepository : MonoBehaviour
{
	public List<Card> Cards;

	public List<Card> DefuseCards => null;

	public List<Card> BombCards => null;

	public List<Card> StartingHandCards => null;

	public void Initialize(List<Card> cards)
	{
	}

	public Card FindById(string id)
	{
		return null;
	}

	public Card[] FindAllById(List<string> ids)
	{
		return null;
	}

	private List<Card> FindAllByCategory(CardCategory cardCategory)
	{
		return null;
	}

	public Card RandomCardOfCategory(CardCategory cardCategory)
	{
		return null;
	}
}
