using UnityEngine;

public class GameClient : MonoBehaviour
{
	public MultipeerLobbyMessages MultipeerLobbyMessages;

	public PlayerRepository PlayerRepository;

	public MCPeerConnectionsMonitor MCPeerConnectionsMonitor;

	public LobbyStateHashGenerator LobbyStateHashGenerator;

	public void Initialize(MultipeerGameInfo gameInfo)
	{
	}

	public void Stop()
	{
	}

	private void OnPeerConnected(MultipeerPeerInfo connectingPeerInfo)
	{
	}

	private void OnPeerDisconnected(MultipeerPeerInfo disconnectedPeerInfo)
	{
	}
}
