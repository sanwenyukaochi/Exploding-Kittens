using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Align a GameObject to the specified Direction.")]
	public class AlignToDirection : ComponentAction<Transform>
	{
		public enum AlignAxis
		{
			x = 0,
			y = 1,
			z = 2
		}

		[Tooltip("The GameObject to rotate.")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("The direction to look at. E.g. the Hit Normal from a Raycast.")]
		[RequiredField]
		public FsmVector3 targetDirection;

		[RequiredField]
		[Tooltip("The GameObject axis to align to the direction.")]
		[ObjectType(typeof(AlignAxis))]
		public FsmEnum alignAxis;

		[Tooltip("Flip the alignment axis. So x becomes -x.")]
		public FsmBool flipAxis;

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

		private void DoAlignToDirection()
		{
		}
	}
}
