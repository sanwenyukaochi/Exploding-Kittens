namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets a Random Child of a Game Object.")]
	[ActionCategory(ActionCategory.GameObject)]
	public class GetRandomChild : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The parent Game Object.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("Store the random child in a Game Object Variable.")]
		[UIHint(UIHint.Variable)]
		[RequiredField]
		public FsmGameObject storeResult;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoGetRandomChild()
		{
		}
	}
}
