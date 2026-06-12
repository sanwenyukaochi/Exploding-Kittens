using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Vector2)]
	[Tooltip("Rotates a Vector2 direction from Current towards Target.")]
	public class Vector2RotateTowards : FsmStateAction
	{
		[Tooltip("The current direction. This will be the result of the rotation as well.")]
		[RequiredField]
		public FsmVector2 currentDirection;

		[RequiredField]
		[Tooltip("The direction to reach")]
		public FsmVector2 targetDirection;

		[RequiredField]
		[Tooltip("Rotation speed in degrees per second")]
		public FsmFloat rotateSpeed;

		private Vector3 current;

		private Vector3 target;

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
