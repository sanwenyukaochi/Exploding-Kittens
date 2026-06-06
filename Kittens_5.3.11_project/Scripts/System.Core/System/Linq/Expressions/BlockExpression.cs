using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace System.Linq.Expressions
{
	[DebuggerTypeProxy(typeof(BlockExpressionProxy))]
	public class BlockExpression : Expression
	{
		public ReadOnlyCollection<Expression> Expressions => null;

		public ReadOnlyCollection<ParameterExpression> Variables => null;

		public sealed override ExpressionType NodeType => default(ExpressionType);

		public override Type Type => null;

		[ExcludeFromCodeCoverage]
		internal virtual int ExpressionCount => 0;

		internal BlockExpression()
		{
		}

		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}

		[ExcludeFromCodeCoverage]
		internal virtual Expression GetExpression(int index)
		{
			return null;
		}

		[ExcludeFromCodeCoverage]
		internal virtual ReadOnlyCollection<Expression> GetOrMakeExpressions()
		{
			return null;
		}

		internal virtual ReadOnlyCollection<ParameterExpression> GetOrMakeVariables()
		{
			return null;
		}

		[ExcludeFromCodeCoverage]
		internal virtual BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args)
		{
			return null;
		}

		internal static ReadOnlyCollection<Expression> ReturnReadOnlyExpressions(BlockExpression provider, ref object collection)
		{
			return null;
		}
	}
}
