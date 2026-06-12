using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Sets the number of distinct scroll positions allowed for a UI Scrollbar component.")]
	public class UiScrollbarSetNumberOfSteps : ComponentAction<Scrollbar>
	{
		[RequiredField]
		[CheckForComponent(typeof(Scrollbar))]
		[Tooltip("The GameObject with the UI Scrollbar component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The number of distinct scroll positions allowed for the UI Scrollbar.")]
		[RequiredField]
		public FsmInt value;

		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		[Tooltip("Repeats every frame")]
		public bool everyFrame;

		private Scrollbar scrollbar;

		private int originalValue;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
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
