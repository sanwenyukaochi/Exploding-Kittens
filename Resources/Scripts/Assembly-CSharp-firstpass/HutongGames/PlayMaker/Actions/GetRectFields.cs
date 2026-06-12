namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Rect)]
	[Tooltip("Get the individual fields of a Rect Variable and store them in Float Variables.")]
	public class GetRectFields : FsmStateAction
	{
		[Tooltip("The Rect Variable.")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmRect rectVariable;

		[Tooltip("Store the X value in a Float Variable.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat storeX;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the X value in a Float Variable.")]
		public FsmFloat storeY;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the Width in a Float Variable.")]
		public FsmFloat storeWidth;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the Height in a Float Variable.")]
		public FsmFloat storeHeight;

		[Tooltip("Repeat every frame.")]
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

		private void DoGetRectFields()
		{
		}
	}
}
