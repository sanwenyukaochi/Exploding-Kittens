using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Collections.Concurrent
{
	[Serializable]
	[DebuggerTypeProxy(typeof(IProducerConsumerCollectionDebugView<>))]
	[DebuggerDisplay("Count = {Count}")]
	public class ConcurrentQueue<T> : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>
	{
		[DebuggerDisplay("Capacity = {Capacity}")]
		internal sealed class Segment
		{
			[StructLayout((LayoutKind)3)]
			[DebuggerDisplay("Item = {Item}, SequenceNumber = {SequenceNumber}")]
			internal struct Slot
			{
				public T Item;

				public int SequenceNumber;
			}

			internal readonly Slot[] _slots;

			internal readonly int _slotsMask;

			internal PaddedHeadAndTail _headAndTail;

			internal bool _preservedForObservation;

			internal bool _frozenForEnqueues;

			internal Segment _nextSegment;

			internal int Capacity => 0;

			internal int FreezeOffset => 0;

			public Segment(int boundedLength)
			{
			}

			internal void EnsureFrozenForEnqueues()
			{
			}

			public bool TryDequeue(out T item)
			{
				item = default(T);
				return false;
			}

			public bool TryEnqueue(T item)
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003CEnumerate_003Ed__28 : IEnumerator<T>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private T _003C_003E2__current;

			public Segment head;

			public Segment tail;

			public int tailTail;

			public int headHead;

			public ConcurrentQueue<T> _003C_003E4__this;

			private int _003CheadTail_003E5__2;

			private int _003Ci_003E5__3;

			private Segment _003Cs_003E5__4;

			private int _003Ci_003E5__5;

			T IEnumerator<T>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(T);
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
			public _003CEnumerate_003Ed__28(int _003C_003E1__state)
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
		}

		private object _crossSegmentLock;

		private Segment _tail;

		private Segment _head;

		bool ICollection.IsSynchronized => false;

		object ICollection.SyncRoot => null;

		public int Count => 0;

		void ICollection.CopyTo(Array array, int index)
		{
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public T[] ToArray()
		{
			return null;
		}

		private static int GetCount(Segment s, int head, int tail)
		{
			return 0;
		}

		private static long GetCount(Segment head, int headHead, Segment tail, int tailTail)
		{
			return 0L;
		}

		public void CopyTo(T[] array, int index)
		{
		}

		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		private void SnapForObservation(out Segment head, out int headHead, out Segment tail, out int tailTail)
		{
			head = null;
			headHead = default(int);
			tail = null;
			tailTail = default(int);
		}

		private T GetItemWhenAvailable(Segment segment, int i)
		{
			return default(T);
		}

		[IteratorStateMachine(typeof(ConcurrentQueue<>._003CEnumerate_003Ed__28))]
		private IEnumerator<T> Enumerate(Segment head, int headHead, Segment tail, int tailTail)
		{
			return null;
		}

		public void Enqueue(T item)
		{
		}

		private void EnqueueSlow(T item)
		{
		}

		public bool TryDequeue(out T result)
		{
			result = default(T);
			return false;
		}

		private bool TryDequeueSlow(out T item)
		{
			item = default(T);
			return false;
		}
	}
}
