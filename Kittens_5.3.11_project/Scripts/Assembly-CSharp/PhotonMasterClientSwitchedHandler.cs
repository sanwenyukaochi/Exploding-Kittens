using Photon;

public class PhotonMasterClientSwitchedHandler : PunBehaviour
{
	public MasterClientSwitchedEvent OnHostChanged;

	public override void OnMasterClientSwitched(PhotonPlayer _)
	{
	}
}
