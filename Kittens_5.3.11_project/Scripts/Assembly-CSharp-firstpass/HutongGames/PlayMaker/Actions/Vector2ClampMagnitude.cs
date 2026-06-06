namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Vector2)]
	[Tooltip("Clamps the Magnitude of Vector2 Variable.")]
	public class Vector2ClampMagnitude : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The Vector2")]
		[UIHint(UIHint.Variable)]
		public FsmVector2 vector2Variable;

		[Tooltip("The maximum Magnitude")]
		[RequiredField]
		public FsmFloat maxLength;

		[Tooltip("Repeat every frame")]
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

		private void DoVector2ClampMagnitude()
		{
		}
	}
}
