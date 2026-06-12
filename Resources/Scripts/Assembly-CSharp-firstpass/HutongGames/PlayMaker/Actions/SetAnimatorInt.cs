using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Sets the value of an integer parameter")]
	public class SetAnimatorInt : FsmStateActionAnimatorBase
	{
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The animator parameter")]
		[RequiredField]
		[UIHint(UIHint.AnimatorInt)]
		public FsmString parameter;

		[Tooltip("The Int value to assign to the animator parameter")]
		public FsmInt Value;

		private string cachedParameter;

		private int paramID;

		private Animator animator => null;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnActionUpdate()
		{
		}

		private void SetParameter()
		{
		}
	}
}
