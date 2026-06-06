using UnityEngine;

public class ActivityBanner : MonoBehaviour
{
	public UILabel HeaderLabel;

	public UILabel BodyLabel;

	public UISprite ActorSprite;

	public UISprite TargetSprite;

	public UISprite IconSprite;

	public UISprite IconBackgroundSprite;

	public PlayMakerFSM RevealingFsm;

	private BannerMetadata nextBannerMetadata;

	private BannerMetadata currentBannerMetadata;

	public void Show(BannerMetadata bannerMetadata)
	{
	}

	public void Enable()
	{
	}

	public void Disable()
	{
	}

	public void OnReadyForDisplay()
	{
	}

	private void Redisplay(BannerMetadata bannerMetadata)
	{
	}
}
