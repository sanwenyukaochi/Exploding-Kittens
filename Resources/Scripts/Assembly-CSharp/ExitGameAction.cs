using System;

public class ExitGameAction : ActionBase
{
	public TurnQueue TurnQueue;

	public PlayerInterfaceRepository PlayerInterfaceRepository;

	public PlayerRepository PlayerRepository;

	public PhotonConnectionAdapter PhotonConnectionAdapter;

	public ActionBase ChangeSceneAction;

	public GameStats GameStats;

	public Action OnExitStart;

	public Action OnExitFinish;

	private string folderPath => null;

	private string filePath => null;

	public void SaveDataToTextFile()
	{
	}

	public override void Act()
	{
	}
}
