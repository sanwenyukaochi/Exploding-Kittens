using UnityEngine;

public class HomeSceneInitializer : MonoBehaviour
{
	public GameStartMessages GameStartMessages;

	public PhotonGameMessages PhotonGameMessages;

	public ActionBase OpenSinglePlayerChooseDeck;

	public ActionBase OpenChooseDifficulty;

	public ActionBase SetNextWindorForChooseDeck;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void AddRecord(bool win, int difficulty)
	{
	}
}
