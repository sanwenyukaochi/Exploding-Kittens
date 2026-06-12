using System;
using System.Collections.Generic;
using UnityEngine;

public class OpponentAvatarSelector : MonoBehaviour
{
	public List<OpponentPlayerAvatar> Avatars;

	private Action<Player> onComplete;

	public void AddAvatar(OpponentPlayerAvatar avatar)
	{
	}

	private void OnDisconnect(Player player)
	{
	}

	public void Show(List<Player> opponents, Card card, Action<Player> onComplete)
	{
	}

	public void CancelChoosingOpponent()
	{
	}

	public void OnSelected(Player player)
	{
	}

	private void ExitSelectionMode()
	{
	}
}
