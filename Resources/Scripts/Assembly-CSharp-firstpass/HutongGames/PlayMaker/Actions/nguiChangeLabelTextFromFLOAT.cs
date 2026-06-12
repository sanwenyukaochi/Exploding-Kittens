namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("Ngui Actions")]
	[Tooltip("Change Text in Ngui Label from inputed Float")]
	public class nguiChangeLabelTextFromFLOAT : FsmStateAction
	{
		[RequiredField]
		[Tooltip("NGUI Label object to change Text")]
		public FsmOwnerDefault NguiLabelObject;

		private UILabel theNguiLabel;

		[Tooltip("Input your input text")]
		public FsmFloat inputFloat;

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
