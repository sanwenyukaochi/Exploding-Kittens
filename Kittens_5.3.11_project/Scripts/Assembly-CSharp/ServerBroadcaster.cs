using UnityEngine;

public class ServerBroadcaster : MonoBehaviour
{
	public PlayerRepository PlayerRepository;

	public MCPeerConnectionsMonitor MCPeerConnectionsMonitor;

	public MultipeerLobbyMessages MultipeerLobbyMessages;

	public MCPeerConnectionReadinessMonitor PeerConnectionReadinessMonitor;

	public GenericEvent OnCreatedGame;

	public GenericEvent OnDestroyedGame;

	public void Initialize(MultipeerGameInfo gameInfo)
	{
	}

	private void OnPeerDisconnected(MultipeerPeerInfo disconnectedPeerInfo)
	{
	}

	public void Stop()
	{
	}
}
