using Photon;

public class PhotonConnectionMonitor : PunBehaviour
{
	public HostEvent OnDisconnected;

	public override void OnDisconnectedFromPhoton()
	{
	}
}
