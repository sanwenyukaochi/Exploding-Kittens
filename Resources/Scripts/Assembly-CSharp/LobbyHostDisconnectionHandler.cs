using UnityEngine;

public class LobbyHostDisconnectionHandler : MonoBehaviour
{
	public MultipeerHostConnectionMonitor MultipeerHostConnectionMonitor;

	public StatusBadgeProvider StatusBadgeProvider;

	private void Start()
	{
	}

	private void OnHostDisconnected()
	{
	}
}
