using UnityEngine;

public class EnterCodeFrame : MonoBehaviour
{
	public UILabel HeaderLabel;

	public EnterCodeFrameEvent OnBackPressed;

	public BackButtonFactory BackButtonFactory;

	public UISprite BottomGradientSprite;

	private NavigationController navigationController;

	private BackButtonStyle backButtonStyle;

	private BackButton backButton;

	public void Initialize(string headerText, BackButtonStyle backButtonStyle, EnterCodeFrameBottomStyle bottomStyle, NavigationController navigationController)
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
