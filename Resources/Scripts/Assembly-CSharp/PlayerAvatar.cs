using System;
using UnityEngine;

[Serializable]
public class PlayerAvatar
{
	public string Id;

	public string DisplayName;

	public string SpriteName;

	public string EmotePackId;

	public int InventorySortOrder;

	public Color Color;

	public Vector3 Scale;

	public AvatarPackType AvatarPackType;

	public string DeadSpriteName => null;

	public string RandomNagSoundId => null;

	public string RandomHeroSoundId => null;

	public EmotePack EmotePack => null;

	public Emote FindEmoteById(string emoteId)
	{
		return null;
	}
}
