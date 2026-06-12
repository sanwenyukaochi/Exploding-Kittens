using System;
using UnityEngine;

public class PrivateInternetGameWindowController : WindowController
{
	public NavigationController NavigationController;

	public WindowTransitioner WindowTransitioner;

	public StatusBadgeProvider StatusBadgeProvider;

	public PhotonConnectionAdapter PhotonConnectionAdapter;

	public PhotonClientStatusUpdater PhotonClientStatusUpdater;

	public InternetLobbyAvatarGridController LobbyAvatarGridController;

	public PhotonRoomCodeGenerator PhotonRoomCodeGenerator;

	public PunEventBridge PunEventBridge;

	public ShareGameCodeController ShareGameCodeController;

	public PhotonGameMessages PhotonGameMessages;

	public DisablyButton ChangeDeckButtonDisabler;

	public LobbyFrozenUiDisabler LobbyFrozenUiDisabler;

	public ApiVersionValidator ApiVersionValidator;

	public PinEntryModal PinEntryModal;

	public GameObject JoinRandomInternetGameObject;

	public PushWindowAction PushWindowJoinRandomInternetGame;

	public GameObject MakeLobbyPublicButton;

	public PhotonNetworkDownHandler PhotonNetworkDownHandler;

	[Header("Trouble Joining Message Box")]
	public MessageBoxModal MessageBoxModal;

	public PlayerRepository PlayerRepository;

	public TroubleJoiningDialog TroubleJoiningDialog;

	public TroubleJoiningDialog OnlyOneInHereDialog;

	public TroubleJoiningDialog RoomApiIsNewerDialog;

	public TroubleJoiningDialog RoomApiIsOlderDialog;

	private string lastEnteredCode;

	private string currentRoomCode;

	private Action JoinedLobbyHandler;

	private Action JoinedRoomHandler;

	private Action DisconnectHandler;

	private bool createGameOnShow;

	public bool movingFromPrivateToPublicLobby;

	private bool AutoReconnectToPhoton;

	private bool IsAlone => false;

	private bool IsFull => false;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Initialize(bool createGameOnShow)
	{
	}

	public override void OnLoad()
	{
	}

	public override void OnUnload()
	{
	}

	public void LeaveGame()
	{
	}

	public void Reset()
	{
	}

	public void StartGame()
	{
	}

	private void OnReadyToStartGame()
	{
	}

	public void SendMakeLobbyPublic()
	{
	}

	public void MakeLobbyPublic()
	{
	}

	private void JoinLobby()
	{
	}

	private void OnPunJoinedLobby()
	{
	}

	private void OnPunJoinedRoom()
	{
	}

	private void OnValidApiVersion()
	{
	}

	private void OnInvalidApiVersion(ApiVersionError error)
	{
	}

	private void ShowAloneDialog()
	{
	}

	private void ShowShareCode()
	{
	}

	private void OnPunJoinRoomFailed(PunError _)
	{
	}

	private void ShowErrorDialog(TroubleJoiningDialog dialog)
	{
	}

	private void ShowErrorDialog(TroubleJoiningDialog dialog, string code, Action onComplete)
	{
	}

	private void OnPinEntered(string pin)
	{
	}

	private void ShowPinModal()
	{
	}

	private void OnPunCreatedRoom()
	{
	}

	private void OnPunCreateRoomFailed(PunError _)
	{
	}

	private void OnPunDisconnectedFromPhoton()
	{
	}

	private void UnintentionallyDisconnected()
	{
	}

	private void JoinOrCreateRoom()
	{
	}

	private void OnPlayerCountChanged(int currentCount, int previousCount)
	{
	}

	private void OnPhotonNetworkDown()
	{
	}
}
