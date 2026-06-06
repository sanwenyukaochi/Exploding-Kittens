using System;
using UnityEngine;

public class HostWindowButtonController : MonoBehaviour
{
	public DisablyButton StartGameButton;

	public MCPeerConnectionReadinessMonitor PeerConnectionReadinessMonitor;

	public TimeoutAction GameIsBrokenTimeout;

	private Action cancelAction;

	private bool HasOtherPlayers => false;

	public void Initialize(Action cancelAction)
	{
	}

	private void OnDisable()
	{
	}

	private void OnAllPeerConnectionsAreReady()
	{
	}

	private void OnGameBecamePlayable()
	{
	}

	private void OnGameNoLongerPlayable()
	{
	}

	private void UnlockStartGameButton()
	{
	}

	private void LockStartGameButton()
	{
	}
}
