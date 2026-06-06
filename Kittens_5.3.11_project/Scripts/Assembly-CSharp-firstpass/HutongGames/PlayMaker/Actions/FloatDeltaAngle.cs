namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Gets the shortest angle between two angles.")]
	public class FloatDeltaAngle : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("First angle in degrees.")]
		public FsmFloat fromAngle;

		[RequiredField]
		[Tooltip("Second Angle in degrees.")]
		public FsmFloat toAngle;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the shortest angle between the two angles. This takes account wrapping around 360.")]
		[RequiredField]
		public FsmFloat deltaAngle;

		[Tooltip("Repeat every frame. Useful if the angles are changing.")]
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

		private void DoDeltaAngle()
		{
		}
	}
}
