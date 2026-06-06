using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Iterate through a list of all colliders that fall within a rectangular area.The colliders iterated are sorted in order of increasing Z coordinate. No iteration will take place if there are no colliders within the area.")]
	public class GetNextOverlapArea2d : FsmStateAction
	{
		[ActionSection("Setup")]
		[Tooltip("First corner of the rectangle area using the game object position. \nOr use firstCornerPosition parameter.")]
		public FsmOwnerDefault firstCornerGameObject;

		[Tooltip("First Corner of the rectangle area as a world position. \nOr use FirstCornerGameObject parameter. If both define, will add firstCornerPosition to the FirstCornerGameObject position")]
		public FsmVector2 firstCornerPosition;

		[Tooltip("Second corner of the rectangle area using the game object position. \nOr use secondCornerPosition parameter.")]
		public FsmGameObject secondCornerGameObject;

		[Tooltip("Second Corner rectangle area as a world position. \nOr use SecondCornerGameObject parameter. If both define, will add secondCornerPosition to the SecondCornerGameObject position")]
		public FsmVector2 secondCornerPosition;

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

		[Tooltip("Store the number of colliders found for this overlap.")]
		[ActionSection("Result")]
		[UIHint(UIHint.Variable)]
		public FsmInt collidersCount;

		[UIHint(UIHint.Variable)]
		[RequiredField]
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

		private Collider2D[] GetOverlapAreaAll()
		{
			return null;
		}
	}
}
