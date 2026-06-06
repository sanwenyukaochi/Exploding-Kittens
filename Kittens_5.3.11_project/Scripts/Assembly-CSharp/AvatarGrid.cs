using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(UIGrid))]
public class AvatarGrid : MonoBehaviour
{
	public GameObject AvatarPrefab;

	public bool setAvatarEmoterFactory_ChatBubblePanelDepth;

	public int AvatarEmoterFactory_ChatBubblePanelDepth;

	private UIGrid grid;

	private int avatarCount;

	private Dictionary<Player, Avatar> currentAvatars;

	private void Awake()
	{
	}

	public Avatar AddPlayer(Player player)
	{
		return null;
	}

	public void RemovePlayer(Player player)
	{
	}

	public void Clear()
	{
	}

	public Avatar GetAvatar(string playerId)
	{
		return null;
	}

	public Avatar GetAvatar(Player player)
	{
		return null;
	}
}
