using UnityEngine;

public class LobbyFrozenTooLongEventHandler : MonoBehaviour
{
	public LobbyFrozenTimeout LobbyFrozenTimeout;

	public NavigationController NavigationController;

	public MessageBoxModal MessageBoxModal;

	public ActionBase LeaveGameAction;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void OnLobbyFrozenForTooLong()
	{
	}
}
