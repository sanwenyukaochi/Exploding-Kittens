using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Gets the navigation mode of a UI Selectable component.")]
	public class UiNavigationGetMode : ComponentAction<Selectable>
	{
		[RequiredField]
		[CheckForComponent(typeof(Selectable))]
		[Tooltip("The GameObject with the UI Selectable component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The navigation mode value")]
		public FsmString navigationMode;

		[Tooltip("Event sent if transition is ColorTint")]
		public FsmEvent automaticEvent;

		[Tooltip("Event sent if transition is ColorTint")]
		public FsmEvent horizontalEvent;

		[Tooltip("Event sent if transition is SpriteSwap")]
		public FsmEvent verticalEvent;

		[Tooltip("Event sent if transition is Animation")]
		public FsmEvent explicitEvent;

		[Tooltip("Event sent if transition is none")]
		public FsmEvent noNavigationEvent;

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
