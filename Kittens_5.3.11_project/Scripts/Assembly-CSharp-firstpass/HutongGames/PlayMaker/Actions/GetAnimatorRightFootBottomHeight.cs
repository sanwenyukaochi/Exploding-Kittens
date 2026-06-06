using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Get the right foot bottom height.")]
	[ActionCategory(ActionCategory.Animator)]
	public class GetAnimatorRightFootBottomHeight : ComponentAction<Animator>
	{
		[Tooltip("The GameObject with an Animator Component.")]
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[ActionSection("Result")]
		[Tooltip("The right foot bottom height.")]
		public FsmFloat rightFootHeight;

		[Tooltip("Repeat every frame during LateUpdate. Useful when value is subject to change over time.")]
		public bool everyFrame;

		public override void Reset()
		{
		}

		public override void OnPreprocess()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnLateUpdate()
		{
		}

		private void GetRightFootBottomHeight()
		{
		}
	}
}
