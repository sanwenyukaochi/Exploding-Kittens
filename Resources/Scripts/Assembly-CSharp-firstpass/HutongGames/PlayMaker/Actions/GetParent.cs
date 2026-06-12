namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets the Parent of a Game Object.")]
	[ActionCategory(ActionCategory.GameObject)]
	public class GetParent : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The Game Object to find the parent of.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("Store the parent object (or null if no parent) in a variable.")]
		[UIHint(UIHint.Variable)]
		public FsmGameObject storeResult;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
