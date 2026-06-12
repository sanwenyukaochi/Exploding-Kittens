public class CheatUnlockerWindowController : WindowController
{
	public PinEntryModal PinEntryModal;

	public ActionBase CancelAction;

	public MessageBoxModal MessageBoxModal;

	private string unlockCode;

	public override void OnLoad()
	{
	}

	private void OnCodeSubmitted(string code)
	{
	}

	private void OnCodeCanceled()
	{
	}
}
