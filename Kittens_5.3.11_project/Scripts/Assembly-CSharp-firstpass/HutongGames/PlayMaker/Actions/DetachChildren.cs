using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Unparents all children from the Game Object.")]
	[ActionCategory(ActionCategory.GameObject)]
	public class DetachChildren : FsmStateAction
	{
		[Tooltip("GameObject to unparent children from.")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private static void DoDetachChildren(GameObject go)
		{
		}
	}
}
