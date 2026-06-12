using System;

[Serializable]
public class AvatarPack
{
	public AvatarPackType AvatarPackType;

	public string Name;

	public string PreviewSpriteName;

	public bool RequiresPurchase;

	public string Sku;

	public AvatarPackVisibilityType VisibilityType;

	public bool IsVisible => false;

	public bool IsUnlocked => false;

	public bool HasBeenSeen => false;
}
