using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Clamps a position to min/max ranges. Set any limit to None to leave un-clamped.")]
	public class ClampPosition : ComponentAction<Transform>
	{
		[RequiredField]
		[Tooltip("The GameObject to clamp position.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("Clamp the minimum value of x.")]
		public FsmFloat minX;

		[Tooltip("Clamp the maximum value of x.")]
		public FsmFloat maxX;

		[Tooltip("Clamp the minimum value of y.")]
		public FsmFloat minY;

		[Tooltip("Clamp the maximum value of y.")]
		public FsmFloat maxY;

		[Tooltip("Clamp the minimum value of z.")]
		public FsmFloat minZ;

		[Tooltip("Clamp the maximum value of z.")]
		public FsmFloat maxZ;

		[Tooltip("Clamp position in local (relative to parent) or world space.")]
		public Space space;

		[Tooltip("Repeat every frame")]
		public bool everyFrame;

		[Tooltip("Perform in LateUpdate. This is useful if you want to clamp the position of objects that are animated or otherwise positioned in Update.")]
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

		private void DoClampPosition()
		{
		}
	}
}
