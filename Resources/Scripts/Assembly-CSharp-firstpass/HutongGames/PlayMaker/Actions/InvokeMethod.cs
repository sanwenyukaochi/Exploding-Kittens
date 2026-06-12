using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.ScriptControl)]
	[Tooltip("Invokes a Method in a Behaviour attached to a Game Object. See Unity InvokeMethod docs.")]
	public class InvokeMethod : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The game object that owns the behaviour.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The behaviour that contains the method.")]
		[UIHint(UIHint.Script)]
		[RequiredField]
		public FsmString behaviour;

		[UIHint(UIHint.Method)]
		[RequiredField]
		[Tooltip("The name of the method to invoke.")]
		public FsmString methodName;

		[Tooltip("Optional time delay in seconds.")]
		[HasFloatSlider(0f, 10f)]
		public FsmFloat delay;

		[Tooltip("Call the method repeatedly.")]
		public FsmBool repeating;

		[Tooltip("Delay between repeated calls in seconds.")]
		[HasFloatSlider(0f, 10f)]
		public FsmFloat repeatDelay;

		[Tooltip("Stop calling the method when the state is exited.")]
		public FsmBool cancelOnExit;

		private MonoBehaviour component;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoInvokeMethod(GameObject go)
		{
		}

		public override void OnExit()
		{
		}
	}
}
