namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Adds a value to an Integer Variable.")]
	[ActionCategory(ActionCategory.Math)]
	public class IntAdd : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The variable to add to.")]
		public FsmInt intVariable;

		[RequiredField]
		[Tooltip("The value to add.")]
		public FsmInt add;

		[Tooltip("Repeat every frame. NOTE: This operation will NOT be frame rate independent!")]
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
