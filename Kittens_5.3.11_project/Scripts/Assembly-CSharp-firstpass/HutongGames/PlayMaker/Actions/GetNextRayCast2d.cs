using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Iterate through a list of all colliders detected by a RayCastThe colliders iterated are sorted in order of increasing Z coordinate. No iteration will take place if there are no colliders within the area.")]
	public class GetNextRayCast2d : FsmStateAction
	{
		[Tooltip("Start ray at game object position. \nOr use From Position parameter.")]
		[ActionSection("Setup")]
		public FsmOwnerDefault fromGameObject;

		[Tooltip("Start ray at a vector2 world position. \nOr use Game Object parameter.")]
		public FsmVector2 fromPosition;

		[Tooltip("A vector2 direction vector")]
		public FsmVector2 direction;

		[Tooltip("Cast the ray in world or local space. Note if no Game Object is specified, the direction is in world space.")]
		public Space space;

		[Tooltip("The length of the ray. Set to -1 for infinity.")]
		public FsmFloat distance;

		[Tooltip("Only include objects with a Z coordinate (depth) greater than this value. leave to none for no effect")]
		public FsmInt minDepth;

		[Tooltip("Only include objects with a Z coordinate (depth) less than this value. leave to none")]
		public FsmInt maxDepth;

		[Tooltip("If you want to reset the iteration, raise this flag to true when you enter the state, it will indicate you want to start from the beginning again")]
		[UIHint(UIHint.Variable)]
		public FsmBool resetFlag;

		[UIHint(UIHint.Layer)]
		[ActionSection("Filter")]
		[Tooltip("Pick only from these layers.")]
		public FsmInt[] layerMask;

		[Tooltip("Invert the mask, so you pick from all layers except those defined above.")]
		public FsmBool invertMask;

		[Tooltip("Store the number of colliders found for this overlap.")]
		[ActionSection("Result")]
		[UIHint(UIHint.Variable)]
		public FsmInt collidersCount;

		[Tooltip("Store the next collider in a GameObject variable.")]
		[UIHint(UIHint.Variable)]
		public FsmGameObject storeNextCollider;

		[UIHint(UIHint.Variable)]
		[Tooltip("Get the 2d position of the next ray hit point and store it in a variable.")]
		public FsmVector2 storeNextHitPoint;

		[Tooltip("Get the 2d normal at the next hit point and store it in a variable.\nNote, this is a direction vector not a rotation.")]
		[UIHint(UIHint.Variable)]
		public FsmVector2 storeNextHitNormal;

		[Tooltip("Get the distance along the ray to the next hit point and store it in a variable.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat storeNextHitDistance;

		[Tooltip("Get the fraction along the ray to the hit point and store it in a variable. If the ray's direction vector is normalized then this value is simply the distance between the origin and the hit point. If the direction is not normalized then this distance is expressed as a 'fraction' (which could be greater than 1) of the vector's magnitude.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat storeNextHitFraction;

		[Tooltip("Event to send to get the next collider.")]
		public FsmEvent loopEvent;

		[Tooltip("Event to send when there are no more colliders to iterate.")]
		public FsmEvent finishedEvent;

		private RaycastHit2D[] hits;

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

		private RaycastHit2D[] GetRayCastAll()
		{
			return null;
		}
	}
}
