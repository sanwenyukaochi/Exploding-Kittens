namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Gets the Game Object that owns the FSM and stores it in a Game Object variable.")]
	public class GetOwner : FsmStateAction
	{
		[Tooltip("Store the Owner in a Game Object variable.")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmGameObject storeGameObject;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
