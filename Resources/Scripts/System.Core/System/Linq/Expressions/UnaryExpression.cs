using System.Diagnostics;
using System.Reflection;

namespace System.Linq.Expressions
{
	[DebuggerTypeProxy(typeof(UnaryExpressionProxy))]
	public sealed class UnaryExpression : Expression
	{
		public sealed override Type Type { get; }

		public sealed override ExpressionType NodeType { get; }

		public Expression Operand { get; }

		public MethodInfo Method { get; }

		public bool IsLifted => false;

		public bool IsLiftedToNull => false;

		public override bool CanReduce => false;

		private bool IsPrefix => false;

		internal UnaryExpression(ExpressionType nodeType, Expression expression, Type type, MethodInfo method)
		{
		}

		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}

		public override Expression Reduce()
		{
			return null;
		}

		private UnaryExpression FunctionalOp(Expression operand)
		{
			return null;
		}

		private Expression ReduceVariable()
		{
			return null;
		}

		private Expression ReduceMember()
		{
			return null;
		}

		private Expression ReduceIndex()
		{
			return null;
		}

		public UnaryExpression Update(Expression operand)
		{
			return null;
		}
	}
}
