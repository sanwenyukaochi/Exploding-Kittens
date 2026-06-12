using UnityEngine;

public class GameDisconnectionHandler : MonoBehaviour
{
	public MultipeerHostConnectionMonitor MultipeerHostConnectionMonitor;

	public PhotonConnectionMonitor PhotonConnectionMonitor;

	public GameAlert GameAlert;

	public ActionBase ReturnToHomeSceneAction;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnHostDisconnected()
	{
	}

	private void OnDisconnectedFromGame()
	{
	}

	private void OnWin(Player _)
	{
	}

	private void StopMonitoring()
	{
	}
}
