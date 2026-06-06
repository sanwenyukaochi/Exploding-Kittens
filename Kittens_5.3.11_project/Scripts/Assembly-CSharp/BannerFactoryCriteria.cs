using System;

[Serializable]
public class BannerFactoryCriteria
{
	public string Name;

	public ActivityType ActivityType;

	public BannerMetadataFactory BannerMetadataFactory;

	public bool Supports(Activity activity)
	{
		return false;
	}
}
