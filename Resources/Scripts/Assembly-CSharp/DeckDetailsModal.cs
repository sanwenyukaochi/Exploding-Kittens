using System.Collections.Generic;
using UnityEngine;

public class DeckDetailsModal : MonoBehaviour
{
	public WindowTransitioner WindowTransitioner;

	public GridController GridController;

	public DeckDetailsRowFactory DeckDetailsRowFactory;

	public CategoryMetadataRepository CategoryMetadataRepository;

	public GameObject InfoButton;

	private List<GameObject> glist;

	public void Show(DeckMetadata deckMetadata)
	{
	}

	public void Hide()
	{
	}

	private void CreateRows(DeckMetadata deckMetadata)
	{
	}

	private void LateUpdate()
	{
	}

	private void RemoveRows()
	{
	}
}
