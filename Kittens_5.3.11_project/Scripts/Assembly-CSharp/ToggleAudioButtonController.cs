using UnityEngine;

public class ToggleAudioButtonController : MonoBehaviour
{
	public UISprite IconSprite;

	public UILabel HeadingLabel;

	public UILabel SubheadingLabel;

	public string AudioEnabledIconName;

	public string AudioEnabledHeading;

	public string AudioEnabledSubheading;

	public string AudioDisabledIconName;

	public string AudioDisabledHeading;

	public string AudioDisabledSubheading;

	private bool IsAudioEnabled => false;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Refresh()
	{
	}

	public void Toggle()
	{
	}

	private void OnIsAudioEnabledChanged(bool _)
	{
	}
}
