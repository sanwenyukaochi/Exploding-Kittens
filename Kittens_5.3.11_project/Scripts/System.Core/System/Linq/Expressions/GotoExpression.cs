using System.Diagnostics;

namespace System.Linq.Expressions
{
	[DebuggerTypeProxy(typeof(GotoExpressionProxy))]
	public sealed class GotoExpression : Expression
	{
		public sealed override Type Type { get; }

		public sealed override ExpressionType NodeType => default(ExpressionType);

		public Expression Value { get; }

		public LabelTarget Target { get; }

		public GotoExpressionKind Kind { get; }

		internal GotoExpression(GotoExpressionKind kind, LabelTarget target, Expression value, Type type)
		{
		}

		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}

		public GotoExpression Update(LabelTarget target, Expression value)
		{
			return null;
		}
	}
}
