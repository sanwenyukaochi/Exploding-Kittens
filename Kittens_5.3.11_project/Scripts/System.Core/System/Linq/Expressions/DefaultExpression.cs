using System.Diagnostics;

namespace System.Linq.Expressions
{
	[DebuggerTypeProxy(typeof(DefaultExpressionProxy))]
	public sealed class DefaultExpression : Expression
	{
		public sealed override Type Type { get; }

		public sealed override ExpressionType NodeType => default(ExpressionType);

		internal DefaultExpression(Type type)
		{
		}

		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}
	}
}
