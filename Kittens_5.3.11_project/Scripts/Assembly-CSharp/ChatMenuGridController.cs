using System.Collections.Generic;
using UnityEngine;

public class ChatMenuGridController : MonoBehaviour
{
	public GridController GridController;

	public PlayerAvatarProvider PlayerAvatarProvider;

	public ChatMenuItemFactory ChatMenuItemFactory;

	public ChatMenuItemEvent OnEmoteSelected;

	private const int MaxRowsInColumn = 3;

	private List<Emote> Emotes => null;

	private PlayerAvatar PlayerAvatar => null;

	private void Start()
	{
	}
}
