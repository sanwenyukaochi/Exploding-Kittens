namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Application)]
	[Tooltip("Sets the Screen Width and Height.")]
	public class SetScreenResolution : FsmStateAction
	{
		[RequiredField]
		[Tooltip("Screen Width")]
		public FsmInt width;

		[RequiredField]
		[Tooltip("Screen Height")]
		public FsmInt height;

		[Tooltip("Show Fullscreen")]
		public FsmBool fullscreen;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
