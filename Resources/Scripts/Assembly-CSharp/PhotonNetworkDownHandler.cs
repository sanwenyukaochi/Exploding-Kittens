using System;
using Photon;

public class PhotonNetworkDownHandler : PunBehaviour
{
	public MessageBoxModal MessageBoxModal;

	public ActionBase NetworkDownAction;

	public Action OnNetworkDown;

	private bool CanShowMessage;

	private void OnEnable()
	{
	}

	public override void OnFailedToConnectToPhoton(DisconnectCause cause)
	{
	}
}
