using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;

namespace System.Runtime.CompilerServices
{
	public abstract class CallSiteBinder
	{
		private sealed class LambdaSignature<T> where T : class
		{
			private static LambdaSignature<T> s_instance;

			internal readonly ReadOnlyCollection<ParameterExpression> Parameters;

			internal readonly LabelTarget ReturnLabel;

			internal static LambdaSignature<T> Instance => null;

			private LambdaSignature()
			{
			}
		}

		internal Dictionary<Type, object> Cache;

		public static LabelTarget UpdateLabel { get; }

		public abstract Expression Bind(object[] args, ReadOnlyCollection<ParameterExpression> parameters, LabelTarget returnLabel);

		public virtual T BindDelegate<T>(CallSite<T> site, object[] args) where T : class
		{
			return null;
		}

		internal T BindCore<T>(CallSite<T> site, object[] args) where T : class
		{
			return null;
		}

		protected void CacheTarget<T>(T target) where T : class
		{
		}

		private static Expression<T> Stitch<T>(Expression binding, LambdaSignature<T> signature) where T : class
		{
			return null;
		}

		internal RuleCache<T> GetRuleCache<T>() where T : class
		{
			return null;
		}
	}
}
