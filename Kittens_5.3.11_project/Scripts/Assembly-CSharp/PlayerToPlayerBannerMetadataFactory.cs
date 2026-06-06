using UnityEngine;

public class PlayerToPlayerBannerMetadataFactory : BannerMetadataFactory
{
	public UIAtlas PlayerAtlas;

	public CardCategory CardCategory;

	public string HeaderText;

	[Tooltip("Use %subject and %target for the subject/target pronouns")]
	public string ActionText;

	public override BannerMetadata Create(Activity activity)
	{
		return null;
	}
}
