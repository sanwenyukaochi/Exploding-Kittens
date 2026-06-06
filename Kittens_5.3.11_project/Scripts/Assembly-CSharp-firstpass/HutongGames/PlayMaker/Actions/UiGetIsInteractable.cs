using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Gets the interactable flag of a UI Selectable component.")]
	public class UiGetIsInteractable : ComponentAction<Selectable>
	{
		[Tooltip("The GameObject with the UI Selectable component.")]
		[CheckForComponent(typeof(Selectable))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.Variable)]
		[Tooltip("The Interactable value")]
		public FsmBool isInteractable;

		[Tooltip("Event sent if Component is Interactable")]
		public FsmEvent isInteractableEvent;

		[Tooltip("Event sent if Component is not Interactable")]
		public FsmEvent isNotInteractableEvent;

		private Selectable selectable;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoGetValue()
		{
		}
	}
}
