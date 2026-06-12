namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Change multi Ngui Label text with an input")]
	[ActionCategory("Ngui Actions")]
	public class nguiChangeLabelTextMulti : FsmStateAction
	{
		[RequiredField]
		[Tooltip("List of NGUI objects to set")]
		public UILabel[] theNguiLabels;

		[Tooltip("Input your input text")]
		public FsmString newText;

		[Tooltip("When true, runs on every frame")]
		public bool everyFrame;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void doChangeText()
		{
		}
	}
}
