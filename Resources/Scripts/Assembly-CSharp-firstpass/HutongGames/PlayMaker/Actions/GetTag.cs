namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets a Game Object's Tag and stores it in a String Variable.")]
	[ActionCategory(ActionCategory.GameObject)]
	public class GetTag : FsmStateAction
	{
		[Tooltip("The Game Object.")]
		[RequiredField]
		public FsmGameObject gameObject;

		[Tooltip("Store the Tag in a String Variable.")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmString storeResult;

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

		private void DoGetTag()
		{
		}
	}
}
