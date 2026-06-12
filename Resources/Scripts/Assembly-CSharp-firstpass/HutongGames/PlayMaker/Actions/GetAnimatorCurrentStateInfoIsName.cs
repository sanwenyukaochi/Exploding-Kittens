using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Check the current State name on a specified layer, this is more than the layer name, it holds the current state as well.")]
	[ActionCategory(ActionCategory.Animator)]
	public class GetAnimatorCurrentStateInfoIsName : FsmStateActionAnimatorBase
	{
		[Tooltip("The target. An Animator component and a PlayMakerAnimatorProxy component are required")]
		[CheckForComponent(typeof(Animator))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("The layer's index")]
		[RequiredField]
		public FsmInt layerIndex;

		[Tooltip("The name to check the layer against.")]
		public FsmString name;

		[UIHint(UIHint.Variable)]
		[Tooltip("True if name matches")]
		[ActionSection("Results")]
		public FsmBool isMatching;

		[Tooltip("Event send if name matches")]
		public FsmEvent nameMatchEvent;

		[Tooltip("Event send if name doesn't match")]
		public FsmEvent nameDoNotMatchEvent;

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

		private void IsName()
		{
		}
	}
}
