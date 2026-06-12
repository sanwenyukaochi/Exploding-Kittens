using Photon;

public class PhotonRoomJoinHandler : PunBehaviour
{
	public PlayerRepository PlayerRepository;

	public PlayerFactory PlayerFactory;

	public override void OnJoinedRoom()
	{
	}

	private void CreateLocalPlayersForPlayersInRoom()
	{
	}
}
