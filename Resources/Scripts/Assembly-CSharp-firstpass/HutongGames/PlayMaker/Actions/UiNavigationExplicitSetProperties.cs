using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the explicit navigation properties of a UI Selectable component. Note that it will have no effect until Navigation mode is set to 'Explicit'.")]
	[ActionCategory(ActionCategory.UI)]
	public class UiNavigationExplicitSetProperties : ComponentAction<Selectable>
	{
		[CheckForComponent(typeof(Selectable))]
		[RequiredField]
		[Tooltip("The GameObject with the UI Selectable component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The down Selectable. Leave as None for no effect")]
		[CheckForComponent(typeof(Selectable))]
		public FsmGameObject selectOnDown;

		[Tooltip("The up Selectable.  Leave as None for no effect")]
		[CheckForComponent(typeof(Selectable))]
		public FsmGameObject selectOnUp;

		[Tooltip("The left Selectable.  Leave as None for no effect")]
		[CheckForComponent(typeof(Selectable))]
		public FsmGameObject selectOnLeft;

		[CheckForComponent(typeof(Selectable))]
		[Tooltip("The right Selectable.  Leave as None for no effect")]
		public FsmGameObject selectOnRight;

		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		private Selectable selectable;

		private Navigation navigation;

		private Navigation originalState;

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

		private static T GetComponentFromFsmGameObject<T>(FsmGameObject variable) where T : Component
		{
			return null;
		}
	}
}
