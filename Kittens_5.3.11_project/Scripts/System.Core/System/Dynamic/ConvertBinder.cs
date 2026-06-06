namespace System.Dynamic
{
	public abstract class ConvertBinder : DynamicMetaObjectBinder
	{
		public Type Type { get; }

		public DynamicMetaObject FallbackConvert(DynamicMetaObject target)
		{
			return null;
		}

		public abstract DynamicMetaObject FallbackConvert(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			return null;
		}
	}
}
