using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Check if a RectTransform contains the screen point as seen from the given camera.")]
	[ActionCategory("RectTransform")]
	public class RectTransformContainsScreenPoint : FsmStateAction
	{
		[CheckForComponent(typeof(RectTransform))]
		[RequiredField]
		[Tooltip("The GameObject target.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The screenPoint as a Vector2. Leave to none if you want to use the Vector3 alternative")]
		public FsmVector2 screenPointVector2;

		[Tooltip("The screenPoint as a Vector3. Leave to none if you want to use the Vector2 alternative")]
		public FsmVector3 orScreenPointVector3;

		[Tooltip("Define if screenPoint are expressed as normalized screen coordinates (0-1). Otherwise coordinates are in pixels.")]
		public bool normalizedScreenPoint;

		[CheckForComponent(typeof(Camera))]
		[Tooltip("The Camera. For a RectTransform in a Canvas set to Screen Space - Overlay mode, the cam parameter should be set to null explicitly (default).\nLeave to none and the camera will be the one from EventSystem.current.camera")]
		public FsmGameObject camera;

		[Tooltip("Repeat every frame")]
		public bool everyFrame;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result.")]
		[ActionSection("Result")]
		public FsmBool isContained;

		[Tooltip("Event sent if screenPoint is contained in RectTransform.")]
		public FsmEvent isContainedEvent;

		[Tooltip("Event sent if screenPoint is NOT contained in RectTransform.")]
		public FsmEvent isNotContainedEvent;

		private RectTransform _rt;

		private Camera _camera;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoCheck()
		{
		}
	}
}
