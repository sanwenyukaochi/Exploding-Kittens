using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("RectTransform")]
	[Tooltip("RectTransforms position from world space into screen space. Leave the camera to none for default behavior.")]
	public class RectTransformWorldToScreenPoint : BaseUpdateAction
	{
		[Tooltip("The GameObject target.")]
		[CheckForComponent(typeof(RectTransform))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[CheckForComponent(typeof(Camera))]
		[Tooltip("The camera to perform the calculation. Leave as None for default behavior.")]
		public FsmOwnerDefault camera;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the screen position in a Vector3 Variable. Z will equal zero.")]
		public FsmVector3 screenPoint;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the screen X position in a Float Variable.")]
		public FsmFloat screenX;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the screen Y position in a Float Variable.")]
		public FsmFloat screenY;

		[Tooltip("Normalize screen coordinates (0-1). Otherwise coordinates are in pixels.")]
		public FsmBool normalize;

		private RectTransform _rt;

		private Camera _cam;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnActionUpdate()
		{
		}

		private void DoWorldToScreenPoint()
		{
		}
	}
}
