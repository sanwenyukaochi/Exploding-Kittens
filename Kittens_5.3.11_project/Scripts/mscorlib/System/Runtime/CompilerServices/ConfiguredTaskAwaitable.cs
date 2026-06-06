using System.Diagnostics;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
	public readonly struct ConfiguredTaskAwaitable
	{
		public readonly struct ConfiguredTaskAwaiter : ICriticalNotifyCompletion
		{
			internal readonly Task m_task;

			internal readonly bool m_continueOnCapturedContext;

			public bool IsCompleted => false;

			internal ConfiguredTaskAwaiter(Task task, bool continueOnCapturedContext)
			{
				m_task = null;
				m_continueOnCapturedContext = false;
			}

			public void OnCompleted(Action continuation)
			{
			}

			public void UnsafeOnCompleted(Action continuation)
			{
			}

			[StackTraceHidden]
			public void GetResult()
			{
			}
		}

		private readonly ConfiguredTaskAwaiter m_configuredTaskAwaiter;

		internal ConfiguredTaskAwaitable(Task task, bool continueOnCapturedContext)
		{
			m_configuredTaskAwaiter = default(ConfiguredTaskAwaiter);
		}

		public ConfiguredTaskAwaiter GetAwaiter()
		{
			return default(ConfiguredTaskAwaiter);
		}
	}
	public readonly struct ConfiguredTaskAwaitable<TResult>
	{
		public readonly struct ConfiguredTaskAwaiter : ICriticalNotifyCompletion
		{
			private readonly Task<TResult> m_task;

			private readonly bool m_continueOnCapturedContext;

			public bool IsCompleted => false;

			internal ConfiguredTaskAwaiter(Task<TResult> task, bool continueOnCapturedContext)
			{
				m_task = null;
				m_continueOnCapturedContext = false;
			}

			public void UnsafeOnCompleted(Action continuation)
			{
			}

			[StackTraceHidden]
			public TResult GetResult()
			{
				return default(TResult);
			}
		}

		private readonly ConfiguredTaskAwaiter m_configuredTaskAwaiter;

		internal ConfiguredTaskAwaitable(Task<TResult> task, bool continueOnCapturedContext)
		{
			m_configuredTaskAwaiter = default(ConfiguredTaskAwaiter);
		}

		public ConfiguredTaskAwaiter GetAwaiter()
		{
			return default(ConfiguredTaskAwaiter);
		}
	}
}
