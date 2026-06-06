using UnityEngine;

public class DeckStats : MonoBehaviour
{
	public DeckStatsEvent OnChange;

	public GameDeck GameDeck;

	public int NumCardsRemaining => 0;

	public int NumKittensRemaining => 0;

	public float ExplodingChance => 0f;

	public float ExplodingChanceMin => 0f;

	public float ExplodingChanceMax => 0f;

	private Deck Deck => null;

	public void Initialize()
	{
	}

	public void OnDestroy()
	{
	}

	private void NotifyChange(Deck _)
	{
	}
}
