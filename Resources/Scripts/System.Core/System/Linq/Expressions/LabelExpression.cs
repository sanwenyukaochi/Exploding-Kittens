using System.Diagnostics;

namespace System.Linq.Expressions
{
	[DebuggerTypeProxy(typeof(LabelExpressionProxy))]
	public sealed class LabelExpression : Expression
	{
		public sealed override Type Type => null;

		public sealed override ExpressionType NodeType => default(ExpressionType);

		public LabelTarget Target { get; }

		public Expression DefaultValue { get; }

		internal LabelExpression(LabelTarget label, Expression defaultValue)
		{
		}

		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}

		public LabelExpression Update(LabelTarget target, Expression defaultValue)
		{
			return null;
		}
	}
}
