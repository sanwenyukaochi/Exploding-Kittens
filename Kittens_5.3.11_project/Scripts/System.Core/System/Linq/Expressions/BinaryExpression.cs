using System.Diagnostics;
using System.Reflection;

namespace System.Linq.Expressions
{
	[DebuggerTypeProxy(typeof(BinaryExpressionProxy))]
	public class BinaryExpression : Expression
	{
		public override bool CanReduce => false;

		public Expression Right { get; }

		public Expression Left { get; }

		public MethodInfo Method => null;

		public LambdaExpression Conversion => null;

		public bool IsLifted => false;

		public bool IsLiftedToNull => false;

		internal bool IsLiftedLogical => false;

		internal bool IsReferenceComparison => false;

		internal BinaryExpression(Expression left, Expression right)
		{
		}

		private static bool IsOpAssignment(ExpressionType op)
		{
			return false;
		}

		internal virtual MethodInfo GetMethod()
		{
			return null;
		}

		public BinaryExpression Update(Expression left, LambdaExpression conversion, Expression right)
		{
			return null;
		}

		public override Expression Reduce()
		{
			return null;
		}

		private static ExpressionType GetBinaryOpFromAssignmentOp(ExpressionType op)
		{
			return default(ExpressionType);
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

		internal virtual LambdaExpression GetConversion()
		{
			return null;
		}

		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}

		internal Expression ReduceUserdefinedLifted()
		{
			return null;
		}
	}
}
