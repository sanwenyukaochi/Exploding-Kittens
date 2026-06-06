namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Vector3)]
	[Tooltip("Get Vector3 Length.")]
	public class GetVectorLength : FsmStateAction
	{
		[Tooltip("The Vector3")]
		public FsmVector3 vector3;

		[Tooltip("Store the length (magnitude) of the Vector3 value in a float variable.")]
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
