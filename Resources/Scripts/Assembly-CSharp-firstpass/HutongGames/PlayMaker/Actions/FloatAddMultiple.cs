namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Adds multiple float variables to float variable.")]
	public class FloatAddMultiple : FsmStateAction
	{
		[Tooltip("The float variables to add.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat[] floatVariables;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Add to this variable.")]
		public FsmFloat addTo;

		[Tooltip("Repeat every frame while the state is active.")]
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

		private void DoFloatAdd()
		{
		}
	}
}
