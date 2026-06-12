using System;
using System.Reflection;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Call a static method in a class.\nNOTE: This is an advanced action - you need to know the full method signature to use this action.")]
	[ActionCategory(ActionCategory.ScriptControl)]
	public class CallStaticMethod : FsmStateAction
	{
		[Tooltip("Full path to the class that contains the static method.")]
		public FsmString className;

		[Tooltip("The static method to call.")]
		public FsmString methodName;

		[Tooltip("Method parameters. NOTE: these must match the method's signature!")]
		public FsmVar[] parameters;

		[ActionSection("Store Result")]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result of the method call.")]
		public FsmVar storeResult;

		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		private Type cachedType;

		private string cachedClassName;

		private string cachedMethodName;

		private MethodInfo cachedMethodInfo;

		private ParameterInfo[] cachedParameterInfo;

		private object[] parametersArray;

		private string errorString;

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoMethodCall()
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
