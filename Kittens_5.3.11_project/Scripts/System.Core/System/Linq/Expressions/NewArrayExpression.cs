using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace System.Linq.Expressions
{
	[DebuggerTypeProxy(typeof(NewArrayExpressionProxy))]
	public class NewArrayExpression : Expression
	{
		public sealed override Type Type { get; }

		public ReadOnlyCollection<Expression> Expressions { get; }

		internal NewArrayExpression(Type type, ReadOnlyCollection<Expression> expressions)
		{
		}

		internal static NewArrayExpression Make(ExpressionType nodeType, Type type, ReadOnlyCollection<Expression> expressions)
		{
			return null;
		}

		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}

		public NewArrayExpression Update(IEnumerable<Expression> expressions)
		{
			return null;
		}
	}
}
