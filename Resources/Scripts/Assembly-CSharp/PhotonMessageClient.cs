using UnityEngine;

public class PhotonMessageClient : MonoBehaviour, IMessageClient
{
	public class PhotonMessageData
	{
		public string messageType;

		public string[] messageParams;

		public PhotonMessageInfo info;
	}

	public static PhotonMessageClient m;

	public PhotonView PhotonView;

	private int CurrentMessage;

	private int CurrentStoreMessageIndex;

	private PhotonMessageData[] PMessageQueue;

	private bool RecvFlag;

	private void Awake()
	{
	}

	public void ClearBufferedMessages()
	{
	}

	public void SendToAll(string messageType, params string[] messageParams)
	{
	}

	[PunRPC]
	private void Receive(string messageType, string[] messageParams, PhotonMessageInfo info)
	{
	}

	private void Update()
	{
	}
}
