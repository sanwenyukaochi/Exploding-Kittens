public class TurnsLeftBannerMetadataFactory : BannerMetadataFactory
{
	public CardBannerMetadataFactory CardBannerMetadataFactory;

	public TurnQueue TurnQueue;

	private string BodyText => null;

	private int TurnsLeft => 0;

	public override BannerMetadata Create(Activity activity)
	{
		return null;
	}
}
