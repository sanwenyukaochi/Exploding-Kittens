namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Rect)]
	[Tooltip("Sets the value of a Rect Variable.")]
	public class SetRectValue : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Rect Variable to set.")]
		public FsmRect rectVariable;

		[RequiredField]
		[Tooltip("The value to set it to.")]
		public FsmRect rectValue;

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
	}
}
