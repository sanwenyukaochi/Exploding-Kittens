using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Gets the value of a bool parameter")]
	public class GetAnimatorBool : FsmStateActionAnimatorBase
	{
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The GameObject with an Animator Component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The animator parameter")]
		[RequiredField]
		[UIHint(UIHint.AnimatorBool)]
		public FsmString parameter;

		[UIHint(UIHint.Variable)]
		[RequiredField]
		[Tooltip("The bool value of the animator parameter")]
		public FsmBool result;

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

		private void GetParameter()
		{
		}
	}
}
