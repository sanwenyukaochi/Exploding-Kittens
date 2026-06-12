using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Tests if 2 Rects overlap.")]
	[ActionCategory(ActionCategory.Rect)]
	public class RectOverlaps : FsmStateAction
	{
		[RequiredField]
		[Tooltip("First Rectangle.")]
		public FsmRect rect1;

		[RequiredField]
		[Tooltip("Second Rectangle.")]
		public FsmRect rect2;

		[Tooltip("Event to send if the Rects overlap.")]
		public FsmEvent trueEvent;

		[Tooltip("Event to send if the Rects do not overlap.")]
		public FsmEvent falseEvent;

		[Tooltip("Store the result in a variable.")]
		[UIHint(UIHint.Variable)]
		public FsmBool storeResult;

		[Tooltip("Repeat every frame.")]
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

		private void DoRectOverlap()
		{
		}

		public static bool Intersect(Rect a, Rect b)
		{
			return false;
		}

		public static void FlipNegative(ref Rect r)
		{
		}
	}
}
