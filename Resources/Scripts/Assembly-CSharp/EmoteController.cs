using UnityEngine;

public class EmoteController : MonoBehaviour
{
	public PlayerProvider PlayerProvider;

	public GameMessages GameMessages;

	public ChatMenuGridController ChatMenuGridController;

	private Player player => null;

	public void Start()
	{
	}

	private void OnEmoteSelected(string emoteId)
	{
	}
}
