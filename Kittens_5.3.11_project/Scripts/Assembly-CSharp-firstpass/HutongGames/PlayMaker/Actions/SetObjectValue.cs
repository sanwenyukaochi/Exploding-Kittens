namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the value of an Object Variable.")]
	[ActionCategory(ActionCategory.UnityObject)]
	public class SetObjectValue : FsmStateAction
	{
		[UIHint(UIHint.Variable)]
		[RequiredField]
		[Tooltip("The Object Variable to set.")]
		public FsmObject objectVariable;

		[RequiredField]
		[Tooltip("The value.")]
		public FsmObject objectValue;

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
