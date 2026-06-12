using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the raycast target of a UI Raw Image component.")]
	[ActionCategory(ActionCategory.UI)]
	public class UiRawImageSetRaycastTarget : ComponentAction<RawImage>
	{
		[RequiredField]
		[CheckForComponent(typeof(Image))]
		[Tooltip("The GameObject with the Raw Image UI component.")]
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
