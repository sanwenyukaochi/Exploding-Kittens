using System;
using System.Reflection;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[StructLayout((LayoutKind)0)]
	[DefaultMember("Item")]
	[NativeHeader("Runtime/Math/AnimationCurve.bindings.h")]
	[RequiredByNativeCode]
	public class AnimationCurve : IEquatable<AnimationCurve>
	{
		internal IntPtr m_Ptr;

		public Keyframe[] keys
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int length
		{
			[NativeMethod("GetKeyCount", IsThreadSafe = true)]
			get
			{
				return 0;
			}
		}

		public WrapMode preWrapMode
		{
			[NativeMethod("GetPreInfinity", IsThreadSafe = true)]
			get
			{
				return default(WrapMode);
			}
			[NativeMethod("SetPreInfinity", IsThreadSafe = true)]
			set
			{
			}
		}

		public WrapMode postWrapMode
		{
			[NativeMethod("GetPostInfinity", IsThreadSafe = true)]
			get
			{
				return default(WrapMode);
			}
			[NativeMethod("SetPostInfinity", IsThreadSafe = true)]
			set
			{
			}
		}

		[FreeFunction("AnimationCurveBindings::Internal_Destroy", IsThreadSafe = true)]
		private static void Internal_Destroy(IntPtr ptr)
		{
		}

		[FreeFunction("AnimationCurveBindings::Internal_Create", IsThreadSafe = true)]
		private static IntPtr Internal_Create(Keyframe[] keys)
		{
			return (IntPtr)0;
		}

		[FreeFunction("AnimationCurveBindings::Internal_Equals", HasExplicitThis = true, IsThreadSafe = true)]
		private bool Internal_Equals(IntPtr other)
		{
			return false;
		}

		~AnimationCurve()
		{
		}

		[ThreadSafe]
		public float Evaluate(float time)
		{
			return 0f;
		}

		[FreeFunction("AnimationCurveBindings::SetKeys", HasExplicitThis = true, IsThreadSafe = true)]
		private void SetKeys(Keyframe[] keys)
		{
		}

		[FreeFunction("AnimationCurveBindings::GetKeys", HasExplicitThis = true, IsThreadSafe = true)]
		private Keyframe[] GetKeys()
		{
			return null;
		}

		[FreeFunction("AnimationCurveBindings::GetHashCode", HasExplicitThis = true, IsThreadSafe = true)]
		public override int GetHashCode()
		{
			return 0;
		}

		public static AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd)
		{
			return null;
		}

		public AnimationCurve(params Keyframe[] keys)
		{
		}

		[RequiredByNativeCode]
		public AnimationCurve()
		{
		}

		public override bool Equals(object o)
		{
			return false;
		}

		public bool Equals(AnimationCurve other)
		{
			return false;
		}
	}
}
