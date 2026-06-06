using System;
using UnityEngine;

public class PhotonGameMessages : MonoBehaviour
{
	public PlayerReadyGateController PlayerReadyController;

	public Action OnMakePrivateRoomPublic;

	public Action OnReadyToStartGame;

	private NetworkMessageRouter router => null;

	private IMessageClient MessageClient => null;

	public void Initialize()
	{
	}

	private void OnDestroy()
	{
	}

	public void SendReadyToStartGame()
	{
	}

	public void ReadyToStartGame(NetworkMessage _)
	{
	}

	private void GuardIsLobbyHost(Action OnSuccess)
	{
	}

	public void SendMakePrivateRoomPublic()
	{
	}

	public void MakePrivateRoomPublic(NetworkMessage _)
	{
	}
}
