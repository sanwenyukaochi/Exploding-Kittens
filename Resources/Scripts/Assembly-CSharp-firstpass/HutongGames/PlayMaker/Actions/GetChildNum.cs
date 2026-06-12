using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Gets the Child of a GameObject by Index.\nE.g., O to get the first child. HINT: Use this with an integer variable to iterate through children.")]
	public class GetChildNum : FsmStateAction
	{
		[Tooltip("The GameObject to search.")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[Tooltip("The index of the child to find (0 = first child).")]
		public FsmInt childIndex;

		[Tooltip("Store the child in a GameObject variable.")]
		[UIHint(UIHint.Variable)]
		[RequiredField]
		public FsmGameObject store;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private GameObject DoGetChildNum(GameObject go)
		{
			return null;
		}
	}
}
