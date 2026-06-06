namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Vector2)]
	[Tooltip("Adds a XY values to Vector2 Variable.")]
	public class Vector2AddXY : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The vector2 target")]
		[UIHint(UIHint.Variable)]
		public FsmVector2 vector2Variable;

		[Tooltip("The x component to add")]
		public FsmFloat addX;

		[Tooltip("The y component to add")]
		public FsmFloat addY;

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

		private void DoVector2AddXYZ()
		{
		}
	}
}
