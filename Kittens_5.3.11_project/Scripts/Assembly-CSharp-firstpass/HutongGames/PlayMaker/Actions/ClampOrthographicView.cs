using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Clamps an orthographic camera's position to keep the view inside min/max ranges. Set any limit to None to leave that axis un-clamped.")]
	public class ClampOrthographicView : ComponentAction<Camera>
	{
		public enum ScreenPlane
		{
			XY = 0,
			XZ = 1
		}

		[RequiredField]
		[Tooltip("The GameObject with a Camera component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("Orientation of the view.")]
		public ScreenPlane view;

		[Tooltip("The left edge of the view to stay inside.")]
		public FsmFloat minX;

		[Tooltip("The right edge of the view to stay inside.")]
		public FsmFloat maxX;

		[Tooltip("The bottom edge of the view to stay inside.")]
		public FsmFloat minY;

		[Tooltip("The top edge of the view to stay inside.")]
		public FsmFloat maxY;

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
