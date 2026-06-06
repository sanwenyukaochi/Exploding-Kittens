using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Threading
{
	[DebuggerDisplay("IsCancellationRequested = {IsCancellationRequested}")]
	public readonly struct CancellationToken
	{
		private readonly CancellationTokenSource _source;

		private static readonly Action<object> s_actionToActionObjShunt;

		public static CancellationToken None => default(CancellationToken);

		public bool IsCancellationRequested => false;

		public bool CanBeCanceled => false;

		internal CancellationToken(CancellationTokenSource source)
		{
			_source = null;
		}

		public CancellationToken(bool canceled)
		{
			_source = null;
		}

		public CancellationTokenRegistration Register(Action callback)
		{
			return default(CancellationTokenRegistration);
		}

		internal CancellationTokenRegistration InternalRegisterWithoutEC(Action<object> callback, object state)
		{
			return default(CancellationTokenRegistration);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CancellationTokenRegistration Register(Action<object> callback, object state, bool useSynchronizationContext, bool useExecutionContext)
		{
			return default(CancellationTokenRegistration);
		}

		public bool Equals(CancellationToken other)
		{
			return false;
		}

		public override bool Equals(object other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(CancellationToken left, CancellationToken right)
		{
			return false;
		}

		public static bool operator !=(CancellationToken left, CancellationToken right)
		{
			return false;
		}

		public void ThrowIfCancellationRequested()
		{
		}

		private void ThrowOperationCanceledException()
		{
		}
	}
}
