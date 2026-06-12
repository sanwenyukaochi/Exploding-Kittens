using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Sets the value of a float parameter")]
	public class SetAnimatorFloat : FsmStateActionAnimatorBase
	{
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The animator parameter")]
		[RequiredField]
		[UIHint(UIHint.AnimatorFloat)]
		public FsmString parameter;

		[Tooltip("The float value to assign to the animator parameter")]
		public FsmFloat Value;

		[Tooltip("Optional: The time allowed to parameter to reach the value. Requires Every Frame to be checked.")]
		public FsmFloat dampTime;

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
