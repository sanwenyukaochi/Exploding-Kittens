using UnityEngine;

public class MaxPlayerCountGateController : MonoBehaviour
{
	public PlayerRepository PlayerRepository;

	public Gate Gate;

	public void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	private void OnPlayerCountChanged(int playerCount, int _)
	{
	}
}
