using System;
using UnityEngine;

public class TwoButtonModal : MonoBehaviour
{
	public WindowTransitioner WindowTransitioner;

	public UILabel TitleLabel;

	public UILabel DescriptionLabel;

	public UILabel ButtonLabel;

	public UILabel CancelButtonLabel;

	private Action onOk;

	private Action onCancel;

	public void Show(string title, string description, string buttonText, string cancelButtonText, Action onOk, Action onCancel)
	{
	}

	public void Ok()
	{
	}

	public void Cancel()
	{
	}

	private void TryRun(Action action)
	{
	}
}
