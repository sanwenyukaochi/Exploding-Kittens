using UnityEngine;

public class LobbyAvatarGridController : MonoBehaviour
{
	public PlayerRepository PlayerRepository;

	public MCPeerConnectionsMonitor MCPeerConnectionsMonitor;

	public GridController GridController;

	public LobbyAvatarFactory LobbyAvatarFactory;

	public void Initialize()
	{
	}

	public void Reset()
	{
	}

	private void OnPeerConnected(MultipeerPeerInfo peerInfo)
	{
	}

	private void OnPeerDisconnected(MultipeerPeerInfo peerInfo)
	{
	}

	private void OnAddPlayer(Player player)
	{
	}
}
