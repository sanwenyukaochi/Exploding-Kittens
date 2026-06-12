using UnityEngine;

public class LobbyFrame : MonoBehaviour
{
	public UILabel HeaderLabel;

	public LobbyFrameEvent OnBackPressed;

	public BackButtonFactory BackButtonFactory;

	public UISprite BottomGradientSprite;

	private NavigationController navigationController;

	private BackButtonStyle backButtonStyle;

	private BackButton backButton;

	public void Initialize(string headerText, BackButtonStyle backButtonStyle, LobbyFrameBottomStyle bottomStyle, NavigationController navigationController)
	{
	}

	public void DisableBackButton()
	{
	}

	public void EnableBackButton()
	{
	}

	public void SetHeaderText(string text)
	{
	}

	public void OnBackButtonPressed()
	{
	}
}
