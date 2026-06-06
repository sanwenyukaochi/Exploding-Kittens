using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Gets the Scale of a Game Object and stores it in a Vector3 Variable or each Axis in a Float Variable")]
	public class GetScale : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The Game Object.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("Store the scale in a Vector3 variable.")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 vector;

		[Tooltip("Store the X scale in a Float variable.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat xScale;

		[Tooltip("Store the Y scale in a Float variable.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat yScale;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the Z scale in a Float variable.")]
		public FsmFloat zScale;

		[Tooltip("The coordinate space to get the rotation in.")]
		public Space space;

		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoGetScale()
		{
		}
	}
}
