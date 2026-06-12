namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Change Text in Ngui Label randomly after interval time")]
	[ActionCategory("Ngui Actions")]
	public class nguiChangeLabelTextRandom : FsmStateAction
	{
		[RequiredField]
		[Tooltip("NGUI Label to change Text")]
		public FsmOwnerDefault NguiLabelObject;

		private UILabel theNguiLabel;

		[CompoundArray("Strings", "String", "Weight")]
		public FsmString[] strings;

		[HasFloatSlider(0f, 1f)]
		public FsmFloat[] weights;

		[Tooltip("Change text after an interval Time")]
		public FsmFloat intervalTime;

		private float currentTime;

		[Tooltip("When true, runs only once")]
		public bool onceTime;

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
