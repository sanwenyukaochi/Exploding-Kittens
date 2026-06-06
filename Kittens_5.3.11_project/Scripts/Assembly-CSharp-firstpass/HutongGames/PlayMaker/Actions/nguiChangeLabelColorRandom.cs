namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("Ngui Actions")]
	[Tooltip("Pick random Color and assign in Ngui Label. Userful for display hints/tips in Game")]
	public class nguiChangeLabelColorRandom : FsmStateAction
	{
		[RequiredField]
		[Tooltip("NGUI Label to change Color")]
		public FsmOwnerDefault NguiLabelObject;

		private UILabel theNguiLabel;

		[CompoundArray("Colors", "Color", "Weight")]
		[Tooltip("Input your input Colors")]
		public FsmColor[] colors;

		[HasFloatSlider(0f, 1f)]
		public FsmFloat[] weights;

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

		private void doChangeColorRandom()
		{
		}
	}
}
