namespace System.Runtime
{
	internal static class RuntimeImports
	{
		internal static void RhZeroMemory(ref byte b, ulong byteLength)
		{
		}

		private unsafe static void ZeroMemory(void* p, uint byteLength)
		{
		}

		internal unsafe static void Memmove(byte* dest, byte* src, uint len)
		{
		}

		internal unsafe static void Memmove_wbarrier(byte* dest, byte* src, uint len, IntPtr type_handle)
		{
		}
	}
}
