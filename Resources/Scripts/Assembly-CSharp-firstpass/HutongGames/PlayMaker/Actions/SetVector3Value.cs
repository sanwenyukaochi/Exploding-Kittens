namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Vector3)]
	[Tooltip("Sets the value of a Vector3 Variable.")]
	public class SetVector3Value : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Vector3 variable to set.")]
		public FsmVector3 vector3Variable;

		[RequiredField]
		[Tooltip("Value to set variable to.")]
		public FsmVector3 vector3Value;

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
