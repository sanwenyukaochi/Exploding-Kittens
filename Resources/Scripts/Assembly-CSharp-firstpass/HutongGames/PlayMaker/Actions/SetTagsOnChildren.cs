using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Set the Tag on all children of a GameObject. Optionally filter by component.")]
	[ActionCategory(ActionCategory.GameObject)]
	public class SetTagsOnChildren : FsmStateAction
	{
		[RequiredField]
		[Tooltip("GameObject Parent")]
		public FsmOwnerDefault gameObject;

		[Tooltip("Set Tag To...")]
		[RequiredField]
		[UIHint(UIHint.Tag)]
		public FsmString tag;

		[Tooltip("Only set the Tag on children with this component.")]
		[UIHint(UIHint.ScriptComponent)]
		public FsmString filterByComponent;

		private Type componentFilter;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void SetTag(GameObject parent)
		{
		}

		private void UpdateComponentFilter()
		{
		}
	}
}
