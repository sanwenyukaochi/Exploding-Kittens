using UnityEngine;

public class SetAvatarPackVisibilityTypeForPlatform : MonoBehaviour
{
	public RuntimePlatform Platform;

	public AvatarPackRepository AvatarPackRepository;

	public AvatarPackType AvatarPackType;

	public AvatarPackVisibilityType VisibilityType;

	public bool RequiresPurchase;

	private void Start()
	{
	}
}
