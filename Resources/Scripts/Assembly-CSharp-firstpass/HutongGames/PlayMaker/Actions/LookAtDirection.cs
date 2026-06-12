using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Rotates a Game Object so its forward vector points in the specified Direction.")]
	public class LookAtDirection : ComponentAction<Transform>
	{
		[RequiredField]
		[Tooltip("The GameObject to rotate.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The direction to look at.")]
		[RequiredField]
		public FsmVector3 targetDirection;

		[Tooltip("Keep this vector pointing up as the GameObject rotates.")]
		public FsmVector3 upVector;

		[Tooltip("Repeat every update.")]
		public bool everyFrame;

		[Tooltip("Perform in LateUpdate. This can help eliminate jitters in some situations.")]
		public bool lateUpdate;

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

		private void DoLookAtDirection()
		{
		}
	}
}
