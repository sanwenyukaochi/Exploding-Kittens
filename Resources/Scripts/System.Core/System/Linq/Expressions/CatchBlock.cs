using System.Diagnostics;

namespace System.Linq.Expressions
{
	[DebuggerTypeProxy(typeof(Expression.CatchBlockProxy))]
	public sealed class CatchBlock
	{
		public ParameterExpression Variable { get; }

		public Type Test { get; }

		public Expression Body { get; }

		public Expression Filter { get; }

		internal CatchBlock(Type test, ParameterExpression variable, Expression body, Expression filter)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public CatchBlock Update(ParameterExpression variable, Expression filter, Expression body)
		{
			return null;
		}
	}
}
