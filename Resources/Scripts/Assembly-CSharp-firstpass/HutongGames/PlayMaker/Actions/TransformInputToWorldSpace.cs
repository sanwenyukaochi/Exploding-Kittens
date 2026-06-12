namespace HutongGames.PlayMaker.Actions
{
	[NoActionTargets]
	[ActionCategory(ActionCategory.Input)]
	[Tooltip("Transforms 2d input into a 3d world space vector. E.g., can be used to transform input from a touch joystick to a movement vector.")]
	public class TransformInputToWorldSpace : FsmStateAction
	{
		public enum AxisPlane
		{
			XZ = 0,
			XY = 1,
			YZ = 2
		}

		[UIHint(UIHint.Variable)]
		[Tooltip("The horizontal input.")]
		public FsmFloat horizontalInput;

		[UIHint(UIHint.Variable)]
		[Tooltip("The vertical input.")]
		public FsmFloat verticalInput;

		[Tooltip("Input axis are reported in the range -1 to 1, this multiplier lets you set a new range.")]
		public FsmFloat multiplier;

		[RequiredField]
		[Tooltip("The world plane to map the 2d input onto.")]
		public AxisPlane mapToPlane;

		[Tooltip("Make the result relative to a GameObject, typically the main camera.")]
		public FsmGameObject relativeTo;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the direction vector.")]
		public FsmVector3 storeVector;

		[Tooltip("Store the length of the direction vector.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat storeMagnitude;

		public override void Reset()
		{
		}

		public override void OnUpdate()
		{
		}
	}
}
