using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Device)]
	[Tooltip("Sends an event when a swipe is detected.")]
	public class SwipeGestureEvent : FsmStateAction
	{
		[Tooltip("How far a touch has to travel to be considered a swipe. Uses normalized distance (e.g. 1 = 1 screen diagonal distance). Should generally be a very small number.")]
		public FsmFloat minSwipeDistance;

		[Tooltip("Event to send when swipe left detected.")]
		public FsmEvent swipeLeftEvent;

		[Tooltip("Event to send when swipe right detected.")]
		public FsmEvent swipeRightEvent;

		[Tooltip("Event to send when swipe up detected.")]
		public FsmEvent swipeUpEvent;

		[Tooltip("Event to send when swipe down detected.")]
		public FsmEvent swipeDownEvent;

		private float screenDiagonalSize;

		private float minSwipeDistancePixels;

		private bool touchStarted;

		private Vector2 touchStartPos;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void TestForSwipeGesture(Touch touch)
		{
		}
	}
}
