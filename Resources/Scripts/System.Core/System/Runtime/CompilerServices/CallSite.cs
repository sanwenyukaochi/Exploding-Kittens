using System.Linq.Expressions;
using System.Reflection;

namespace System.Runtime.CompilerServices
{
	public class CallSite
	{
		internal readonly CallSiteBinder _binder;

		internal bool _match;

		public CallSiteBinder Binder => null;

		internal CallSite(CallSiteBinder binder)
		{
		}
	}
	public class CallSite<T> : CallSite where T : class
	{
		public T Target;

		internal T[] Rules;

		private static T s_cachedUpdate;

		private static T s_cachedNoMatch;

		public T Update => null;

		private CallSite(CallSiteBinder binder)
			: base(null)
		{
		}

		private CallSite()
			: base(null)
		{
		}

		internal CallSite<T> CreateMatchMaker()
		{
			return null;
		}

		public static CallSite<T> Create(CallSiteBinder binder)
		{
			return null;
		}

		private T GetUpdateDelegate()
		{
			return null;
		}

		private T GetUpdateDelegate(ref T addr)
		{
			return null;
		}

		internal void AddRule(T newRule)
		{
		}

		internal void MoveRule(int i)
		{
		}

		internal T MakeUpdateDelegate()
		{
			return null;
		}

		private T CreateCustomUpdateDelegate(MethodInfo invoke)
		{
			return null;
		}

		private T CreateCustomNoMatchDelegate(MethodInfo invoke)
		{
			return null;
		}

		private static Expression Convert(Expression arg, Type type)
		{
			return null;
		}
	}
}
