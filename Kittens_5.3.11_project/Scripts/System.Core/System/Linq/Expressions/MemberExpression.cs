using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace System.Linq.Expressions
{
	[DebuggerTypeProxy(typeof(MemberExpressionProxy))]
	public class MemberExpression : Expression
	{
		public MemberInfo Member => null;

		public Expression Expression { get; }

		public sealed override ExpressionType NodeType => default(ExpressionType);

		internal MemberExpression(Expression expression)
		{
		}

		internal static PropertyExpression Make(Expression expression, PropertyInfo property)
		{
			return null;
		}

		internal static FieldExpression Make(Expression expression, FieldInfo field)
		{
			return null;
		}

		[ExcludeFromCodeCoverage]
		internal virtual MemberInfo GetMember()
		{
			return null;
		}

		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}

		public MemberExpression Update(Expression expression)
		{
			return null;
		}
	}
}
