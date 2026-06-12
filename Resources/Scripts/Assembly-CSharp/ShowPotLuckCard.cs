using System.Collections.Generic;
using UnityEngine;

public class ShowPotLuckCard : MonoBehaviour
{
	public TurnQueue TurnQueue;

	public DrawPile DrawPile;

	public GameObject OpponentList;

	public PlayerHud PlayerHud;

	public PlayerProvider PlayerProvider;

	private float Scale;

	private Vector3[] StartPos;

	private int CCount;

	private int PlayerCount;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void DisplayPotLuckAnimation(List<Player> players)
	{
	}

	public void OnPotLuckCompleted(Player _p, List<Player> players)
	{
	}

	private void Update()
	{
	}

	private OpponentPlayerAvatar GetTargetPlayer(Player target, PlayerHud localHud)
	{
		return null;
	}
}
