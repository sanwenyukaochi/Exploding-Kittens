using System.Runtime.InteropServices;

namespace System.Diagnostics
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
	[ComVisible(true)]
	public sealed class DebuggerBrowsableAttribute : Attribute
	{
		private DebuggerBrowsableState state;

		public DebuggerBrowsableAttribute(DebuggerBrowsableState state)
		{
		}
	}
}
