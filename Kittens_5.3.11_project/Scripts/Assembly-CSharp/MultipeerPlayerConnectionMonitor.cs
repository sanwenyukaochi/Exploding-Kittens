using UnityEngine;

public class MultipeerPlayerConnectionMonitor : MonoBehaviour
{
	public MCPeerConnectionsMonitor MCPeerConnectionsMonitor;

	public PlayerRepository PlayerRepository;

	public GameMessages GameMessages;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnPeerDisconnected(MultipeerPeerInfo peerInfo)
	{
	}
}
