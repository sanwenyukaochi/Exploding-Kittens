using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Set up multiple button events in a single action.")]
	public class UiButtonArray : FsmStateAction
	{
		[Tooltip("Where to send the events.")]
		public FsmEventTarget eventTarget;

		[CheckForComponent(typeof(Button))]
		[Tooltip("The GameObject with the UI Button component.")]
		[CompoundArray("Buttons", "Button", "Click Event")]
		public FsmGameObject[] gameObjects;

		[Tooltip("Send this event when the button is Clicked.")]
		public FsmEvent[] clickEvents;

		[UIHint(UIHint.Variable)]
		[Tooltip("The index of the last button clicked. (0 = first button, 1 = second, etc.)")]
		public FsmInt clickIndex;

		[SerializeField]
		private Button[] buttons;

		[SerializeField]
		private GameObject[] cachedGameObjects;

		private UnityAction[] actions;

		public override void Reset()
		{
		}

		public override void OnPreprocess()
		{
		}

		private void InitButtons()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnExit()
		{
		}

		public void OnClick(int index)
		{
		}
	}
}
