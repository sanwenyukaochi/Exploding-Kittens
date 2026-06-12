namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the individual fields of a Rect Variable. To leave any field unchanged, set variable to 'None'.")]
	[ActionCategory(ActionCategory.Rect)]
	public class SetRectFields : FsmStateAction
	{
		[RequiredField]
		[Tooltip("Rect Variable to set.")]
		[UIHint(UIHint.Variable)]
		public FsmRect rectVariable;

		[Tooltip("Set X value.")]
		public FsmFloat x;

		[Tooltip("Set Y value.")]
		public FsmFloat y;

		[Tooltip("Set Width.")]
		public FsmFloat width;

		[Tooltip("Set Height.")]
		public FsmFloat height;

		[Tooltip("Repeat every frame. Useful if the fields are animated.")]
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

		private void DoSetRectFields()
		{
		}
	}
}
