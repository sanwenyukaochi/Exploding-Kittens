using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Set the isTrigger option of a Collider2D. Optionally set all collider2D found on the gameobject Target.")]
	[ActionCategory(ActionCategory.Physics2D)]
	public class SetCollider2dIsTrigger : FsmStateAction
	{
		[RequiredField]
		[CheckForComponent(typeof(Collider2D))]
		[Tooltip("The GameObject with the Collider2D attached")]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[Tooltip("The flag value")]
		public FsmBool isTrigger;

		[Tooltip("Set all Colliders on the GameObject target")]
		public bool setAllColliders;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoSetIsTrigger()
		{
		}
	}
}
