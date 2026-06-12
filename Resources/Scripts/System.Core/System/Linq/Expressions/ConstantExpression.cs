using System.Diagnostics;

namespace System.Linq.Expressions
{
	[DebuggerTypeProxy(typeof(ConstantExpressionProxy))]
	public class ConstantExpression : Expression
	{
		public override Type Type => null;

		public sealed override ExpressionType NodeType => default(ExpressionType);

		public object Value { get; }

		internal ConstantExpression(object value)
		{
		}

		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}
	}
}
