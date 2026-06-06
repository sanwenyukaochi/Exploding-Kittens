using UnityEngine;

public class HomeSceneWindowController : MonoBehaviour
{
	public WindowTransitioner HomeWindow;

	public WindowTransitioner WelcomeWindow;

	public NavigationController NavigationController;

	private const string PrefName = "TutorialSeen";

	public void Start()
	{
	}
}
