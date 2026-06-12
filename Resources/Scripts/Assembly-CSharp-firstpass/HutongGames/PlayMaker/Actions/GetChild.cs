using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Finds the Child of a GameObject by Name and/or Tag. Use this to find attach points etc. NOTE: This action will search recursively through all children and return the first match; To find a specific child use Find Child.")]
	public class GetChild : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The GameObject to search.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The name of the child to search for.")]
		public FsmString childName;

		[UIHint(UIHint.Tag)]
		[Tooltip("The Tag to search for. If Child Name is set, both name and Tag need to match.")]
		public FsmString withTag;

		[UIHint(UIHint.Variable)]
		[RequiredField]
		[Tooltip("Store the result in a GameObject variable.")]
		public FsmGameObject storeResult;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private static GameObject DoGetChildByName(GameObject root, string name, string tag)
		{
			return null;
		}

		public override string ErrorCheck()
		{
			return null;
		}
	}
}
