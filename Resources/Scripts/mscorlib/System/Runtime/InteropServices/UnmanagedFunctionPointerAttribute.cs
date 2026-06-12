namespace System.Runtime.InteropServices
{
	[AttributeUsage(AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[ComVisible(true)]
	public sealed class UnmanagedFunctionPointerAttribute : Attribute
	{
		private CallingConvention m_callingConvention;

		public UnmanagedFunctionPointerAttribute(CallingConvention callingConvention)
		{
		}
	}
}
