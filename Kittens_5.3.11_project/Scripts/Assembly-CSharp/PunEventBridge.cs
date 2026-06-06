using Photon;

public class PunEventBridge : PunBehaviour
{
	public GenericEvent OnPunJoinedLobby;

	public GenericEvent OnPunJoinedRoom;

	public GenericEvent OnPunCreatedRoom;

	public GenericEvent OnPunDisconnected;

	public PunErrorEvent OnPunRandomJoinFailed;

	public PunErrorEvent OnPunCreateRoomFailed;

	public PunErrorEvent OnPunJoinRoomFailed;

	public PunPlayerEvent OnPunMasterClientSwitched;

	public override void OnDisconnectedFromPhoton()
	{
	}

	public override void OnJoinedLobby()
	{
	}

	public override void OnJoinedRoom()
	{
	}

	public override void OnCreatedRoom()
	{
	}

	public override void OnPhotonJoinRoomFailed(object[] codeAndMessage)
	{
	}

	public override void OnPhotonCreateRoomFailed(object[] codeAndMessage)
	{
	}

	public override void OnPhotonRandomJoinFailed(object[] codeAndMessage)
	{
	}

	public override void OnMasterClientSwitched(PhotonPlayer photonPlayer)
	{
	}

	private void InvokeEvent(GenericEvent punEvent)
	{
	}

	private void InvokeEvent(PunErrorEvent punEvent, object[] codeAndMessage)
	{
	}

	private void InvokeEvent(PunPlayerEvent punEvent, PhotonPlayer player)
	{
	}

	private PunError DecodeErrorMessage(object[] codeAndMessage)
	{
		return null;
	}
}
