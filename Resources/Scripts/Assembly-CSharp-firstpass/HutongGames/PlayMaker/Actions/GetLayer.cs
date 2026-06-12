namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets a Game Object's Layer and stores it in an Int Variable.")]
	[ActionCategory(ActionCategory.GameObject)]
	public class GetLayer : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The Game Object to examine.")]
		public FsmGameObject gameObject;

		[Tooltip("Store the Layer in an Int Variable.")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmInt storeResult;

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

		private void DoGetLayer()
		{
		}
	}
}
