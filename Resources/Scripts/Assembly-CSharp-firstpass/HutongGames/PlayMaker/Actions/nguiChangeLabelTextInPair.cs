namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Change Text in Ngui Label in Pairs")]
	[ActionCategory("Ngui Actions")]
	public class nguiChangeLabelTextInPair : FsmStateAction
	{
		[Tooltip("Change Text in Label in Pairs")]
		[RequiredField]
		[CompoundArray("How Many", "Label Object", "New Text")]
		public UILabel[] theLabels;

		[Tooltip("Input your input text")]
		public FsmString[] newText;

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
