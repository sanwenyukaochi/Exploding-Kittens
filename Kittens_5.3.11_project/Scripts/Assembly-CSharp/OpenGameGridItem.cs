using System;
using UnityEngine;

public class OpenGameGridItem : MonoBehaviour
{
	public UILabel NameLabel;

	public UILabel DeckLabel;

	public UISprite Background;

	public GameObject PartyHat;

	private MultipeerGameInfo gameInfo;

	private Action<MultipeerGameInfo> onTappedJoin;

	public void Initialize(MultipeerGameInfo gameInfo, Action<MultipeerGameInfo> onTappedJoin)
	{
	}

	private void OnJoinedGame(MultipeerGameInfo gameInfo)
	{
	}

	public void OnJoinGame()
	{
	}

	public void Remove()
	{
	}
}
