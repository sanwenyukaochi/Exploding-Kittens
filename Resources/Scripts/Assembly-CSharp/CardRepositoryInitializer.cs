using UnityEngine;

public class CardRepositoryInitializer : MonoBehaviour
{
	public CardRepository CardRepository;

	public DeckMetadataRepository DeckMetadataRepository;

	public CardReader CardReader;

	private int NumPlayers => 0;

	private DeckMetadata DeckMetadata => null;

	public void Initialize()
	{
	}
}
