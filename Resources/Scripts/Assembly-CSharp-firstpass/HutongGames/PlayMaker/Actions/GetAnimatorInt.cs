using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Gets the value of an int parameter.")]
	public class GetAnimatorInt : FsmStateActionAnimatorBase
	{
		[CheckForComponent(typeof(Animator))]
		[RequiredField]
		[Tooltip("The GameObject with an Animator Component.")]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[UIHint(UIHint.AnimatorInt)]
		[Tooltip("The animator parameter")]
		public FsmString parameter;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The int value of the animator parameter")]
		public FsmInt result;

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
