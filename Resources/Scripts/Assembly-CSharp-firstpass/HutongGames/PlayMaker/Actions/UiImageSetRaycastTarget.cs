using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Sets the raycast target of a UI Image component.")]
	public class UiImageSetRaycastTarget : ComponentAction<Image>
	{
		[Tooltip("The GameObject with the Image UI component.")]
		[CheckForComponent(typeof(Image))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("The raycast target value to be set")]
		[RequiredField]
		public FsmBool raycastTarget;

		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		private bool originalBool;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoSetRaycastTarget()
		{
		}

		public override void OnExit()
		{
		}
	}
}
