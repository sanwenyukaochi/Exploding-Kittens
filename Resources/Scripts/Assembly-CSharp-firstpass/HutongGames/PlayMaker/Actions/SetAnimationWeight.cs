using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Animation)]
	[Tooltip("Sets the Blend Weight of an Animation. Check Every Frame to update the weight continuously, e.g., if you're manipulating a variable that controls the weight.")]
	public class SetAnimationWeight : BaseAnimationAction
	{
		[CheckForComponent(typeof(Animation))]
		[RequiredField]
		[Tooltip("The Game Object playing the animation.")]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.Animation)]
		[Tooltip("The name of the animation.")]
		[RequiredField]
		public FsmString animName;

		[Tooltip("The weight to set the animation to.")]
		public FsmFloat weight;

		[Tooltip("Perform this action every frame. Useful if Weight is a variable.")]
		public bool everyFrame;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoSetAnimationWeight(GameObject go)
		{
		}
	}
}
