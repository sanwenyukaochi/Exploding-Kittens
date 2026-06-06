using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Gets the value of a float parameter")]
	public class GetAnimatorFloat : FsmStateActionAnimatorBase
	{
		[RequiredField]
		[Tooltip("The GameObject with an Animator Component.")]
		[CheckForComponent(typeof(Animator))]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.AnimatorFloat)]
		[RequiredField]
		[Tooltip("The animator parameter")]
		public FsmString parameter;

		[UIHint(UIHint.Variable)]
		[Tooltip("The float value of the animator parameter")]
		[RequiredField]
		public FsmFloat result;

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
