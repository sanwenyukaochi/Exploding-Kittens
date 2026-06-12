using UnityEngine;

public class EmoteAnimationController : MonoBehaviour
{
	public PlayerProvider PlayerProvider;

	public EmoteBubble OverEmoteBubble;

	public EmoteBubble UnderEmoteBubble;

	public ActionBase ShakeAction;

	private Player Player => null;

	private EmoteBubble EmoteBubble => null;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnEmote(Player player, Emote emote)
	{
	}

	public void ShowEmote(Player player, string text, Emote emote = null)
	{
	}
}
