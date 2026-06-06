using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the playback speed of the Animator. 1 is normal playback speed")]
	[ActionCategory(ActionCategory.Animator)]
	public class SetAnimatorPlayBackSpeed : ComponentAction<Animator>
	{
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The GameObject with an Animator Component.")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("If true, automatically stabilize feet during transition and blending")]
		public FsmFloat playBackSpeed;

		[Tooltip("Repeat every frame. Useful for changing over time.")]
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

		private void DoPlayBackSpeed()
		{
		}
	}
}
