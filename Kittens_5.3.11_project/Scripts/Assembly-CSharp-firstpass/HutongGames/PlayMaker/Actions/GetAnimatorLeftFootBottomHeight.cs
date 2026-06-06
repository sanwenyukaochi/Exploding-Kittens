using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Get the left foot bottom height.")]
	[ActionCategory(ActionCategory.Animator)]
	public class GetAnimatorLeftFootBottomHeight : ComponentAction<Animator>
	{
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The GameObject with an Animator Component.")]
		public FsmOwnerDefault gameObject;

		[ActionSection("Result")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("the left foot bottom height.")]
		public FsmFloat leftFootHeight;

		[Tooltip("Repeat every frame. Useful when value is subject to change over time.")]
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

		private void GetLeftFootBottomHeight()
		{
		}
	}
}
