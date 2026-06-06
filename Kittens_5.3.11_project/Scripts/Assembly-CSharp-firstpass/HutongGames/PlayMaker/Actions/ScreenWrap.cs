using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Wraps a GameObject's position across screen edges. For example, a GameObject that moves off the left side of the screen wraps to the right side. This is often used in 2d arcade style games like Asteroids.")]
	public class ScreenWrap : ComponentAction<Transform, Camera>
	{
		[Tooltip("The GameObject to wrap.")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("GameObject with a Camera component used to render the view (or MainCamera if not set). The Viewport Rect is used for wrapping.")]
		[CheckForComponent(typeof(Camera))]
		public FsmGameObject camera;

		[Tooltip("Wrap the position of the GameObject if it moves off the left side of the screen.")]
		public FsmBool wrapLeft;

		[Tooltip("Wrap the position of the GameObject if it moves off the right side of the screen.")]
		public FsmBool wrapRight;

		[Tooltip("Wrap the position of the GameObject if it moves off the top of the screen.")]
		public FsmBool wrapTop;

		[Tooltip("Wrap the position of the GameObject if it moves off the top of the screen.")]
		public FsmBool wrapBottom;

		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		[Tooltip("Use LateUpdate. Useful if you want to wrap after any other operations in Update.")]
		public bool lateUpdate;

		private Camera cameraComponent => null;

		private Transform cameraTransform => null;

		private Transform gameObjectTransform => null;

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

		private void DoScreenWrap()
		{
		}

		private static float Wrap01(float x)
		{
			return 0f;
		}

		private static float Wrap(float x, float xMin, float xMax)
		{
			return 0f;
		}
	}
}
