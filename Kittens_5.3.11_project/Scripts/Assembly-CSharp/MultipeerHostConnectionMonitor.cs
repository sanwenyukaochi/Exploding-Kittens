using UnityEngine;

public class MultipeerHostConnectionMonitor : MonoBehaviour
{
	public MCPeerConnectionsMonitor MCPeerConnectionsMonitor;

	public HostEvent OnHostDisconnected;

	public void StartMonitoring()
	{
	}

	public void StopMonitoring()
	{
	}

	private void OnPeerDisconnected(MultipeerPeerInfo peerInfo)
	{
	}
}
