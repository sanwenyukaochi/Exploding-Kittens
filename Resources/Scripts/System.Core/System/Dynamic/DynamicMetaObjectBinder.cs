using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace System.Dynamic
{
	public abstract class DynamicMetaObjectBinder : CallSiteBinder
	{
		public virtual Type ReturnType => null;

		internal virtual bool IsStandardBinder => false;

		public sealed override Expression Bind(object[] args, ReadOnlyCollection<ParameterExpression> parameters, LabelTarget returnLabel)
		{
			return null;
		}

		private static DynamicMetaObject[] CreateArgumentMetaObjects(object[] args, ReadOnlyCollection<ParameterExpression> parameters)
		{
			return null;
		}

		public abstract DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args);

		public Expression GetUpdateExpression(Type type)
		{
			return null;
		}
	}
}
