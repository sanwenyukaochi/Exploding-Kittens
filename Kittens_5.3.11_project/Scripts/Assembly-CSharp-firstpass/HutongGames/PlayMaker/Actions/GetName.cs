namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Gets the name of a Game Object and stores it in a String Variable.")]
	public class GetName : FsmStateAction
	{
		[Tooltip("The Game Object target.")]
		[RequiredField]
		public FsmGameObject gameObject;

		[Tooltip("Store the Game Object name in a String Variable.")]
		[UIHint(UIHint.Variable)]
		[RequiredField]
		public FsmString storeName;

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

		private void DoGetGameObjectName()
		{
		}
	}
}
