namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Time)]
	[Tooltip("Scales time: 1 = normal, 0.5 = half speed, 2 = double speed.")]
	public class ScaleTime : FsmStateAction
	{
		[RequiredField]
		[HasFloatSlider(0f, 4f)]
		[Tooltip("Scales time: 1 = normal, 0.5 = half speed, 2 = double speed.")]
		public FsmFloat timeScale;

		[Tooltip("Adjust the fixed physics time step to match the time scale.")]
		public FsmBool adjustFixedDeltaTime;

		[Tooltip("Repeat every frame. Useful when animating the value.")]
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

		private void DoTimeScale()
		{
		}
	}
}
