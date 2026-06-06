using UnityEngine;

public abstract class BannerMetadataFactory : MonoBehaviour
{
	public abstract BannerMetadata Create(Activity activity);
}
