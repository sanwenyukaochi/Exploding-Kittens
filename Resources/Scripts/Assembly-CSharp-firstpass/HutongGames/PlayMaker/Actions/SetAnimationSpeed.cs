using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Animation)]
	[Tooltip("Sets the Speed of an Animation. Check Every Frame to update the animation time continuously, e.g., if you're manipulating a variable that controls animation speed.")]
	public class SetAnimationSpeed : BaseAnimationAction
	{
		[RequiredField]
		[CheckForComponent(typeof(Animation))]
		[Tooltip("The Game Object playing the animation.")]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[UIHint(UIHint.Animation)]
		[Tooltip("The name of the animation.")]
		public FsmString animName;

		[Tooltip("The desired animation speed. 1= normal, 0.5 = half speed, 2 = double speed.")]
		public FsmFloat speed;

		[Tooltip("Update the speed every frame. Useful if you're using a variable to set Speed.")]
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

		private void DoSetAnimationSpeed(GameObject go)
		{
		}
	}
}
