public class ChoosingTargetMetadataFactory : BannerMetadataFactory
{
	public UIAtlas TargetAtlas;

	public CardCategory CardCategory;

	public string HeaderText;

	public PlayerRepository PlayerRepository;

	public override BannerMetadata Create(Activity activity)
	{
		return null;
	}

	private string BodyText(Activity activity)
	{
		return null;
	}

	private string NobodyHasCardsBodyText(Activity activity)
	{
		return null;
	}

	private string ChooseVictimBodyText(Activity activity)
	{
		return null;
	}

	private bool PlayerHasStealableOpponents(Player player)
	{
		return false;
	}
}
