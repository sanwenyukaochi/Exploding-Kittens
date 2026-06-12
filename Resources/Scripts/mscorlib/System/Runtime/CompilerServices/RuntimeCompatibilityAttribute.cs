namespace System.Runtime.CompilerServices
{
	[Serializable]
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false, AllowMultiple = false)]
	public sealed class RuntimeCompatibilityAttribute : Attribute
	{
		[CompilerGenerated]
		private bool _003CWrapNonExceptionThrows_003Ek__BackingField;

		public bool WrapNonExceptionThrows
		{
			[CompilerGenerated]
			set
			{
				_003CWrapNonExceptionThrows_003Ek__BackingField = value;
			}
		}
	}
}
