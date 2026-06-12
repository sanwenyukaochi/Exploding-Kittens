using System.Diagnostics;

namespace System.Linq.Expressions
{
	[DebuggerTypeProxy(typeof(TypeBinaryExpressionProxy))]
	public sealed class TypeBinaryExpression : Expression
	{
		public sealed override Type Type => null;

		public sealed override ExpressionType NodeType { get; }

		public Expression Expression { get; }

		public Type TypeOperand { get; }

		internal TypeBinaryExpression(Expression expression, Type typeOperand, ExpressionType nodeType)
		{
		}

		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}

		public TypeBinaryExpression Update(Expression expression)
		{
			return null;
		}
	}
}
