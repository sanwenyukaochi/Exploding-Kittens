using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeClass("ColorRGBAf")]
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	[NativeHeader("Runtime/Math/Color.h")]
	[DefaultMember("Item")]
	public struct Color : IEquatable<Color>, IFormattable
	{
		public float r;

		public float g;

		public float b;

		public float a;

		public static Color red
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Color);
			}
		}

		public static Color green
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Color);
			}
		}

		public static Color blue
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Color);
			}
		}

		public static Color white
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Color);
			}
		}

		public static Color black
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Color);
			}
		}

		public static Color yellow
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Color);
			}
		}

		public static Color magenta
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Color);
			}
		}

		public static Color gray
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Color);
			}
		}

		public static Color grey
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Color);
			}
		}

		public static Color clear
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Color);
			}
		}

		public Color linear
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Color);
			}
		}

		public float maxColorComponent
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0f;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Color(float r, float g, float b, float a)
		{
			this.r = 0f;
			this.g = 0f;
			this.b = 0f;
			this.a = 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Color(float r, float g, float b)
		{
			this.r = 0f;
			this.g = 0f;
			this.b = 0f;
			a = 0f;
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
		public bool Equals(Color other)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Color operator -(Color a, Color b)
		{
			return default(Color);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Color operator *(Color a, Color b)
		{
			return default(Color);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Color operator *(Color a, float b)
		{
			return default(Color);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(Color lhs, Color rhs)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator !=(Color lhs, Color rhs)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Color Lerp(Color a, Color b, float t)
		{
			return default(Color);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Color LerpUnclamped(Color a, Color b, float t)
		{
			return default(Color);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal Color RGBMultiplied(float multiplier)
		{
			return default(Color);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static implicit operator Vector4(Color c)
		{
			return default(Vector4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static implicit operator Color(Vector4 v)
		{
			return default(Color);
		}
	}
}
