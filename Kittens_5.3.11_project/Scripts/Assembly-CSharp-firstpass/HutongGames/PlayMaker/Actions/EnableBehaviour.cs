using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Enables/Disables a Behaviour on a GameObject. Optionally reset the Behaviour on exiting the state. E.g., if you want the Behaviour to be active only while this state is active.")]
	[ActionCategory(ActionCategory.ScriptControl)]
	public class EnableBehaviour : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The GameObject that owns the Behaviour.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The name of the Behaviour to enable/disable.")]
		[UIHint(UIHint.Behaviour)]
		public FsmString behaviour;

		[Tooltip("Optionally drag a component directly into this field (behavior name will be ignored).")]
		public Component component;

		[RequiredField]
		[Tooltip("Set to True to enable, False to disable.")]
		public FsmBool enable;

		[Tooltip("Reset the enabled state of the Behaviour when leaving this state.")]
		public FsmBool resetOnExit;

		private Behaviour componentTarget;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoEnableBehaviour(GameObject go)
		{
		}

		public override void OnExit()
		{
		}

		public override string ErrorCheck()
		{
			return null;
		}
	}
}
