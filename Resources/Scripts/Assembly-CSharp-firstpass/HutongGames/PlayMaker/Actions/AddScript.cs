using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Adds a Script to a Game Object. Use this to change the behaviour of objects on the fly. Optionally remove the Script on exiting the state.")]
	[ActionCategory(ActionCategory.ScriptControl)]
	public class AddScript : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The GameObject to add the script to.")]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[Tooltip("Select any script in your project. The script will be added to the Game Object when the state is entered.")]
		[UIHint(UIHint.ScriptComponent)]
		public FsmString script;

		[Tooltip("Remove the script from the GameObject when this State is exited.")]
		public FsmBool removeOnExit;

		private Component addedComponent;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnExit()
		{
		}

		private void DoAddComponent(GameObject go)
		{
		}
	}
}
