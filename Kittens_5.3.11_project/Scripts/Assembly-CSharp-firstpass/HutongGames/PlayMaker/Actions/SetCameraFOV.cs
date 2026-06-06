using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets Field of View used by the Camera.")]
	[ActionCategory(ActionCategory.Camera)]
	public class SetCameraFOV : ComponentAction<Camera>
	{
		[RequiredField]
		[Tooltip("The Game Object with the Camera component.")]
		[CheckForComponent(typeof(Camera))]
		public FsmOwnerDefault gameObject;

		[Tooltip("Field of view in degrees.")]
		[RequiredField]
		public FsmFloat fieldOfView;

		[Tooltip("Repeat every frame. Useful if the fov is animated.")]
		public bool everyFrame;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoSetCameraFOV()
		{
		}
	}
}
