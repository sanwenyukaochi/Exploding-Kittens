using UnityEngine;

public class PlayerPrefsToggle : MonoBehaviour
{
	public UIToggle Toggle;

	public string PrefName;

	public bool Inverted;

	private bool PlayerPref
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnToggleChanged()
	{
	}
}
