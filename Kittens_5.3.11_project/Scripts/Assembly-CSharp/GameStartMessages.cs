using System;
using UnityEngine;

public class GameStartMessages : MonoBehaviour
{
	public ActionBase StartGameAction;

	public GameMessages GameMessages;

	public TurnQueue TurnQueue;

	public PlayerRepository PlayerRepository;

	public StartupSoundPlayer StartupSoundPlayer;

	public GenericEvent OnGameStarted;

	public GenericEvent OnLobbyFrozen;

	private NetworkMessageRouter router => null;

	private IMessageClient MessageClient => null;

	public void Initialize()
	{
	}

	private void OnDestroy()
	{
	}

	public void SendGameStarted()
	{
	}

	public void GameStarted(NetworkMessage message)
	{
	}

	public void PlayerReady(NetworkMessage message)
	{
	}

	public void LoadGameScene(NetworkMessage message)
	{
	}

	public void SendSetDeckType(DeckType deckType)
	{
	}

	public void SetDeckType(NetworkMessage message)
	{
	}

	public void AddPlayerToQueue(NetworkMessage message)
	{
	}

	public void SendStartupMessages()
	{
	}

	public void SendLobbyIsFrozen()
	{
	}

	public void LobbyIsFrozen(NetworkMessage message)
	{
	}

	private void GuardIsLobbyClient(Action OnSuccess)
	{
	}

	private void GuardIsLobbyHost(Action OnSuccess)
	{
	}
}
