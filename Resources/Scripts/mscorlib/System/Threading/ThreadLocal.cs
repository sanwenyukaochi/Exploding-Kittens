using System.Collections.Generic;
using System.Diagnostics;

namespace System.Threading
{
	[DebuggerDisplay("IsValueCreated={IsValueCreated}, Value={ValueForDebugDisplay}, Count={ValuesCountForDebugDisplay}")]
	[DebuggerTypeProxy(typeof(SystemThreading_ThreadLocalDebugView<>))]
	public class ThreadLocal<T> : IDisposable
	{
		private struct LinkedSlotVolatile
		{
			internal LinkedSlot Value;
		}

		private sealed class LinkedSlot
		{
			internal LinkedSlot Next;

			internal LinkedSlot Previous;

			internal LinkedSlotVolatile[] SlotArray;

			internal T Value;

			internal LinkedSlot(LinkedSlotVolatile[] slotArray)
			{
			}
		}

		private class IdManager
		{
			private int m_nextIdToTry;

			private List<bool> m_freeIds;

			internal int GetId()
			{
				return 0;
			}

			internal void ReturnId(int id)
			{
			}
		}

		private class FinalizationHelper
		{
			internal LinkedSlotVolatile[] SlotArray;

			private bool m_trackAllValues;

			internal FinalizationHelper(LinkedSlotVolatile[] slotArray, bool trackAllValues)
			{
			}

			~FinalizationHelper()
			{
			}
		}

		private Func<T> m_valueFactory;

		[ThreadStatic]
		private static LinkedSlotVolatile[] ts_slotArray;

		[ThreadStatic]
		private static FinalizationHelper ts_finalizationHelper;

		private int m_idComplement;

		private bool m_initialized;

		private static IdManager s_idManager;

		private LinkedSlot m_linkedSlot;

		private bool m_trackAllValues;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public T Value
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public bool IsValueCreated => false;

		private void Initialize(Func<T> valueFactory, bool trackAllValues)
		{
		}

		~ThreadLocal()
		{
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public override string ToString()
		{
			return null;
		}

		private T GetValueSlow()
		{
			return default(T);
		}

		private void SetValueSlow(T value, LinkedSlotVolatile[] slotArray)
		{
		}

		private void CreateLinkedSlot(LinkedSlotVolatile[] slotArray, int id, T value)
		{
		}

		private void GrowTable(ref LinkedSlotVolatile[] table, int minLength)
		{
		}

		private static int GetNewTableSize(int minSize)
		{
			return 0;
		}
	}
}
