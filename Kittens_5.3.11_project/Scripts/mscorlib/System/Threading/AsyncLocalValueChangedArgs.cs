using System.Runtime.CompilerServices;

namespace System.Threading
{
	public readonly struct AsyncLocalValueChangedArgs<T>
	{
		[CompilerGenerated]
		private readonly T _003CPreviousValue_003Ek__BackingField;

		[CompilerGenerated]
		private readonly bool _003CThreadContextChanged_003Ek__BackingField;

		public T CurrentValue { get; }

		internal AsyncLocalValueChangedArgs(T previousValue, T currentValue, bool contextChanged)
		{
			_003CPreviousValue_003Ek__BackingField = default(T);
			CurrentValue = default(T);
			_003CThreadContextChanged_003Ek__BackingField = false;
		}
	}
}
