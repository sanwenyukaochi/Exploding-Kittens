using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sends an Event after an optional delay. NOTE: To send events between FSMs they must be marked as Global in the {{Event Browser}}.")]
	[ActionTarget(typeof(PlayMakerFSM), "eventTarget", false)]
	[ActionCategory(ActionCategory.StateMachine)]
	[ActionTarget(typeof(GameObject), "eventTarget", false)]
	public class SendEvent : FsmStateAction
	{
		[Tooltip("Where to send the event.")]
		public FsmEventTarget eventTarget;

		[Tooltip("The event to send. NOTE: Events must be marked Global to send between FSMs.")]
		[RequiredField]
		public FsmEvent sendEvent;

		[HasFloatSlider(0f, 10f)]
		[Tooltip("Optional delay in seconds.")]
		public FsmFloat delay;

		[Tooltip("Repeat every frame. Rarely needed, but can be useful when sending events to other FSMs.")]
		public bool everyFrame;

		private DelayedEvent delayedEvent;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}
	}
}
