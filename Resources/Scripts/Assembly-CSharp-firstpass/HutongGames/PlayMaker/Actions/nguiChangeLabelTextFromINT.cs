namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("Ngui Actions")]
	[Tooltip("Change Text in Ngui Label from inputed INT")]
	public class nguiChangeLabelTextFromINT : FsmStateAction
	{
		[RequiredField]
		[Tooltip("NGUI Label to change Text")]
		public FsmOwnerDefault NguiLabelObject;

		private UILabel theNguiLabel;

		[Tooltip("Input your input text")]
		public FsmInt inputINT;

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
