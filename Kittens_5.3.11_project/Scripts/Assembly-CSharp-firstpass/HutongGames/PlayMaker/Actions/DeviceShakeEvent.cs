namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sends an Event when the mobile device is shaken.")]
	[ActionCategory(ActionCategory.Device)]
	public class DeviceShakeEvent : FsmStateAction
	{
		[RequiredField]
		[Tooltip("Amount of acceleration required to trigger the event. Higher numbers require a harder shake.")]
		public FsmFloat shakeThreshold;

		[Tooltip("Event to send when Shake Threshold is exceeded.")]
		[RequiredField]
		public FsmEvent sendEvent;

		public override void Reset()
		{
		}

		public override void OnUpdate()
		{
		}
	}
}
