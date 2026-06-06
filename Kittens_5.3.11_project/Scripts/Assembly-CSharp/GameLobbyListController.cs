using System.Collections.Generic;
using UnityEngine;

public class GameLobbyListController : MonoBehaviour
{
	public UIGrid Grid;

	public GameObject OpenGameGridItemPrefab;

	public GameLobbyController GameLobbyController;

	public JoinWindowController JoinWindowController;

	public NavigationController NavigationController;

	public WindowTransitioner SearchingWindow;

	public MessageBoxModal MessageBoxModal;

	private Dictionary<MultipeerGameInfo, OpenGameGridItem> gameInfoToGridItem;

	private List<MultipeerGameInfo> AvailableGames => null;

	private void OnApplicationPause(bool paused)
	{
	}

	public void Initialize()
	{
	}

	public void StartMonitoring()
	{
	}

	public void Teardown()
	{
	}

	private void OnEnable()
	{
	}

	public void Reset()
	{
	}

	private void AddGame(MultipeerGameInfo gameInfo)
	{
	}

	private void RemoveGame(MultipeerGameInfo gameInfo)
	{
	}

	private void JoinGame(MultipeerGameInfo gameInfo)
	{
	}

	private bool GameIsJoinable(MultipeerGameInfo gameInfo)
	{
		return false;
	}

	private void ResyncSearchingWindow()
	{
	}
}
