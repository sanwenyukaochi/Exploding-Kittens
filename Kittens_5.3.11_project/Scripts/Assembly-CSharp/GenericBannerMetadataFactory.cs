public class GenericBannerMetadataFactory : BannerMetadataFactory
{
	public UIAtlas TargetSpriteAtlas;

	public string TargetSpriteName;

	public string IconSpriteName;

	public string HeaderText;

	public string ActionText;

	public override BannerMetadata Create(Activity activity)
	{
		return null;
	}

	public static string FormatBodyText(string text, Activity activity)
	{
		return null;
	}

	public static string VerbForToHave(Player player)
	{
		return null;
	}

	public static string VerbForIs(Player player)
	{
		return null;
	}
}
