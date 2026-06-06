using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets the pressed state of a Key.")]
	[ActionCategory(ActionCategory.Input)]
	public class GetKey : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The key to test.")]
		public KeyCode key;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store if the key is down (True) or up (False).")]
		public FsmBool storeResult;

		[Tooltip("Repeat every frame. Useful if you're waiting for a key press/release.")]
		public bool everyFrame;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoGetKey()
		{
		}
	}
}
