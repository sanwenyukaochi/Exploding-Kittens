namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Get Vector2 Length.")]
	[ActionCategory(ActionCategory.Vector2)]
	public class GetVector2Length : FsmStateAction
	{
		[Tooltip("The Vector2 to get the length from")]
		public FsmVector2 vector2;

		[Tooltip("The Vector2 the length")]
		[UIHint(UIHint.Variable)]
		[RequiredField]
		public FsmFloat storeLength;

		[Tooltip("Repeat every frame")]
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

		private void DoVectorLength()
		{
		}
	}
}
