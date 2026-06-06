using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	[Serializable]
	[StructLayout((LayoutKind)0)]
	[ComVisible(true)]
	[Obsolete("An alternate API is available: Emit the MarshalAs custom attribute instead.")]
	public sealed class UnmanagedMarshal
	{
		private UnmanagedMarshal()
		{
		}
	}
}
