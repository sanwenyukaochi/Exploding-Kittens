using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Create a dynamic transition between the current state and the destination state. Both states have to be on the same layer. Note: You cannot change the current state on a synchronized layer, you need to change it on the referenced layer.")]
	public class AnimatorCrossFade : ComponentAction<Animator>
	{
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The GameObject with an Animator Component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The name of the state that will be played.")]
		public FsmString stateName;

		[Tooltip("The duration of the transition. Value is in source state normalized time.")]
		public FsmFloat transitionDuration;

		[Tooltip("Layer index containing the destination state. Leave to none to ignore")]
		public FsmInt layer;

		[Tooltip("Start time of the current destination state. Value is in source state normalized time, should be between 0 and 1.")]
		public FsmFloat normalizedTime;

		private Animator animator => null;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
