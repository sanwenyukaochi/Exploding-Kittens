using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Runtime/Geometry/Intersection.h")]
	[NativeHeader("Runtime/Geometry/AABB.h")]
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	[NativeClass("AABB")]
	[NativeHeader("Runtime/Math/MathScripting.h")]
	[NativeType(Header = "Runtime/Geometry/AABB.h")]
	[NativeHeader("Runtime/Geometry/Ray.h")]
	public struct Bounds : IEquatable<Bounds>, IFormattable
	{
		private Vector3 m_Center;

		[NativeName("m_Extent")]
		private Vector3 m_Extents;

		public Vector3 center
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Vector3);
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		public Vector3 size
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Vector3);
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		public Vector3 extents
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Vector3);
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		public Vector3 min
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Vector3);
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		public Vector3 max
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Vector3);
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Bounds(Vector3 center, Vector3 size)
		{
			m_Center = default(Vector3);
			m_Extents = default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override bool Equals(object other)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(Bounds other)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(Bounds lhs, Bounds rhs)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator !=(Bounds lhs, Bounds rhs)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void SetMinMax(Vector3 min, Vector3 max)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Encapsulate(Vector3 point)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Encapsulate(Bounds bounds)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override string ToString()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}
	}
}
