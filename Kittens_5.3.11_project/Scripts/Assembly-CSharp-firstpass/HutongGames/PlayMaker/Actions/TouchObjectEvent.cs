using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Device)]
	[ActionTarget(typeof(GameObject), "gameObject", false)]
	[Tooltip("Sends events when an object is touched. Optionally filter by a fingerID. NOTE: Uses the MainCamera!")]
	public class TouchObjectEvent : FsmStateAction
	{
		[Tooltip("The Game Object to detect touches on.")]
		[CheckForComponent(typeof(Collider))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[Tooltip("How far from the camera is the Game Object pickable.")]
		public FsmFloat pickDistance;

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

		[Tooltip("Store the world position where the object was touched.")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 storeHitPoint;

		[Tooltip("Store the surface normal vector where the object was touched. \nNote, this is a direction vector not a rotation. Use Look At Direction to rotate a GameObject to this direction.")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 storeHitNormal;

		public override void Reset()
		{
		}

		public override void OnUpdate()
		{
		}
	}
}
