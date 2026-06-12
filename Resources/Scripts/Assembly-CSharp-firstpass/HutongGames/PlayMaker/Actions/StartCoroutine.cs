using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Starts a Coroutine in a Behaviour on a Game Object.\nSee Unity <a href=\"http://unity3d.com/support/documentation/ScriptReference/MonoBehaviour.StartCoroutine.html\">StartCoroutine</a> docs for more details.")]
	[ActionCategory(ActionCategory.ScriptControl)]
	public class StartCoroutine : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The Game Object that owns the Behaviour.")]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[UIHint(UIHint.Behaviour)]
		[Tooltip("The Behaviour that contains the method to start as a coroutine.")]
		public FsmString behaviour;

		[UIHint(UIHint.Coroutine)]
		[RequiredField]
		[Tooltip("The name of the coroutine method.")]
		public FunctionCall functionCall;

		[Tooltip("Stop the coroutine when the state is exited.")]
		public bool stopOnExit;

		private MonoBehaviour component;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoStartCoroutine()
		{
		}

		public override void OnExit()
		{
		}
	}
}
