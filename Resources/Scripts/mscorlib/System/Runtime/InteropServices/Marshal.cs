using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Security;

namespace System.Runtime.InteropServices
{
	public static class Marshal
	{
		internal delegate IntPtr SecureStringAllocator(int len);

		internal class MarshalerInstanceKeyComparer : IEqualityComparer<(Type, string)>
		{
			public bool Equals((Type, string) lhs, (Type, string) rhs)
			{
				return false;
			}

			public int GetHashCode((Type, string) key)
			{
				return 0;
			}
		}

		public static readonly int SystemMaxDBCSCharSize;

		public static readonly int SystemDefaultCharSize;

		internal static Dictionary<(Type, string), ICustomMarshaler> MarshalerInstanceCache;

		internal static readonly object MarshalerInstanceCacheLock;

		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static IntPtr AllocHGlobal(IntPtr cb)
		{
			return (IntPtr)0;
		}

		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static IntPtr AllocHGlobal(int cb)
		{
			return (IntPtr)0;
		}

		private unsafe static void copy_to_unmanaged_fixed(Array source, int startIndex, IntPtr destination, int length, void* fixed_source_element)
		{
		}

		private static bool skip_fixed(Array array, int startIndex)
		{
			return false;
		}

		internal static void copy_to_unmanaged(byte[] source, int startIndex, IntPtr destination, int length)
		{
		}

		public static void Copy(byte[] source, int startIndex, IntPtr destination, int length)
		{
		}

		internal static void copy_from_unmanaged(IntPtr source, int startIndex, Array destination, int length)
		{
		}

		private unsafe static void copy_from_unmanaged_fixed(IntPtr source, int startIndex, Array destination, int length, void* fixed_destination_element)
		{
		}

		public static void Copy(IntPtr source, byte[] destination, int startIndex, int length)
		{
		}

		public static void Copy(IntPtr source, char[] destination, int startIndex, int length)
		{
		}

		public static void FreeBSTR(IntPtr ptr)
		{
		}

		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static void FreeHGlobal(IntPtr hglobal)
		{
		}

		private static void ClearAnsi(IntPtr ptr)
		{
		}

		private static void ClearUnicode(IntPtr ptr)
		{
		}

		public static void ZeroFreeGlobalAllocAnsi(IntPtr s)
		{
		}

		public static void ZeroFreeGlobalAllocUnicode(IntPtr s)
		{
		}

		public static int GetHRForException(Exception e)
		{
			return 0;
		}

		public static bool IsComObject(object o)
		{
			return false;
		}

		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static int GetLastWin32Error()
		{
			return 0;
		}

		public static string PtrToStringAnsi(IntPtr ptr)
		{
			return null;
		}

		public static string PtrToStringUni(IntPtr ptr)
		{
			return null;
		}

		[ComVisible(true)]
		public static object PtrToStructure(IntPtr ptr, Type structureType)
		{
			return null;
		}

		public static T PtrToStructure<T>(IntPtr ptr)
		{
			return default(T);
		}

		public static byte ReadByte(IntPtr ptr, int ofs)
		{
			return 0;
		}

		public static short ReadInt16(IntPtr ptr, int ofs)
		{
			return 0;
		}

		private unsafe static IntPtr StringToHGlobalAnsi(char* s, int length)
		{
			return (IntPtr)0;
		}

		public static IntPtr StringToHGlobalAnsi(string s)
		{
			return (IntPtr)0;
		}

		internal static IntPtr SecureStringGlobalAllocator(int len)
		{
			return (IntPtr)0;
		}

		internal static IntPtr SecureStringToUnicode(SecureString s, SecureStringAllocator allocator)
		{
			return (IntPtr)0;
		}

		public static IntPtr SecureStringToGlobalAllocUnicode(SecureString s)
		{
			return (IntPtr)0;
		}

		[ComVisible(true)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static void StructureToPtr(object structure, IntPtr ptr, bool fDeleteOld)
		{
		}

		public static void StructureToPtr<T>(T structure, IntPtr ptr, bool fDeleteOld)
		{
		}

		public static IntPtr UnsafeAddrOfPinnedArrayElement(Array arr, int index)
		{
			return (IntPtr)0;
		}

		public static IntPtr UnsafeAddrOfPinnedArrayElement<T>(T[] arr, int index)
		{
			return (IntPtr)0;
		}

		public static void WriteByte(IntPtr ptr, int ofs, byte val)
		{
		}

		public static void WriteInt16(IntPtr ptr, int ofs, short val)
		{
		}

		private static IntPtr GetFunctionPointerForDelegateInternal(Delegate d)
		{
			return (IntPtr)0;
		}

		public static IntPtr GetFunctionPointerForDelegate<TDelegate>(TDelegate d)
		{
			return (IntPtr)0;
		}

		internal static ICustomMarshaler GetCustomMarshalerInstance(Type type, string cookie)
		{
			return null;
		}
	}
}
