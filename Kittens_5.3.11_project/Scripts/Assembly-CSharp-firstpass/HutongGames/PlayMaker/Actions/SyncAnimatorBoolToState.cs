using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Syncs the value of an Animator Bool parameter to the current state. Sets the parameter to true when entering the state and false when exiting. For example, you can setup an animator with one animation per state with transition conditions based on the Bool parameter, then sync animator states with this FSM's states using this action.")]
	[ActionCategory(ActionCategory.Animator)]
	public class SyncAnimatorBoolToState : ComponentAction<Animator>
	{
		[Tooltip("The GameObject with the Animator component.")]
		[CheckForComponent(typeof(Animator))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("The bool parameter to sync. Set to true when the state is entered and false when the state exits.")]
		[UIHint(UIHint.AnimatorBool)]
		[RequiredField]
		public FsmString parameter;

		private int paramID;

		private Animator animator => null;

		public override void Awake()
		{
		}

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnExit()
		{
		}
	}
}
