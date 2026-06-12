using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace System.Linq.Expressions
{
	[DebuggerTypeProxy(typeof(TryExpressionProxy))]
	public sealed class TryExpression : Expression
	{
		public sealed override Type Type { get; }

		public sealed override ExpressionType NodeType => default(ExpressionType);

		public Expression Body { get; }

		public ReadOnlyCollection<CatchBlock> Handlers { get; }

		public Expression Finally { get; }

		public Expression Fault { get; }

		internal TryExpression(Type type, Expression body, Expression @finally, Expression fault, ReadOnlyCollection<CatchBlock> handlers)
		{
		}

		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}

		public TryExpression Update(Expression body, IEnumerable<CatchBlock> handlers, Expression @finally, Expression fault)
		{
			return null;
		}
	}
}
