namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Change Text in Ngui Label from inputed variable that can be type of variable")]
	[ActionCategory("Ngui Actions")]
	public class nguiChangeLabelTextFromVar : FsmStateAction
	{
		[RequiredField]
		[Tooltip("NGUI Label to change Text")]
		public FsmOwnerDefault NguiLabelObject;

		private UILabel theNguiLabel;

		[Tooltip("Type of Var will be automatically convert to string")]
		[UIHint(UIHint.Variable)]
		public FsmVar inputVar;

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
