using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Smoothly Rotates a Game Object so its forward vector points at a Target. The target can be defined as a Game Object or a world Position. If you specify both, then the position will be used as a local offset from the object's position.")]
	public class SmoothLookAt : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The GameObject to rotate to face a target.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("A target GameObject.")]
		public FsmGameObject targetObject;

		[Tooltip("A world position, or local offset if a Target Object is defined.")]
		public FsmVector3 targetPosition;

		[Tooltip("Used to keep the game object generally upright. If left undefined the world y axis is used.")]
		public FsmVector3 upVector;

		[Tooltip("Force the game object to remain vertical. Useful for characters.")]
		public FsmBool keepVertical;

		[Tooltip("How fast the look at moves.")]
		[HasFloatSlider(0.5f, 15f)]
		public FsmFloat speed;

		[Tooltip("Draw a line in the Scene View to the look at position.")]
		public FsmBool debug;

		[Tooltip("If the angle to the target is less than this, send the Finish Event below. Measured in degrees.")]
		public FsmFloat finishTolerance;

		[Tooltip("Event to send if the angle to target is less than the Finish Tolerance.")]
		public FsmEvent finishEvent;

		private GameObject previousGo;

		private Quaternion lastRotation;

		private Quaternion desiredRotation;

		private Vector3 lookAtPos;

		public override void Reset()
		{
		}

		public override void OnPreprocess()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnLateUpdate()
		{
		}

		private void DoSmoothLookAt()
		{
		}
	}
}
