using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets the Mass of a Game Object's Rigid Body 2D.")]
	[ActionCategory(ActionCategory.Physics2D)]
	public class GetMass2d : ComponentAction<Rigidbody2D>
	{
		[CheckForComponent(typeof(Rigidbody2D))]
		[RequiredField]
		[Tooltip("The GameObject with a Rigidbody2D attached.")]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the mass of gameObject.")]
		public FsmFloat storeResult;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoGetMass()
		{
		}
	}
}
