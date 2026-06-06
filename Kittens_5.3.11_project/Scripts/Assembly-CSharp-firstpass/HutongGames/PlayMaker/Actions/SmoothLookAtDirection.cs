using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Smoothly Rotates a Game Object so its forward vector points in the specified Direction. Lets you fire an event when minmagnitude is reached")]
	public class SmoothLookAtDirection : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The GameObject to rotate.")]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[Tooltip("The direction to smoothly rotate towards.")]
		public FsmVector3 targetDirection;

		[Tooltip("Only rotate if Target Direction Vector length is greater than this threshold.")]
		public FsmFloat minMagnitude;

		[Tooltip("Keep this vector pointing up as the GameObject rotates.")]
		public FsmVector3 upVector;

		[Tooltip("Eliminate any tilt up/down as the GameObject rotates.")]
		[RequiredField]
		public FsmBool keepVertical;

		[RequiredField]
		[HasFloatSlider(0.5f, 15f)]
		[Tooltip("How quickly to rotate.")]
		public FsmFloat speed;

		[Tooltip("Perform in LateUpdate. This can help eliminate jitters in some situations.")]
		public bool lateUpdate;

		[Tooltip("Event to send if the direction difference is less than Min Magnitude.")]
		public FsmEvent finishEvent;

		[Tooltip("Stop running the action if the direction difference is less than Min Magnitude.")]
		public FsmBool finish;

		private GameObject previousGo;

		private Quaternion lastRotation;

		private Quaternion desiredRotation;

		public override void Reset()
		{
		}

		public override void OnPreprocess()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		public override void OnLateUpdate()
		{
		}

		private void DoSmoothLookAtDirection()
		{
		}
	}
}
