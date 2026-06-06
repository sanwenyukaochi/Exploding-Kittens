using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Array)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Obsolete("This action was wip and accidentally released.")]
	[Tooltip("Set an item in an Array Variable in another FSM.")]
	public class FsmArraySet : FsmStateAction
	{
		[Tooltip("The GameObject that owns the FSM.")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object.")]
		public FsmString fsmName;

		[RequiredField]
		[Tooltip("The name of the FSM variable.")]
		public FsmString variableName;

		[Tooltip("Set the value of the variable.")]
		public FsmString setValue;

		[Tooltip("Repeat every frame. Useful if the value is changing.")]
		public bool everyFrame;

		private GameObject goLastFrame;

		private PlayMakerFSM fsm;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoSetFsmString()
		{
		}

		public override void OnUpdate()
		{
		}
	}
}
