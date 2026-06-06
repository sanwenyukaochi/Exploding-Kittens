using System;
using UnityEngine;

[Serializable]
public class Card
{
	public string Id;

	public Texture Texture;

	public CardCategory Category;

	public string PersonalityCaption;

	public string JukeboxId;

	public bool IsDiarrhead;

	public bool IsDisguisedAsCatButt;

	public bool IsMarked;

	public DrawType DrawType;

	[HideInInspector]
	public Player PlacingPlayer;

	public CardEvent OnSprayedWithDiarrhea;

	public CardEvent OnDiarrheaWiped;

	public CardEvent OnDisguised;

	public CardEvent OnSheddedDisguise;

	public CardEvent OnMarked;

	public CardEvent OnUnMarked;

	public bool HasPlacingPlayer => false;

	public bool HasJukeboxSound => false;

	public bool HasDiscardCardSubstituteCategory => false;

	public CardCategory DiscardCardSubstituteCategory => default(CardCategory);

	public bool RestartsTurnTimerWhenPlayed => false;

	public CategoryMetadata CategoryMetadata => null;

	public bool IsValidInStartingHand => false;

	public bool IsExplodingKitten => false;

	public bool IsDefuse => false;

	public bool IsSelfSlap => false;

	public Card(string id, CardCategory category, Texture texture, string jukeboxId, string personalityCaption)
	{
	}

	public void Reset()
	{
	}

	public void MarkCard()
	{
	}

	public void UnMarkCard()
	{
	}

	public void SprayWithDiarrhea()
	{
	}

	public void WipeUpDiarrhea()
	{
	}

	public void Disguise()
	{
	}

	public void ShedDisguise()
	{
	}
}
