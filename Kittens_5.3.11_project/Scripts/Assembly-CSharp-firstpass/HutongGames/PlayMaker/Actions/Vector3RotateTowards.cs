namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Rotates a Vector3 direction from Current towards Target.")]
	[ActionCategory(ActionCategory.Vector3)]
	public class Vector3RotateTowards : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The current direction vector.")]
		public FsmVector3 currentDirection;

		[Tooltip("The target direction vector.")]
		[RequiredField]
		public FsmVector3 targetDirection;

		[RequiredField]
		[Tooltip("Rotation speed in degrees per second.")]
		public FsmFloat rotateSpeed;

		[RequiredField]
		[Tooltip("Max Magnitude per second")]
		public FsmFloat maxMagnitude;

		public override void Reset()
		{
		}

		public override void OnUpdate()
		{
		}
	}
}
