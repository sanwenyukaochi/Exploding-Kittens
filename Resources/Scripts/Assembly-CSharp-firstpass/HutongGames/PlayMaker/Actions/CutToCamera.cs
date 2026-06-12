using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Camera)]
	[Tooltip("Activates a Camera in the scene.")]
	public class CutToCamera : FsmStateAction
	{
		[Tooltip("The Camera to activate.")]
		[RequiredField]
		public Camera camera;

		[Tooltip("Makes the camera the new MainCamera. The old MainCamera will be untagged.")]
		public bool makeMainCamera;

		[Tooltip("Cut back to the original MainCamera when exiting this state.")]
		public bool cutBackOnExit;

		private Camera oldCamera;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnExit()
		{
		}

		private static void SwitchCamera(Camera camera1, Camera camera2)
		{
		}
	}
}
