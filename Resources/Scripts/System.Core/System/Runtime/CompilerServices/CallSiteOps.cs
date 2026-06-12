using System.ComponentModel;
using System.Diagnostics;

namespace System.Runtime.CompilerServices
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerStepThrough]
	public static class CallSiteOps
	{
		[Obsolete("do not use this method", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static CallSite<T> CreateMatchmaker<T>(CallSite<T> site) where T : class
		{
			return null;
		}

		[Obsolete("do not use this method", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static bool SetNotMatched(CallSite site)
		{
			return false;
		}

		[Obsolete("do not use this method", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static bool GetMatch(CallSite site)
		{
			return false;
		}

		[Obsolete("do not use this method", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void ClearMatch(CallSite site)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("do not use this method", true)]
		public static void AddRule<T>(CallSite<T> site, T rule) where T : class
		{
		}

		[Obsolete("do not use this method", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void UpdateRules<T>(CallSite<T> @this, int matched) where T : class
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("do not use this method", true)]
		public static T[] GetRules<T>(CallSite<T> site) where T : class
		{
			return null;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("do not use this method", true)]
		public static RuleCache<T> GetRuleCache<T>(CallSite<T> site) where T : class
		{
			return null;
		}

		[Obsolete("do not use this method", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void MoveRule<T>(RuleCache<T> cache, T rule, int i) where T : class
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("do not use this method", true)]
		public static T[] GetCachedRules<T>(RuleCache<T> cache) where T : class
		{
			return null;
		}

		[Obsolete("do not use this method", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static T Bind<T>(CallSiteBinder binder, CallSite<T> site, object[] args) where T : class
		{
			return null;
		}
	}
}
