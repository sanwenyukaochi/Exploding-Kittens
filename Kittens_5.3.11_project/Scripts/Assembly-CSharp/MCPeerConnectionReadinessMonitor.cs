using System.Collections.Generic;
using UnityEngine;

public class MCPeerConnectionReadinessMonitor : MonoBehaviour
{
	public MCPeerConnectionsMonitor MCPeerConnectionsMonitor;

	public PeerConnectionReadinessEvent OnAllPeerConnectionsAreReady;

	public PeerConnectionReadinessEvent OnAllPeerConnectionsAreNotReady;

	public LobbyStateHashGenerator LobbyStateHashGenerator;

	private Dictionary<string, string> peerIdToStateHash;

	public string ValidConnectionsHash => null;

	public void StartListening(string peerId)
	{
	}

	public void StopListening()
	{
	}

	private void OnPeerConnecting(MultipeerPeerInfo connectingPeerInfo)
	{
	}

	private void OnPeerConnected(MultipeerPeerInfo connectingPeerInfo)
	{
	}

	public void OnPeerDisconnected(MultipeerPeerInfo disconnectedPeerInfo)
	{
	}

	public void SetLobbyStateHash(string peerId, string hash)
	{
	}

	private void Check()
	{
	}
}
