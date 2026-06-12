using System;
using UnityEngine;

[Serializable]
public class CategoryMetadata
{
	public CardCategory CardCategory;

	public PlayerPhase PlayerPhase;

	public CardCategory DiscardCardSubstituteCategory;

	public string TooltipTitle;

	public string FullTitle;

	[Multiline(2)]
	public string Instructions;

	[Multiline(2)]
	public string DetailInstructions;

	[Multiline(2)]
	public string IconSpriteName;

	public bool RestartsTurnTimerWhenPlayed;

	public Color ParticleColor;

	public Color BorderColor;

	public bool HasDiscardCardSubstituteCategory => false;
}
