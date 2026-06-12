using Photon;

public class PhotonPlayerProfileUpdateHandler : PunBehaviour
{
	public PlayerRepository PlayerRepository;

	public PlayerAvatarRepository PlayerAvatarRepository;

	public override void OnPhotonPlayerPropertiesChanged(object[] playerAndUpdatedProps)
	{
	}
}
