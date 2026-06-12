namespace System.Dynamic
{
	public abstract class UnaryOperationBinder : DynamicMetaObjectBinder
	{
		public DynamicMetaObject FallbackUnaryOperation(DynamicMetaObject target)
		{
			return null;
		}

		public abstract DynamicMetaObject FallbackUnaryOperation(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			return null;
		}
	}
}
