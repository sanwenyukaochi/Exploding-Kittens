using System.Diagnostics;

namespace System.Linq.Expressions
{
	[DebuggerTypeProxy(typeof(LoopExpressionProxy))]
	public sealed class LoopExpression : Expression
	{
		public sealed override Type Type => null;

		public sealed override ExpressionType NodeType => default(ExpressionType);

		public Expression Body { get; }

		public LabelTarget BreakLabel { get; }

		public LabelTarget ContinueLabel { get; }

		internal LoopExpression(Expression body, LabelTarget @break, LabelTarget @continue)
		{
		}

		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}

		public LoopExpression Update(LabelTarget breakLabel, LabelTarget continueLabel, Expression body)
		{
			return null;
		}
	}
}
