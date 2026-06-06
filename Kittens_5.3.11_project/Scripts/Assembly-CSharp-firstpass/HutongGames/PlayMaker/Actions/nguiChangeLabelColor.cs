namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Change Color in Ngui Label")]
	[ActionCategory("Ngui Actions")]
	public class nguiChangeLabelColor : FsmStateAction
	{
		[Tooltip("NGUI Label to change Color")]
		[RequiredField]
		public FsmOwnerDefault NguiLabelObject;

		private UILabel theNguiLabel;

		[Tooltip("Input your input Color")]
		public FsmColor newColor;

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

		private void doChangeColor()
		{
		}
	}
}
