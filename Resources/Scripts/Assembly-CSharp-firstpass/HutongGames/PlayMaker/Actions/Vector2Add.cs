namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Vector2)]
	[Tooltip("Adds a value to Vector2 Variable.")]
	public class Vector2Add : FsmStateAction
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("The vector2 target")]
		[RequiredField]
		public FsmVector2 vector2Variable;

		[RequiredField]
		[Tooltip("The vector2 to add")]
		public FsmVector2 addVector;

		[Tooltip("Repeat every frame")]
		public bool everyFrame;

		[Tooltip("Add the value on a per second bases.")]
		public bool perSecond;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoVector2Add()
		{
		}
	}
}
