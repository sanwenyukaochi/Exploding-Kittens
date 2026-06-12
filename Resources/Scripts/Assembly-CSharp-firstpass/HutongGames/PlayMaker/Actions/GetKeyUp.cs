using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sends an Event when a Key is released.")]
	[ActionCategory(ActionCategory.Input)]
	public class GetKeyUp : FsmStateAction
	{
		[Tooltip("The key to detect.")]
		[RequiredField]
		public KeyCode key;

		[Tooltip("The Event to send when the key is released.")]
		public FsmEvent sendEvent;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a Bool Variable. True if released, otherwise False.")]
		public FsmBool storeResult;

		public override void Reset()
		{
		}

		public override void OnUpdate()
		{
		}
	}
}
