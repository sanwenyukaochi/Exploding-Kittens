using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Camera)]
	[Tooltip("Sets the Culling Mask used by the Camera.")]
	public class SetCameraCullingMask : ComponentAction<Camera>
	{
		[CheckForComponent(typeof(Camera))]
		[Tooltip("The Game Object with the Camera component.")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.Layer)]
		[Tooltip("Cull these layers.")]
		public FsmInt[] cullingMask;

		[Tooltip("Invert the mask, so you cull all layers except those defined above.")]
		public FsmBool invertMask;

		[Tooltip("Repeat every frame.")]
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

		private void DoSetCameraCullingMask()
		{
		}
	}
}
