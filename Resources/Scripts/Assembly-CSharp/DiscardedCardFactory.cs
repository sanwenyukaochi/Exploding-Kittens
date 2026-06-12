using UnityEngine;

public class DiscardedCardFactory : MonoBehaviour
{
	public GameObject Prefab;

	public GameObject DiscardPile;

	public CardRepository CardRepository;

	public int NextCardDepth => 0;

	public DiscardedCard Create(HandCard handCard)
	{
		return null;
	}

	public DiscardedCard Create(Card card, Vector3 position)
	{
		return null;
	}
}
