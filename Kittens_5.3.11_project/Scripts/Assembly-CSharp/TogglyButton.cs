using UnityEngine;

public class TogglyButton : MonoBehaviour
{
	public UISprite Sprite;

	public UILabel Label;

	[Header("Sprite States")]
	public string OnSpriteName;

	public string OffSpriteName;

	[TextArea(1, 2)]
	[Header("Label States")]
	public string OnLabelText;

	[TextArea(1, 2)]
	public string OffLabelText;

	public void Toggle(bool isOn)
	{
	}

	public void TurnOn()
	{
	}

	public void TurnOff()
	{
	}
}
