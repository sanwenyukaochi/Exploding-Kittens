using UnityEngine;

public class ChatMenuItem : MonoBehaviour
{
	public UILabel Label;

	public GameObject Separator;

	public ChatMenuItemEvent OnSelected;

	private string emoteId;

	public void Initialize(string labelText, string emoteId, bool HasSeparator)
	{
	}

	public void Select()
	{
	}
}
