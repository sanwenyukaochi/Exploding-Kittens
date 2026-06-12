using System.ComponentModel;
using System.Diagnostics;

namespace System.Runtime.CompilerServices
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerStepThrough]
	public class RuleCache<T> where T : class
	{
		private T[] _rules;

		private readonly object _cacheLock;

		internal RuleCache()
		{
		}

		internal T[] GetRules()
		{
			return null;
		}

		internal void MoveRule(T rule, int i)
		{
		}

		internal void AddRule(T newRule)
		{
		}

		private static T[] AddOrInsert(T[] rules, T item)
		{
			return null;
		}
	}
}
