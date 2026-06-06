namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Gets a Random Game Object from the scene.\nOptionally filter by Tag.")]
	public class GetRandomObject : FsmStateAction
	{
		[UIHint(UIHint.Tag)]
		[Tooltip("Only select from Game Objects with this Tag.")]
		public FsmString withTag;

		[RequiredField]
		[Tooltip("Store the result in a GameObject Variable.")]
		[UIHint(UIHint.Variable)]
		public FsmGameObject storeResult;

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

		private void DoGetRandomObject()
		{
		}
	}
}
