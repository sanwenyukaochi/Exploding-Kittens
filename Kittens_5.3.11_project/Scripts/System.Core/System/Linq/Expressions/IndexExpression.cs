using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace System.Linq.Expressions
{
	[DebuggerTypeProxy(typeof(IndexExpressionProxy))]
	public sealed class IndexExpression : Expression, IArgumentProvider
	{
		private IReadOnlyList<Expression> _arguments;

		public sealed override ExpressionType NodeType => default(ExpressionType);

		public sealed override Type Type => null;

		public Expression Object { get; }

		public PropertyInfo Indexer { get; }

		public int ArgumentCount => 0;

		internal IndexExpression(Expression instance, PropertyInfo indexer, IReadOnlyList<Expression> arguments)
		{
		}

		public Expression GetArgument(int index)
		{
			return null;
		}

		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}

		internal Expression Rewrite(Expression instance, Expression[] arguments)
		{
			return null;
		}
	}
}
