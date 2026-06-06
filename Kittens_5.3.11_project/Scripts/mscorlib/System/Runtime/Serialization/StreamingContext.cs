using System.Runtime.InteropServices;

namespace System.Runtime.Serialization
{
	[Serializable]
	[ComVisible(true)]
	public readonly struct StreamingContext
	{
		internal readonly object m_additionalContext;

		internal readonly StreamingContextStates m_state;

		public object Context => null;

		public StreamingContextStates State => default(StreamingContextStates);

		public StreamingContext(StreamingContextStates state)
		{
			m_additionalContext = null;
			m_state = default(StreamingContextStates);
		}

		public StreamingContext(StreamingContextStates state, object additional)
		{
			m_additionalContext = null;
			m_state = default(StreamingContextStates);
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
