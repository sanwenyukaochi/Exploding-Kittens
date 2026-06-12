using UnityEngine;

public class MultipeerNetwork : MonoBehaviour
{
	public MultipeerEvent OnGameJoined;

	public MultipeerEvent OnGameLeft;

	public MCPeerConnectionsMonitor MCPeerConnectionsMonitor;

	public ServerBroadcaster ServerBroadcaster;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnPeerConnected(MultipeerPeerInfo connectingPeerInfo)
	{
	}

	private void OnPeerDisconnected(MultipeerPeerInfo disconnectedPeerInfo)
	{
	}

	private void JoinedGame()
	{
	}

	private void LeftGame()
	{
	}

	private bool PeerIsHost(MultipeerPeerInfo info)
	{
		return false;
	}
}
