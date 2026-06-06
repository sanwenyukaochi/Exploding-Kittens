using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Controls culling of this Animator component.")]
	public class SetAnimatorCullingMode : ComponentAction<Animator>
	{
		[Tooltip("The GameObject with an Animator Component.")]
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		public FsmOwnerDefault gameObject;

		[Tooltip("If true, always animate the entire character. If false, animation updates are disabled when renderers are not visible")]
		public FsmBool alwaysAnimate;

		[Tooltip("If true, animation is completely disabled when renderers are not visible")]
		public FsmBool cullCompletely;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
