using UnityEngine;

public class AvatarEmoterFactory : MonoBehaviour
{
	public GameObject Prefab;

	public GameObject Container;

	public PlayerProvider PlayerProvider;

	public GameObject AvatarSprite;

	public bool CreateOnStart;

	public int ChatBubblePanelDepth;

	private void Start()
	{
	}

	public AvatarEmoter Create()
	{
		return null;
	}
}
