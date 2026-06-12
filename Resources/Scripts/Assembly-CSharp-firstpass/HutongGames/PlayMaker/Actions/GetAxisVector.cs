namespace HutongGames.PlayMaker.Actions
{
	[NoActionTargets]
	[ActionCategory(ActionCategory.Input)]
	[Tooltip("Gets a world direction Vector from 2 Input Axis. Typically used for a third person controller with Relative To set to the camera.")]
	[SeeAlso("Unity Input Manager")]
	public class GetAxisVector : FsmStateAction
	{
		public enum AxisPlane
		{
			XZ = 0,
			XY = 1,
			YZ = 2
		}

		[Tooltip("The name of the horizontal input axis. See Unity Input Manager.")]
		public FsmString horizontalAxis;

		[Tooltip("The name of the vertical input axis. See Unity Input Manager.")]
		public FsmString verticalAxis;

		[Tooltip("Normally axis values are in the range -1 to 1. Use the multiplier to make this range bigger. \nE.g., A multiplier of 100 returns values from -100 to 100.\nTypically this represents the maximum movement speed.")]
		public FsmFloat multiplier;

		[RequiredField]
		[Tooltip("Sets the world axis the input maps to. The remaining axis will be set to zero.")]
		public AxisPlane mapToPlane;

		[Tooltip("Calculate a vector relative to this game object. Typically the camera.")]
		public FsmGameObject relativeTo;

		[Tooltip("Store the resulting vector. You can use this in {{Translate}} or other movement actions.")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmVector3 storeVector;

		[Tooltip("Store the magnitude of the vector. Useful if you want to measure the strength of the input and react accordingly. Hint: Use {{Float Compare}}.")]
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
