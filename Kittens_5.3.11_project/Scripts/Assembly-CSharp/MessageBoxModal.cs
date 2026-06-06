using System;
using UnityEngine;

public class MessageBoxModal : MonoBehaviour
{
	public DialogRepository DialogRepository;

	public WindowTransitioner WindowTransitioner;

	public UILabel TitleLabel;

	public UILabel DescriptionLabel;

	public UILabel ButtonLabel;

	private Action onComplete;

	public string ErrorOkButtonSoundName;

	public MessageBoxDisplayer MessageBoxDisplayer;

	public GameObject m_WebLink;

	public void ShowError(DialogId dialogId, Action onComplete)
	{
	}

	public void Show(DialogId dialogId, Action onComplete)
	{
	}

	public void Show(DialogId dialogId)
	{
	}

	public void Show(string title, string description, string buttonText, Action onComplete)
	{
	}

	public void Hide()
	{
	}

	public void OpenWeb()
	{
	}
}
