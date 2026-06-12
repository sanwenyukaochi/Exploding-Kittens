using UnityEngine;

public class MultipeerMessageClient : MonoBehaviour, IMessageClient
{
	private const string LOCAL_MESSAGE_HEADER = "LOCALMESSAGE:";

	private const string PARAM_DELIMITER = "\t\t\t";

	private string[] PeerIds => null;

	public void Start()
	{
	}

	public void SendToAll(string messageType, params string[] messageParams)
	{
	}

	public void SendToNetworkIds(string[] targetNetworkIds, string messageType, params string[] messageParams)
	{
	}

	private void Send(string[] peerIds, string messageType, string[] messageParams)
	{
	}

	public void OnSessionReceivedDataFromPeer(MultipeerPeerInfo fromPeer, string message)
	{
	}

	private void SendLocalMessage(string message)
	{
	}
}
