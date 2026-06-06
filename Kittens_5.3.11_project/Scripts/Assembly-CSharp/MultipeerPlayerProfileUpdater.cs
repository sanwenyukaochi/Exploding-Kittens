using UnityEngine;

public class MultipeerPlayerProfileUpdater : MonoBehaviour
{
	public MultipeerNetwork MultipeerNetwork;

	public MultipeerLobbyMessages MultipeerLobbyMessages;

	public PlayerRepository PlayerRepository;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnGameJoined()
	{
	}

	private void OnGameLeft()
	{
	}

	private void OnPlayerNameChanged(string username)
	{
	}

	private void OnPlayerAvatarChanged(PlayerAvatar avatar)
	{
	}
}
