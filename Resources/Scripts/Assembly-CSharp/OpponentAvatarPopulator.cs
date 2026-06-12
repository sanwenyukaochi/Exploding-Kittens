using System.Collections.Generic;
using UnityEngine;

public class OpponentAvatarPopulator : MonoBehaviour
{
	public Transform Container;

	public OpponentPlayerAvatarFactory OpponentPlayerAvatarFactory;

	public TurnQueue TurnQueue;

	public OpponentAvatarSelector OpponentAvatarSelector;

	public OpponentAvatarsProvider OpponentAvatarsProvider;

	public PlayerProvider PlayerProvider;

	[Tooltip("There must be as many spawn sets as possible player counts, and they should be in order of number of players ascending.")]
	public List<Transform> AvatarSpawnSets;

	private Player currentPlayer => null;

	public void Start()
	{
	}
}
