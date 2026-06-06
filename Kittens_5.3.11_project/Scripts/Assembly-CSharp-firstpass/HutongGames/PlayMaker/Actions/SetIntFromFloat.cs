namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Sets the value of an integer variable using a float value.")]
	public class SetIntFromFloat : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The int variable to set.")]
		public FsmInt intVariable;

		[Tooltip("The float value.")]
		public FsmFloat floatValue;

		[Tooltip("Do it every frame.")]
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
