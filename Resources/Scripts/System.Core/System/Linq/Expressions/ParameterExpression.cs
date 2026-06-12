using System.Diagnostics;

namespace System.Linq.Expressions
{
	[DebuggerTypeProxy(typeof(ParameterExpressionProxy))]
	public class ParameterExpression : Expression
	{
		public override Type Type => null;

		public sealed override ExpressionType NodeType => default(ExpressionType);

		public string Name { get; }

		public bool IsByRef => false;

		internal ParameterExpression(string name)
		{
		}

		internal static ParameterExpression Make(Type type, string name, bool isByRef)
		{
			return null;
		}

		internal virtual bool GetIsByRef()
		{
			return false;
		}

		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}
	}
}
