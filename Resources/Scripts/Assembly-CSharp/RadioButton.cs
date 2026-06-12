using UnityEngine;

public class RadioButton<T> : MonoBehaviour
{
	public RadioButtonDelegate<T> OnSelect;

	public bool IsEnabled;

	public UILabel UILabel;

	public UIToggle UIToggle;

	public Color NormalColor;

	public Color SelectedColor;

	public Color DisabledColor;

	private T val;

	public void Initialize(T val, string title)
	{
	}

	public void Disable()
	{
	}

	public void Toggle()
	{
	}
}
