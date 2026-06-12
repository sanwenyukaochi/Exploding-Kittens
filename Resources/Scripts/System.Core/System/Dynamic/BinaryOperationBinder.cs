using System.Linq.Expressions;

namespace System.Dynamic
{
	public abstract class BinaryOperationBinder : DynamicMetaObjectBinder
	{
		public ExpressionType Operation { get; }

		public DynamicMetaObject FallbackBinaryOperation(DynamicMetaObject target, DynamicMetaObject arg)
		{
			return null;
		}

		public abstract DynamicMetaObject FallbackBinaryOperation(DynamicMetaObject target, DynamicMetaObject arg, DynamicMetaObject errorSuggestion);

		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			return null;
		}
	}
}
