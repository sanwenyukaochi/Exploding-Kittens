using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Flips the horizontal and vertical axes of the RectTransform size and alignment, and optionally its children as well.")]
	[ActionCategory("RectTransform")]
	public class RectTransformFlipLayoutAxis : FsmStateAction
	{
		public enum RectTransformFlipOptions
		{
			Horizontal = 0,
			Vertical = 1,
			Both = 2
		}

		[RequiredField]
		[Tooltip("The GameObject target.")]
		[CheckForComponent(typeof(RectTransform))]
		public FsmOwnerDefault gameObject;

		[Tooltip("The axis to flip")]
		public RectTransformFlipOptions axis;

		[Tooltip("Flips around the pivot if true. Flips within the parent rect if false.")]
		public FsmBool keepPositioning;

		[Tooltip("Flip the children as well?")]
		public FsmBool recursive;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoFlip()
		{
		}
	}
}
