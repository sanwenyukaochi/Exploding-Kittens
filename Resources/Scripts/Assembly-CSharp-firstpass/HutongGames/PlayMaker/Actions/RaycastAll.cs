using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Physics)]
	[Tooltip("Casts a Ray against all Colliders in the scene. Use either a GameObject or Vector3 world position as the origin of the ray. Use GetRaycastAllInfo to get more detailed info.")]
	public class RaycastAll : FsmStateAction
	{
		public static RaycastHit[] RaycastAllHitInfo;

		[Tooltip("Start ray at game object position. \nOr use From Position parameter.")]
		public FsmOwnerDefault fromGameObject;

		[Tooltip("Start ray at a vector3 world position. \nOr use Game Object parameter.")]
		public FsmVector3 fromPosition;

		[Tooltip("A vector3 direction vector")]
		public FsmVector3 direction;

		[Tooltip("Cast the ray in world or local space. Note if no Game Object is specified, the direction is in world space.")]
		public Space space;

		[Tooltip("The length of the ray. Set to -1 for infinity.")]
		public FsmFloat distance;

		[ActionSection("Result")]
		[Tooltip("Event to send if the ray hits an object.")]
		[UIHint(UIHint.Variable)]
		public FsmEvent hitEvent;

		[Tooltip("Set a bool variable to true if hit something, otherwise false.")]
		[UIHint(UIHint.Variable)]
		public FsmBool storeDidHit;

		[Tooltip("Store the GameObjects hit in an array variable.")]
		[ArrayEditor(VariableType.GameObject, null, 0, 0, 65536)]
		[UIHint(UIHint.Variable)]
		public FsmArray storeHitObjects;

		[UIHint(UIHint.Variable)]
		[Tooltip("Get the world position of the ray hit point and store it in a variable.")]
		public FsmVector3 storeHitPoint;

		[Tooltip("Get the normal at the hit point and store it in a variable.\nNote, this is a direction vector not a rotation. Use Look At Direction to rotate a GameObject to this direction.")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 storeHitNormal;

		[UIHint(UIHint.Variable)]
		[Tooltip("Get the distance along the ray to the hit point and store it in a variable.")]
		public FsmFloat storeHitDistance;

		[ActionSection("Filter")]
		[Tooltip("Set how often to cast a ray. 0 = once, don't repeat; 1 = everyFrame; 2 = every other frame... \nBecause raycasts can get expensive use the highest repeat interval you can get away with.")]
		public FsmInt repeatInterval;

		[Tooltip("Pick only from these layers.")]
		[UIHint(UIHint.Layer)]
		public FsmInt[] layerMask;

		[Tooltip("Invert the mask, so you pick from all layers except those defined above.")]
		public FsmBool invertMask;

		[ActionSection("Debug")]
		[Tooltip("The color to use for the debug line.")]
		public FsmColor debugColor;

		[Tooltip("Draw a debug line. Note: Check Gizmos in the Game View to see it in game.")]
		public FsmBool debug;

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
