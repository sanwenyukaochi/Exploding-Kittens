using UnityEngine.EventSystems;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets pointer data Input Button on the last System event.")]
	[ActionCategory(ActionCategory.UI)]
	public class UiGetLastPointerEventDataInputButton : FsmStateAction
	{
		[UIHint(UIHint.Variable)]
		[ObjectType(typeof(PointerEventData.InputButton))]
		[Tooltip("Store the Input Button pressed (Left, Right, Middle)")]
		public FsmEnum inputButton;

		[Tooltip("Event to send if Left Button clicked.")]
		public FsmEvent leftClick;

		[Tooltip("Event to send if Middle Button clicked.")]
		public FsmEvent middleClick;

		[Tooltip("Event to send if Right Button clicked.")]
		public FsmEvent rightClick;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void ExecuteAction()
		{
		}
	}
}
