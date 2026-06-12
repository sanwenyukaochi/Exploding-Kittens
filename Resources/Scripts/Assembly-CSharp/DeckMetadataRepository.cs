using System.Collections.Generic;
using UnityEngine;

public class DeckMetadataRepository : MonoBehaviour
{
	public List<DeckMetadata> DeckMetadatas;

	public static DeckMetadataRepository Instance;

	private void Awake()
	{
	}

	public DeckMetadata FindByDeckType(DeckType DeckType)
	{
		return null;
	}

	public DeckMetadata FindBySku(string sku)
	{
		return null;
	}
}
