using UnityEngine;

public class HostWindowController : WindowController
{
	public ServerBroadcaster ServerBroadcaster;

	public HostWindowButtonController HostWindowButtonController;

	public ActionBase StartGameAction;

	public GameStartMessages GameStartMessages;

	public LobbyAvatarGridController LobbyAvatarGridController;

	[Header("Status label changes")]
	public StatusBadgeProvider StatusBadgeProvider;

	public string PlayersJoiningStatusText;

	public string StartingGameStatusText;

	public Color StartingGameLabelColor;

	[Header("Canceling game")]
	public PlayerRepository PlayerRepository;

	public MessageBoxModal MessageBoxModal;

	public override void OnLoad()
	{
	}

	public override void OnUnload()
	{
	}

	public void StartGame()
	{
	}

	public void CancelGameWithNetworkError()
	{
	}

	public void CancelGame()
	{
	}
}
