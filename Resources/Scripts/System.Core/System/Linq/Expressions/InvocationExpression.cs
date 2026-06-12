using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace System.Linq.Expressions
{
	[DebuggerTypeProxy(typeof(InvocationExpressionProxy))]
	public class InvocationExpression : Expression, IArgumentProvider
	{
		public sealed override Type Type { get; }

		public sealed override ExpressionType NodeType => default(ExpressionType);

		public Expression Expression { get; }

		[ExcludeFromCodeCoverage]
		public virtual int ArgumentCount => 0;

		internal InvocationExpression(Expression expression, Type returnType)
		{
		}

		[ExcludeFromCodeCoverage]
		public virtual Expression GetArgument(int index)
		{
			return null;
		}

		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}

		[ExcludeFromCodeCoverage]
		internal virtual InvocationExpression Rewrite(Expression lambda, Expression[] arguments)
		{
			return null;
		}
	}
}
