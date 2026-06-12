using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets the explicit navigation properties of a UI Selectable component. ")]
	[ActionCategory(ActionCategory.UI)]
	public class UiNavigationExplicitGetProperties : ComponentAction<Selectable>
	{
		[RequiredField]
		[CheckForComponent(typeof(Selectable))]
		[Tooltip("The GameObject with the UI Selectable component.")]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.Variable)]
		[Tooltip("The down Selectable.")]
		public FsmGameObject selectOnDown;

		[Tooltip("The up Selectable.")]
		[UIHint(UIHint.Variable)]
		public FsmGameObject selectOnUp;

		[UIHint(UIHint.Variable)]
		[Tooltip("The left Selectable.")]
		public FsmGameObject selectOnLeft;

		[UIHint(UIHint.Variable)]
		[Tooltip("The right Selectable.")]
		public FsmGameObject selectOnRight;

		private Selectable _selectable;

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
