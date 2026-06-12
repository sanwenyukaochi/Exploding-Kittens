using System.Collections.Generic;
using UnityEngine;

public class CurrentDeckLabelUpdater : MonoBehaviour
{
	public UILabel Label;

	public Dictionary<DeckType, string> DeckStrings;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDeckTypeChanged(DeckType _)
	{
	}

	private void UpdateLabel()
	{
	}
}
