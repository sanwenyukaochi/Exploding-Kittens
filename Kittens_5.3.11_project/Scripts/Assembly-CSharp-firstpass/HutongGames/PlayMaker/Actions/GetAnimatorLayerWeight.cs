using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets the layer's current weight")]
	[ActionCategory(ActionCategory.Animator)]
	public class GetAnimatorLayerWeight : FsmStateActionAnimatorBase
	{
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The layer's index")]
		[RequiredField]
		public FsmInt layerIndex;

		[ActionSection("Results")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The layer's current weight")]
		public FsmFloat layerWeight;

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

		private void GetLayerWeight()
		{
		}
	}
}
