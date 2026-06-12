using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sends an Event to another Fsm after an optional delay. Specify an Fsm Name or use the first Fsm on the object.")]
	[ActionCategory(ActionCategory.StateMachine)]
	[Obsolete("This action is obsolete; use Send Event with Event Target instead.")]
	public class SendEventToFsm : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The game object that owns the other FSM.")]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object")]
		public FsmString fsmName;

		[Tooltip("The Event to send.")]
		[RequiredField]
		[UIHint(UIHint.FsmEvent)]
		public FsmString sendEvent;

		[HasFloatSlider(0f, 10f)]
		[Tooltip("Optional delay in seconds.")]
		public FsmFloat delay;

		private bool requireReceiver;

		private GameObject go;

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
