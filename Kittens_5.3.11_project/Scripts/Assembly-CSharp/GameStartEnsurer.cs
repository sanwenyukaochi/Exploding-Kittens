using UnityEngine;

public class GameStartEnsurer : MonoBehaviour
{
	public GameFailedToStartDetector GameFailedToStartDetector;

	public ActionBase ReturnToHomeSceneAction;

	public MessageBoxModal MessageBoxModal;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnGameFailedToStart()
	{
	}
}
