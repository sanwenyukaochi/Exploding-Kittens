using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Gets the value of a UI Scrollbar component.")]
	public class UiScrollbarGetValue : ComponentAction<Scrollbar>
	{
		[CheckForComponent(typeof(Scrollbar))]
		[RequiredField]
		[Tooltip("The GameObject with the UI Scrollbar component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The position value of the UI Scrollbar.")]
		[UIHint(UIHint.Variable)]
		[RequiredField]
		public FsmFloat value;

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
