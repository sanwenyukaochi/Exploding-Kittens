using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Linq
{
	public static class Enumerable
	{
		private abstract class Iterator<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
		{
			private int threadId;

			internal int state;

			internal TSource current;

			public TSource Current => default(TSource);

			object IEnumerator.Current => null;

			public Iterator()
			{
			}

			public abstract Iterator<TSource> Clone();

			public virtual void Dispose()
			{
			}

			public IEnumerator<TSource> GetEnumerator()
			{
				return null;
			}

			public abstract bool MoveNext();

			public abstract IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector);

			public abstract IEnumerable<TSource> Where(Func<TSource, bool> predicate);

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			void IEnumerator.Reset()
			{
			}
		}

		private class WhereEnumerableIterator<TSource> : Iterator<TSource>
		{
			private IEnumerable<TSource> source;

			private Func<TSource, bool> predicate;

			private IEnumerator<TSource> enumerator;

			public WhereEnumerableIterator(IEnumerable<TSource> source, Func<TSource, bool> predicate)
			{
			}

			public override Iterator<TSource> Clone()
			{
				return null;
			}

			public override void Dispose()
			{
			}

			public override bool MoveNext()
			{
				return false;
			}

			public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
			{
				return null;
			}

			public override IEnumerable<TSource> Where(Func<TSource, bool> predicate)
			{
				return null;
			}
		}

		private class WhereArrayIterator<TSource> : Iterator<TSource>
		{
			private TSource[] source;

			private Func<TSource, bool> predicate;

			private int index;

			public WhereArrayIterator(TSource[] source, Func<TSource, bool> predicate)
			{
			}

			public override Iterator<TSource> Clone()
			{
				return null;
			}

			public override bool MoveNext()
			{
				return false;
			}

			public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
			{
				return null;
			}

			public override IEnumerable<TSource> Where(Func<TSource, bool> predicate)
			{
				return null;
			}
		}

		private class WhereListIterator<TSource> : Iterator<TSource>
		{
			private List<TSource> source;

			private Func<TSource, bool> predicate;

			private List<TSource>.Enumerator enumerator;

			public WhereListIterator(List<TSource> source, Func<TSource, bool> predicate)
			{
			}

			public override Iterator<TSource> Clone()
			{
				return null;
			}

			public override bool MoveNext()
			{
				return false;
			}

			public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
			{
				return null;
			}

			public override IEnumerable<TSource> Where(Func<TSource, bool> predicate)
			{
				return null;
			}
		}

		private class WhereSelectEnumerableIterator<TSource, TResult> : Iterator<TResult>
		{
			private IEnumerable<TSource> source;

			private Func<TSource, bool> predicate;

			private Func<TSource, TResult> selector;

			private IEnumerator<TSource> enumerator;

			public WhereSelectEnumerableIterator(IEnumerable<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector)
			{
			}

			public override Iterator<TResult> Clone()
			{
				return null;
			}

			public override void Dispose()
			{
			}

			public override bool MoveNext()
			{
				return false;
			}

			public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
			{
				return null;
			}

			public override IEnumerable<TResult> Where(Func<TResult, bool> predicate)
			{
				return null;
			}
		}

		private class WhereSelectArrayIterator<TSource, TResult> : Iterator<TResult>
		{
			private TSource[] source;

			private Func<TSource, bool> predicate;

			private Func<TSource, TResult> selector;

			private int index;

			public WhereSelectArrayIterator(TSource[] source, Func<TSource, bool> predicate, Func<TSource, TResult> selector)
			{
			}

			public override Iterator<TResult> Clone()
			{
				return null;
			}

			public override bool MoveNext()
			{
				return false;
			}

			public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
			{
				return null;
			}

			public override IEnumerable<TResult> Where(Func<TResult, bool> predicate)
			{
				return null;
			}
		}

		private class WhereSelectListIterator<TSource, TResult> : Iterator<TResult>
		{
			private List<TSource> source;

			private Func<TSource, bool> predicate;

			private Func<TSource, TResult> selector;

			private List<TSource>.Enumerator enumerator;

			public WhereSelectListIterator(List<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector)
			{
			}

			public override Iterator<TResult> Clone()
			{
				return null;
			}

			public override bool MoveNext()
			{
				return false;
			}

			public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
			{
				return null;
			}

			public override IEnumerable<TResult> Where(Func<TResult, bool> predicate)
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CSelectManyIterator_003Ed__17<TSource, TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private TResult _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable<TSource> source;

			public IEnumerable<TSource> _003C_003E3__source;

			private Func<TSource, IEnumerable<TResult>> selector;

			public Func<TSource, IEnumerable<TResult>> _003C_003E3__selector;

			private IEnumerator<TSource> _003C_003E7__wrap1;

			private IEnumerator<TResult> _003C_003E7__wrap2;

			TResult IEnumerator<TResult>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(TResult);
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CSelectManyIterator_003Ed__17(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			private void _003C_003Em__Finally2()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<TResult> IEnumerable<TResult>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CTakeIterator_003Ed__25<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private TSource _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private int count;

			public int _003C_003E3__count;

			private IEnumerable<TSource> source;

			public IEnumerable<TSource> _003C_003E3__source;

			private IEnumerator<TSource> _003C_003E7__wrap1;

			TSource IEnumerator<TSource>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(TSource);
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CTakeIterator_003Ed__25(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<TSource> IEnumerable<TSource>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CSkipIterator_003Ed__31<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private TSource _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable<TSource> source;

			public IEnumerable<TSource> _003C_003E3__source;

			private int count;

			public int _003C_003E3__count;

			private IEnumerator<TSource> _003Ce_003E5__2;

			TSource IEnumerator<TSource>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(TSource);
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CSkipIterator_003Ed__31(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<TSource> IEnumerable<TSource>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CConcatIterator_003Ed__59<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private TSource _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable<TSource> first;

			public IEnumerable<TSource> _003C_003E3__first;

			private IEnumerable<TSource> second;

			public IEnumerable<TSource> _003C_003E3__second;

			private IEnumerator<TSource> _003C_003E7__wrap1;

			TSource IEnumerator<TSource>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(TSource);
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CConcatIterator_003Ed__59(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			private void _003C_003Em__Finally2()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<TSource> IEnumerable<TSource>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CDistinctIterator_003Ed__68<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private TSource _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEqualityComparer<TSource> comparer;

			public IEqualityComparer<TSource> _003C_003E3__comparer;

			private IEnumerable<TSource> source;

			public IEnumerable<TSource> _003C_003E3__source;

			private Set<TSource> _003Cset_003E5__2;

			private IEnumerator<TSource> _003C_003E7__wrap2;

			TSource IEnumerator<TSource>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(TSource);
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CDistinctIterator_003Ed__68(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<TSource> IEnumerable<TSource>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CUnionIterator_003Ed__71<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private TSource _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEqualityComparer<TSource> comparer;

			public IEqualityComparer<TSource> _003C_003E3__comparer;

			private IEnumerable<TSource> first;

			public IEnumerable<TSource> _003C_003E3__first;

			private IEnumerable<TSource> second;

			public IEnumerable<TSource> _003C_003E3__second;

			private Set<TSource> _003Cset_003E5__2;

			private IEnumerator<TSource> _003C_003E7__wrap2;

			TSource IEnumerator<TSource>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(TSource);
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CUnionIterator_003Ed__71(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			private void _003C_003Em__Finally2()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<TSource> IEnumerable<TSource>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CCastIterator_003Ed__99<TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private TResult _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable source;

			public IEnumerable _003C_003E3__source;

			private IEnumerator _003C_003E7__wrap1;

			TResult IEnumerator<TResult>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(TResult);
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCastIterator_003Ed__99(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<TResult> IEnumerable<TResult>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CRangeIterator_003Ed__115 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private int _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private int start;

			public int _003C_003E3__start;

			private int count;

			public int _003C_003E3__count;

			private int _003Ci_003E5__2;

			int IEnumerator<int>.Current
			{
				[DebuggerHidden]
				get
				{
					return 0;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CRangeIterator_003Ed__115(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<int> IEnumerable<int>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CRepeatIterator_003Ed__117<TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private TResult _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private TResult element;

			public TResult _003C_003E3__element;

			private int count;

			public int _003C_003E3__count;

			private int _003Ci_003E5__2;

			TResult IEnumerator<TResult>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(TResult);
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CRepeatIterator_003Ed__117(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<TResult> IEnumerable<TResult>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return null;
		}

		public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
		{
			return null;
		}

		private static Func<TSource, bool> CombinePredicates<TSource>(Func<TSource, bool> predicate1, Func<TSource, bool> predicate2)
		{
			return null;
		}

		private static Func<TSource, TResult> CombineSelectors<TSource, TMiddle, TResult>(Func<TSource, TMiddle> selector1, Func<TMiddle, TResult> selector2)
		{
			return null;
		}

		public static IEnumerable<TResult> SelectMany<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CSelectManyIterator_003Ed__17<, >))]
		private static IEnumerable<TResult> SelectManyIterator<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
		{
			return null;
		}

		public static IEnumerable<TSource> Take<TSource>(this IEnumerable<TSource> source, int count)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CTakeIterator_003Ed__25<>))]
		private static IEnumerable<TSource> TakeIterator<TSource>(IEnumerable<TSource> source, int count)
		{
			return null;
		}

		public static IEnumerable<TSource> Skip<TSource>(this IEnumerable<TSource> source, int count)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CSkipIterator_003Ed__31<>))]
		private static IEnumerable<TSource> SkipIterator<TSource>(IEnumerable<TSource> source, int count)
		{
			return null;
		}

		public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return null;
		}

		public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return null;
		}

		public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return null;
		}

		public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return null;
		}

		public static IEnumerable<TSource> Concat<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CConcatIterator_003Ed__59<>))]
		private static IEnumerable<TSource> ConcatIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			return null;
		}

		public static IEnumerable<TSource> Distinct<TSource>(this IEnumerable<TSource> source)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDistinctIterator_003Ed__68<>))]
		private static IEnumerable<TSource> DistinctIterator<TSource>(IEnumerable<TSource> source, IEqualityComparer<TSource> comparer)
		{
			return null;
		}

		public static IEnumerable<TSource> Union<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CUnionIterator_003Ed__71<>))]
		private static IEnumerable<TSource> UnionIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
		{
			return null;
		}

		public static bool SequenceEqual<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			return false;
		}

		public static bool SequenceEqual<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
		{
			return false;
		}

		public static TSource[] ToArray<TSource>(this IEnumerable<TSource> source)
		{
			return null;
		}

		public static List<TSource> ToList<TSource>(this IEnumerable<TSource> source)
		{
			return null;
		}

		public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return null;
		}

		public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
		{
			return null;
		}

		public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
		{
			return null;
		}

		public static IEnumerable<TResult> Cast<TResult>(this IEnumerable source)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCastIterator_003Ed__99<>))]
		private static IEnumerable<TResult> CastIterator<TResult>(IEnumerable source)
		{
			return null;
		}

		public static TSource First<TSource>(this IEnumerable<TSource> source)
		{
			return default(TSource);
		}

		public static TSource First<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return default(TSource);
		}

		public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source)
		{
			return default(TSource);
		}

		public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return default(TSource);
		}

		public static TSource Last<TSource>(this IEnumerable<TSource> source)
		{
			return default(TSource);
		}

		public static TSource LastOrDefault<TSource>(this IEnumerable<TSource> source)
		{
			return default(TSource);
		}

		public static TSource LastOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return default(TSource);
		}

		public static TSource Single<TSource>(this IEnumerable<TSource> source)
		{
			return default(TSource);
		}

		public static TSource Single<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return default(TSource);
		}

		public static TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source)
		{
			return default(TSource);
		}

		public static TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return default(TSource);
		}

		public static TSource ElementAt<TSource>(this IEnumerable<TSource> source, int index)
		{
			return default(TSource);
		}

		public static IEnumerable<int> Range(int start, int count)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CRangeIterator_003Ed__115))]
		private static IEnumerable<int> RangeIterator(int start, int count)
		{
			return null;
		}

		public static IEnumerable<TResult> Repeat<TResult>(TResult element, int count)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CRepeatIterator_003Ed__117<>))]
		private static IEnumerable<TResult> RepeatIterator<TResult>(TResult element, int count)
		{
			return null;
		}

		public static IEnumerable<TResult> Empty<TResult>()
		{
			return null;
		}

		public static bool Any<TSource>(this IEnumerable<TSource> source)
		{
			return false;
		}

		public static bool Any<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return false;
		}

		public static bool All<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return false;
		}

		public static int Count<TSource>(this IEnumerable<TSource> source)
		{
			return 0;
		}

		public static int Count<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return 0;
		}

		public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value)
		{
			return false;
		}

		public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer)
		{
			return false;
		}

		public static int Sum(this IEnumerable<int> source)
		{
			return 0;
		}

		public static int Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
		{
			return 0;
		}

		public static int Min(this IEnumerable<int> source)
		{
			return 0;
		}

		public static int Max(this IEnumerable<int> source)
		{
			return 0;
		}

		public static int Max<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
		{
			return 0;
		}
	}
}
