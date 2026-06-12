using UnityEngine;

public class MCPeerConnectionsMonitor : MonoBehaviour
{
	public MCPeerEvent OnPeerConnected;

	public MCPeerEvent OnPeerConnecting;

	public MCPeerEvent OnPeerDisconnected;

	public void Start()
	{
	}

	public void OnDestroy()
	{
	}

	private void OnSessionChangedState(MultipeerPeerInfo fromPeer, int sessionState)
	{
	}
}
