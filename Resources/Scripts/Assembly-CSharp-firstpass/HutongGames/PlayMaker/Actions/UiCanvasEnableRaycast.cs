using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Enable or disable Canvas Raycasting. Optionally reset on state exit")]
	public class UiCanvasEnableRaycast : ComponentAction<PlayMakerCanvasRaycastFilterProxy>
	{
		[RequiredField]
		[Tooltip("The GameObject to enable or disable Canvas Raycasting on.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("Enable/disable raycasting. Uncheck to disable.")]
		public FsmBool enableRaycasting;

		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		[SerializeField]
		private PlayMakerCanvasRaycastFilterProxy raycastFilterProxy;

		private bool originalValue;

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

		private void DoAction()
		{
		}

		public override void OnExit()
		{
		}
	}
}
