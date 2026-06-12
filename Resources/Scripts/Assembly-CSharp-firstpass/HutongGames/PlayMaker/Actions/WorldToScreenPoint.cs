using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Transforms a position from world space into screen space. \nNote: Uses the Main Camera unless you specify a camera to use.")]
	[ActionCategory(ActionCategory.Camera)]
	public class WorldToScreenPoint : FsmStateAction
	{
		[Tooltip("Camera GameObject to use. Defaults to MainCamera if not defined.")]
		public FsmGameObject camera;

		[Tooltip("World position to transform into screen coordinates.")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 worldPosition;

		[Tooltip("Override X coordinate.")]
		public FsmFloat worldX;

		[Tooltip("Override Y coordinate.")]
		public FsmFloat worldY;

		[Tooltip("Override Z coordinate.")]
		public FsmFloat worldZ;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the screen position in a Vector3 Variable. Z will equal zero.")]
		public FsmVector3 storeScreenPoint;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the screen X position in a Float Variable.")]
		public FsmFloat storeScreenX;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the screen Y position in a Float Variable.")]
		public FsmFloat storeScreenY;

		[Tooltip("Normalize screen coordinates (0-1). Otherwise coordinates are in pixels.")]
		public FsmBool normalize;

		[Tooltip("Repeat every frame")]
		public bool everyFrame;

		private GameObject cameraGameObject;

		private Camera screenCamera;

		public override void Reset()
		{
		}

		private void InitCamera()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoWorldToScreenPoint()
		{
		}

		public override string ErrorCheck()
		{
			return null;
		}
	}
}
