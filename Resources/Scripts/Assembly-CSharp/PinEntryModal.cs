using System;

public class PinEntryModal : WindowController
{
	public WindowTransitioner WindowTransitioner;

	public UIInput PinTextField;

	public UILabel PinLabel;

	private Action<string> onSubmit;

	private Action onCancel;

	private Action onSuddenPop;

	private bool didExitNormally;

	public void Initialize(Action<string> onSubmit, Action onCancel)
	{
	}

	public void Initialize(Action<string> onSubmit, Action onCancel, Action onSuddenPop)
	{
	}

	public override void OnLoad()
	{
	}

	public override void OnUnload()
	{
	}

	public void OnCloseButtonPressed()
	{
	}

	public void OnSubmit()
	{
	}
}
