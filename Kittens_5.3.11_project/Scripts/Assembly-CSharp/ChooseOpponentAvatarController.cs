using System.Collections.Generic;
using UnityEngine;

public class ChooseOpponentAvatarController : MonoBehaviour
{
	public OpponentAvatarSelector OpponentAvatarSelector;

	public GameMessages GameMessages;

	public PlayerProvider PlayerProvider;

	public List<CardCategory> CategoriesThatRequireCleanCards;

	public PlayerRepository PlayerRepository;

	private Player player => null;

	public void Start()
	{
	}

	private void OnPlayerChooseOpponent(Player player, Card card)
	{
	}

	private void OnCancelChooseOpponent(Player _)
	{
	}

	public void Show(Card card)
	{
	}

	private bool PlayerHasStealableOpponents(Player player)
	{
		return false;
	}

	private bool PlayerHasTakeThatOpponents(Player player)
	{
		return false;
	}
}
