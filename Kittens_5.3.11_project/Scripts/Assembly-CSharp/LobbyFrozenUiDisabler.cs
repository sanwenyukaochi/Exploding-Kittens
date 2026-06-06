using UnityEngine;

public class LobbyFrozenUiDisabler : MonoBehaviour
{
	public DisablyButton[] Buttons;

	public GameStartMessages GameStartMessages;

	public LobbyFrameProvider LobbyFrameProvider;

	public WindowController WindowController;

	public ChangeAvatarPanelProvider ChangeAvatarPanelProvider;

	public void Reset()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnLobbyFrozen()
	{
	}

	private void UpdateUiState(bool enabled)
	{
	}
}
