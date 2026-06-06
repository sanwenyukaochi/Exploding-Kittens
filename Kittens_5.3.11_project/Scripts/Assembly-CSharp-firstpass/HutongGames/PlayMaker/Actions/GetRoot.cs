namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets the top most parent of the Game Object.\nIf the game object has no parent, returns itself.")]
	[ActionCategory(ActionCategory.GameObject)]
	public class GetRoot : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The Game Object.")]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the root of the Game Object in a Game Object Variable.")]
		public FsmGameObject storeRoot;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoGetRoot()
		{
		}
	}
}
