using System.Collections.Generic;
using System.Collections.ObjectModel;
using Mathos.Parser;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Math expression action. Enter the expression using variable names and common math syntax. Uses Mathos parser.")]
	[ActionCategory(ActionCategory.Math)]
	public class MathExpression : FsmStateAction
	{
		public class Property
		{
			public string path;
		}

		[UIHint(UIHint.TextArea)]
		[Tooltip("Expression to evaluate. Accepts float, int, and bool variable names. Also: Time.deltaTime, ")]
		public FsmString expression;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a float variable")]
		public FsmFloat storeResultAsFloat;

		[Tooltip("Store the result in an int variable")]
		[UIHint(UIHint.Variable)]
		public FsmInt storeResultAsInt;

		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		private MathParser parser;

		private string cachedExpression;

		private ReadOnlyCollection<string> tokens;

		private readonly List<NamedVariable> usedVariables;

		public override void Awake()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoMathExpression()
		{
		}

		public double ParseExpression()
		{
			return 0.0;
		}

		private void BuildAndCacheExpression()
		{
		}
	}
}
