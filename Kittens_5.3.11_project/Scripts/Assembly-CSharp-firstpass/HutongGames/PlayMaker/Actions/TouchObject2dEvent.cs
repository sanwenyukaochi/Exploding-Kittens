using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Device)]
	[Tooltip("Sends events when a 2d object is touched. Optionally filter by a fingerID. NOTE: Uses the MainCamera!")]
	public class TouchObject2dEvent : FsmStateAction
	{
		[RequiredField]
		[CheckForComponent(typeof(Collider2D))]
		[Tooltip("The Game Object to detect touches on.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("Only detect touches that match this fingerID, or set to None.")]
		public FsmInt fingerId;

		[Tooltip("Event to send on touch began.")]
		[ActionSection("Events")]
		public FsmEvent touchBegan;

		[Tooltip("Event to send on touch moved.")]
		public FsmEvent touchMoved;

		[Tooltip("Event to send on stationary touch.")]
		public FsmEvent touchStationary;

		[Tooltip("Event to send on touch ended.")]
		public FsmEvent touchEnded;

		[Tooltip("Event to send on touch cancel.")]
		public FsmEvent touchCanceled;

		[ActionSection("Store Results")]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the fingerId of the touch.")]
		public FsmInt storeFingerId;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the 2d position where the object was touched.")]
		public FsmVector2 storeHitPoint;

		public override void Reset()
		{
		}

		public override void OnUpdate()
		{
		}
	}
}
