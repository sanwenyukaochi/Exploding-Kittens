using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the navigation mode of a UI Selectable component.")]
	[ActionCategory(ActionCategory.UI)]
	public class UiNavigationSetMode : ComponentAction<Selectable>
	{
		[Tooltip("The GameObject with the UI Selectable component.")]
		[CheckForComponent(typeof(Selectable))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("The navigation mode value")]
		public Navigation.Mode navigationMode;

		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		private Selectable selectable;

		private Navigation _navigation;

		private Navigation.Mode originalValue;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoSetValue()
		{
		}

		public override void OnExit()
		{
		}
	}
}
