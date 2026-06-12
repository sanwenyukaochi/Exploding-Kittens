using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Gets the direction of a UI Scrollbar component.")]
	public class UiScrollbarGetDirection : ComponentAction<Scrollbar>
	{
		[CheckForComponent(typeof(Scrollbar))]
		[RequiredField]
		[Tooltip("The GameObject with the UI Scrollbar component.")]
		public FsmOwnerDefault gameObject;

		[ObjectType(typeof(Scrollbar.Direction))]
		[UIHint(UIHint.Variable)]
		[RequiredField]
		[Tooltip("Store the direction of the UI Scrollbar.")]
		public FsmEnum direction;

		[Tooltip("Repeats every frame")]
		public bool everyFrame;

		private Scrollbar scrollbar;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoGetValue()
		{
		}
	}
}
