using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sends an Event when a Key is pressed.")]
	[ActionCategory(ActionCategory.Input)]
	public class GetKeyDown : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The key to detect.")]
		public KeyCode key;

		[Tooltip("The Event to send when the key is pressed.")]
		public FsmEvent sendEvent;

		[Tooltip("Store the result in a Bool Variable. True if pressed, otherwise False.")]
		[UIHint(UIHint.Variable)]
		public FsmBool storeResult;

		public override void Reset()
		{
		}

		public override void OnUpdate()
		{
		}
	}
}
