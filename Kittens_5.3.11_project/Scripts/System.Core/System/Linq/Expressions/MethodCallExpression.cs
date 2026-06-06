using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace System.Linq.Expressions
{
	[DebuggerTypeProxy(typeof(MethodCallExpressionProxy))]
	public class MethodCallExpression : Expression, IArgumentProvider
	{
		public sealed override ExpressionType NodeType => default(ExpressionType);

		public sealed override Type Type => null;

		public MethodInfo Method { get; }

		public Expression Object => null;

		[ExcludeFromCodeCoverage]
		public virtual int ArgumentCount => 0;

		internal MethodCallExpression(MethodInfo method)
		{
		}

		internal virtual Expression GetInstance()
		{
			return null;
		}

		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}

		[ExcludeFromCodeCoverage]
		internal virtual MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args)
		{
			return null;
		}

		[ExcludeFromCodeCoverage]
		public virtual Expression GetArgument(int index)
		{
			return null;
		}
	}
}
