namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Application)]
	[Tooltip("Saves a Screenshot. NOTE: Does nothing in Web Player. On Android, the resulting screenshot is available some time later.")]
	public class TakeScreenshot : FsmStateAction
	{
		public enum Destination
		{
			MyPictures = 0,
			PersistentDataPath = 1,
			CustomPath = 2
		}

		[Tooltip("Where to save the screenshot.")]
		public Destination destination;

		[Tooltip("Path used with Custom Path Destination option.")]
		public FsmString customPath;

		[RequiredField]
		[Tooltip("The filename for the screenshot.")]
		public FsmString filename;

		[Tooltip("Add an auto-incremented number to the filename.")]
		public FsmBool autoNumber;

		[Tooltip("Factor by which to increase resolution.")]
		public FsmInt superSize;

		[Tooltip("Log saved file info in Unity console.")]
		public FsmBool debugLog;

		private int screenshotCount;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
