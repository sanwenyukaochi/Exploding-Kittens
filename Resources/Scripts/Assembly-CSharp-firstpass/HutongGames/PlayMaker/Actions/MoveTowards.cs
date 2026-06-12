using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Moves a Game Object towards a Target. Optionally sends an event when successful. The Target can be specified as a Game Object or a world Position. If you specify both, then the Position is used as a local offset from the Object's Position.")]
	public class MoveTowards : FsmStateAction
	{
		[Tooltip("The GameObject to Move")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("A target GameObject to move towards. Or use a world Target Position below.")]
		public FsmGameObject targetObject;

		[Tooltip("A world position to move towards, if no Target Object is set. Otherwise used as a local offset from the Target Object.")]
		public FsmVector3 targetPosition;

		[Tooltip("Ignore any height difference in the target.")]
		public FsmBool ignoreVertical;

		[HasFloatSlider(0f, 20f)]
		[Tooltip("The maximum movement speed (Unity units per second). HINT: You can make this a variable to change it over time.")]
		public FsmFloat maxSpeed;

		[HasFloatSlider(0f, 5f)]
		[Tooltip("Distance at which the move is considered finished, and the Finish Event is sent.")]
		public FsmFloat finishDistance;

		[Tooltip("Event to send when the Finish Distance is reached. Use this to transition to the next state.")]
		public FsmEvent finishEvent;

		private GameObject go;

		private GameObject goTarget;

		private Vector3 targetPos;

		private Vector3 targetPosWithVertical;

		public override void Reset()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoMoveTowards()
		{
		}

		public bool UpdateTargetPos()
		{
			return false;
		}

		public Vector3 GetTargetPos()
		{
			return default(Vector3);
		}

		public Vector3 GetTargetPosWithVertical()
		{
			return default(Vector3);
		}
	}
}
