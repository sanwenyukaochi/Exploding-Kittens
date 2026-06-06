using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Casts a Ray against all Colliders in the scene. A raycast is conceptually like a laser beam that is fired from a point in space along a particular direction. Any object making contact with the beam can be detected and reported. Use GetRaycastHit2dInfo to get more detailed info.")]
	public class RayCast2d : FsmStateAction
	{
		[ActionSection("Setup")]
		[Tooltip("Start ray at game object position. \nOr use From Position parameter.")]
		public FsmOwnerDefault fromGameObject;

		[Tooltip("Start ray at a vector2 world position, or offset from the GameObject's position.")]
		public FsmVector2 fromPosition;

		[Tooltip("A vector2 direction vector")]
		public FsmVector2 direction;

		[Tooltip("Cast the ray in world or local space. Note if no Game Object is specified, the direction is in world space.")]
		public Space space;

		[Tooltip("The length of the ray. Set to -1 for infinity.")]
		public FsmFloat distance;

		[Tooltip("Only include objects with a Z coordinate (depth) greater than this value. Leave as None for no filtering.")]
		public FsmInt minDepth;

		[Tooltip("Only include objects with a Z coordinate (depth) less than this value. Leave as none for no filtering.")]
		public FsmInt maxDepth;

		[Tooltip("Event to send if the ray hits an object.")]
		[ActionSection("Result")]
		[UIHint(UIHint.Variable)]
		public FsmEvent hitEvent;

		[UIHint(UIHint.Variable)]
		[Tooltip("Set a bool variable to true if hit something, otherwise false.")]
		public FsmBool storeDidHit;

		[Tooltip("Store the game object hit in a variable.")]
		[UIHint(UIHint.Variable)]
		public FsmGameObject storeHitObject;

		[UIHint(UIHint.Variable)]
		[Tooltip("Get the 2d position of the ray hit point and store it in a variable.")]
		public FsmVector2 storeHitPoint;

		[Tooltip("Get the 2d normal at the hit point and store it in a variable. \nNote, this is a direction vector not a rotation.")]
		[UIHint(UIHint.Variable)]
		public FsmVector2 storeHitNormal;

		[Tooltip("Get the distance along the ray to the hit point and store it in a variable.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat storeHitDistance;

		[Tooltip("Get the fraction along the ray to the hit point and store it in a variable. If the ray's direction vector is normalized then this value is simply the distance between the origin and the hit point. If the direction is not normalized then this distance is expressed as a 'fraction' (which could be greater than 1) of the vector's magnitude.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat storeHitFraction;

		[Tooltip("Set how often to cast a ray. 0 = once, don't repeat; 1 = everyFrame; 2 = every other frame... \nBecause raycasts can get expensive use the highest repeat interval you can get away with.")]
		[ActionSection("Filter")]
		public FsmInt repeatInterval;

		[Tooltip("Pick only from these layers.")]
		[UIHint(UIHint.Layer)]
		public FsmInt[] layerMask;

		[Tooltip("Invert the mask, so you pick from all layers except those defined above.")]
		public FsmBool invertMask;

		[Tooltip("The color to use for the debug line.")]
		[ActionSection("Debug")]
		public FsmColor debugColor;

		[Tooltip("Draw a debug line. Note: Check Gizmos in the Game View to see it in game.")]
		public FsmBool debug;

		private Transform _transform;

		private int repeat;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoRaycast()
		{
		}
	}
}
