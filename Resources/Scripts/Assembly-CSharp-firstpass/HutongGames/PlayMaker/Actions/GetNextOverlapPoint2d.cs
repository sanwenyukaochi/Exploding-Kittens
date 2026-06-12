using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Iterate through a list of all colliders that overlap a point in space.The colliders iterated are sorted in order of increasing Z coordinate. No iteration will take place if there are no colliders overlap this point.")]
	[ActionCategory(ActionCategory.Physics2D)]
	public class GetNextOverlapPoint2d : FsmStateAction
	{
		[Tooltip("Point using the gameObject position. \nOr use From Position parameter.")]
		[ActionSection("Setup")]
		public FsmOwnerDefault gameObject;

		[Tooltip("Point as a world position. \nOr use gameObject parameter. If both define, will add position to the gameObject position")]
		public FsmVector2 position;

		[Tooltip("Only include objects with a Z coordinate (depth) greater than this value. leave to none for no effect")]
		public FsmInt minDepth;

		[Tooltip("Only include objects with a Z coordinate (depth) less than this value. leave to none")]
		public FsmInt maxDepth;

		[Tooltip("If you want to reset the iteration, raise this flag to true when you enter the state, it will indicate you want to start from the beginning again")]
		[UIHint(UIHint.Variable)]
		public FsmBool resetFlag;

		[ActionSection("Filter")]
		[UIHint(UIHint.Layer)]
		[Tooltip("Pick only from these layers.")]
		public FsmInt[] layerMask;

		[Tooltip("Invert the mask, so you pick from all layers except those defined above.")]
		public FsmBool invertMask;

		[UIHint(UIHint.Variable)]
		[ActionSection("Result")]
		[Tooltip("Store the number of colliders found for this overlap.")]
		public FsmInt collidersCount;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the next collider in a GameObject variable.")]
		public FsmGameObject storeNextCollider;

		[Tooltip("Event to send to get the next collider.")]
		public FsmEvent loopEvent;

		[Tooltip("Event to send when there are no more colliders to iterate.")]
		public FsmEvent finishedEvent;

		private Collider2D[] colliders;

		private int colliderCount;

		private int nextColliderIndex;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoGetNextCollider()
		{
		}

		private Collider2D[] GetOverlapPointAll()
		{
			return null;
		}
	}
}
