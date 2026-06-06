using System;
using UnityEngine;

[Serializable]
public class DeckMetadata
{
	public DeckType DeckType;

	public string DisplayName;

	public Color DisplayNameColor;

	public TextAsset TextAsset;

	public string GameGridItemBackgroundSpriteName;

	public bool ShowPartyHat;

	public bool RequiresPurchase;

	public string Sku;

	public CardCategory[] FeaturedCardCategories;
}
