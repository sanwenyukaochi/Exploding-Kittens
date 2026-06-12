using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Gets the isOn value of a UI Toggle component. Optionally send events")]
	public class UiToggleGetIsOn : ComponentAction<Toggle>
	{
		[CheckForComponent(typeof(Toggle))]
		[RequiredField]
		[Tooltip("The GameObject with the UI Toggle component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The isOn Value of the UI Toggle component.")]
		[UIHint(UIHint.Variable)]
		public FsmBool value;

		[Tooltip("Event sent when isOn Value is true.")]
		public FsmEvent isOnEvent;

		[Tooltip("Event sent when isOn Value is false.")]
		public FsmEvent isOffEvent;

		[Tooltip("Repeats every frame")]
		public bool everyFrame;

		private Toggle _toggle;

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
