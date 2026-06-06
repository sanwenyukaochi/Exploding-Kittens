using System;
using System.Reflection;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Lets you call a method in a script on a Game Object.\nUnlike {{Invoke Method}}, or {{Send Message}}, you can use multiple parameters and get a return value.")]
	[ActionCategory(ActionCategory.ScriptControl)]
	public class CallMethod : FsmStateAction
	{
		[Tooltip("The behaviour on a Game Object that has the method you want to call. Drag the script component from the Unity inspector into this slot. HINT: Use Lock if the script is on another GameObject.\n\nNOTE: Unity Object fields show the GameObject name, so for clarity we show the Behaviour name as well below.")]
		[ObjectType(typeof(Component))]
		public FsmObject behaviour;

		[Tooltip("Select from a list of available methods.\n\nNOTE: The full method signature is visible below.")]
		public FsmString methodName;

		[Tooltip("Method parameters.\n\nNOTE: This UI is built automatically when you select the method.")]
		public FsmVar[] parameters;

		[ActionSection("Store Result")]
		[UIHint(UIHint.Variable)]
		[Tooltip("If the Method has a return, use this to store it in a variable.")]
		public FsmVar storeResult;

		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		[Tooltip("Revert to the old Manual UI where all parameters had to be configured manually.")]
		public bool manualUI;

		private FsmObject cachedBehaviour;

		private FsmString cachedMethodName;

		private Type cachedType;

		private MethodInfo cachedMethodInfo;

		private ParameterInfo[] cachedParameterInfo;

		private object[] parametersArray;

		private string errorString;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoMethodCall()
		{
		}

		private bool NeedToUpdateCache()
		{
			return false;
		}

		private void ClearCache()
		{
		}

		private bool DoCache()
		{
			return false;
		}

		public override string ErrorCheck()
		{
			return null;
		}
	}
}
