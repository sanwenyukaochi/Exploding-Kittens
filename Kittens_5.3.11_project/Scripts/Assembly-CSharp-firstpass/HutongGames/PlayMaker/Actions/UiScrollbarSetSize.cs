using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Sets the fractional size of the handle of a UI Scrollbar component. Ranges from 0.0 to 1.0.")]
	public class UiScrollbarSetSize : ComponentAction<Scrollbar>
	{
		[Tooltip("The GameObject with the UI Scrollbar component.")]
		[CheckForComponent(typeof(Scrollbar))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[HasFloatSlider(0f, 1f)]
		[Tooltip("The fractional size of the handle for the UI Scrollbar. Ranges from 0.0 to 1.0.")]
		[RequiredField]
		public FsmFloat value;

		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		[Tooltip("Repeats every frame")]
		public bool everyFrame;

		private Scrollbar scrollbar;

		private float originalValue;

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
