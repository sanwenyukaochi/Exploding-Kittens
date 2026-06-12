using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace System.Linq.Expressions
{
	[DebuggerTypeProxy(typeof(LambdaExpressionProxy))]
	public abstract class LambdaExpression : Expression, IParameterProvider
	{
		private readonly Expression _body;

		public sealed override Type Type => null;

		internal abstract Type TypeCore { get; }

		internal abstract Type PublicType { get; }

		public sealed override ExpressionType NodeType => default(ExpressionType);

		public string Name => null;

		internal virtual string NameCore => null;

		public Expression Body => null;

		public Type ReturnType => null;

		public bool TailCall => false;

		internal virtual bool TailCallCore => false;

		[ExcludeFromCodeCoverage]
		int IParameterProvider.ParameterCount => 0;

		[ExcludeFromCodeCoverage]
		internal virtual int ParameterCount => 0;

		internal LambdaExpression(Expression body)
		{
		}

		[ExcludeFromCodeCoverage]
		ParameterExpression IParameterProvider.GetParameter(int index)
		{
			return null;
		}

		[ExcludeFromCodeCoverage]
		internal virtual ParameterExpression GetParameter(int index)
		{
			return null;
		}
	}
}
