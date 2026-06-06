using UnityEngine;

public class GameSceneInitializer : MonoBehaviour
{
	public DebugPlayersInjector DebugPlayersInjector;

	public GameStartMessages GameStartMessages;

	public GameMessages GameMessages;

	public PlayerReadinessMonitor PlayerReadinessMonitor;

	public GameStarter GameStarter;

	public GameFailedToStartDetector GameFailedToStartDetector;

	public ActionBase ReturnToHomeSceneAction;

	public MessageBoxModal MessageBoxModal;

	public void Start()
	{
	}

	private void OnPlayersReady()
	{
	}

	private void AnnounceThatLocalPlayersAreReady()
	{
	}
}
