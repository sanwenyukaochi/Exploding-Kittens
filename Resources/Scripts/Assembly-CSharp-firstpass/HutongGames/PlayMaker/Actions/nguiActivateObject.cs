namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets NGUI object to be activated or deactivated")]
	[ActionCategory("Ngui Actions")]
	public class nguiActivateObject : FsmStateAction
	{
		[Tooltip("NGUI object to be activated or deactivated")]
		[RequiredField]
		public FsmOwnerDefault NguiObject;

		[Tooltip("Activate nGui GameObject. If False the game object will be Deactivated")]
		[RequiredField]
		public FsmBool setActive;

		[Tooltip("When true, runs on every frame")]
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

		private void DoSetActive()
		{
		}
	}
}
