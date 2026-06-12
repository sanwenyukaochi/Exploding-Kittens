namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Vector3)]
	[Tooltip("Sets the XYZ channels of a Vector3 Variable. To leave any channel unchanged, set variable to 'None'.")]
	public class SetVector3XYZ : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Vector3 variable to set.")]
		public FsmVector3 vector3Variable;

		[Tooltip("Set using another Vector3 variable and/or individual channels below.")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 vector3Value;

		[Tooltip("Set X channel.")]
		public FsmFloat x;

		[Tooltip("Set Y channel.")]
		public FsmFloat y;

		[Tooltip("Set Z channel.")]
		public FsmFloat z;

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

		private void DoSetVector3XYZ()
		{
		}
	}
}
