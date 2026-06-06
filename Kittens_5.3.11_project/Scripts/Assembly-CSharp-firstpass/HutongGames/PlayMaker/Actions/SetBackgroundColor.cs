using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the Background Color used by the Camera.")]
	[ActionCategory(ActionCategory.Camera)]
	public class SetBackgroundColor : ComponentAction<Camera>
	{
		[Tooltip("The game object that owns the Camera component.")]
		[CheckForComponent(typeof(Camera))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[Tooltip("The background color.")]
		public FsmColor backgroundColor;

		[Tooltip("Repeat every frame. Useful if the color is animated.")]
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

		private void DoSetBackgroundColor()
		{
		}
	}
}
