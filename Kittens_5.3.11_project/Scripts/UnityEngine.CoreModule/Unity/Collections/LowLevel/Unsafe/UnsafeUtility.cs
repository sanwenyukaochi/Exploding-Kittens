using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace Unity.Collections.LowLevel.Unsafe
{
	[StaticAccessor("UnsafeUtility", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/Export/Unsafe/UnsafeUtility.bindings.h")]
	public static class UnsafeUtility
	{
		private struct AlignOfHelper<T> where T : struct
		{
			public byte dummy;

			public T data;
		}

		[ThreadSafe(ThrowsException = true)]
		public unsafe static void* MallocTracked(long size, int alignment, Allocator allocator, int callstacksToSkip)
		{
			return null;
		}

		[ThreadSafe(ThrowsException = true)]
		public unsafe static void FreeTracked(void* memory, Allocator allocator)
		{
		}

		[ThreadSafe(ThrowsException = true)]
		public unsafe static void MemCpy(void* destination, void* source, long size)
		{
		}

		[ThreadSafe(ThrowsException = true)]
		public unsafe static void MemCpyStride(void* destination, int destinationStride, void* source, int sourceStride, int elementSize, int count)
		{
		}

		[ThreadSafe(ThrowsException = true)]
		public unsafe static void MemSet(void* destination, byte value, long size)
		{
		}

		public unsafe static void MemClear(void* destination, long size)
		{
		}

		public static int AlignOf<T>() where T : struct
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static T ReadArrayElement<T>(void* source, int index)
		{
			return default(T);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static T ReadArrayElementWithStride<T>(void* source, int index, int stride)
		{
			return default(T);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void WriteArrayElement<T>(void* destination, int index, T value)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void WriteArrayElementWithStride<T>(void* destination, int index, int stride, T value)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void* AddressOf<T>(ref T output) where T : struct
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int SizeOf<T>() where T : struct
		{
			return 0;
		}

		public static ref T As<U, T>(ref U from)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static ref T AsRef<T>(void* ptr) where T : struct
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int EnumToInt<T>(T enumValue) where T : struct, IConvertible
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void InternalEnumToInt<T>(ref T enumValue, ref int intValue)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool EnumEquals<T>(T lhs, T rhs) where T : struct, IConvertible
		{
			return false;
		}
	}
}
