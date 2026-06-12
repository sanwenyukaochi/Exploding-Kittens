namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("Ngui Actions")]
	[Tooltip("Sets NGUI object to be activated or deactivated")]
	public class nguiEnableButtons : FsmStateAction
	{
		[CompoundArray("How many", "Object", "setEnable")]
		[RequiredField]
		public FsmGameObject[] nguiObject;

		[Tooltip("Activate nGui GameObject. If False the game object will be Deactivated")]
		public FsmBool[] setEnable;

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

		private void DoSetEnable()
		{
		}
	}
}
