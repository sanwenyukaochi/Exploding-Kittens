namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Sets the value of a Game Object Variable.")]
	public class SetGameObject : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The GameObject Variable to set.")]
		[UIHint(UIHint.Variable)]
		public FsmGameObject variable;

		[Tooltip("Set the variable value. NOTE: leave empty to set to null.")]
		public FsmGameObject gameObject;

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
