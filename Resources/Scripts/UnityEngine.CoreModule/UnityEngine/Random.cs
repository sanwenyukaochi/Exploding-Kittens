using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Runtime/Export/Random/Random.bindings.h")]
	public static class Random
	{
		public static Vector3 insideUnitSphere
		{
			[FreeFunction]
			get
			{
				return default(Vector3);
			}
		}

		public static Vector2 insideUnitCircle => default(Vector2);

		[NativeMethod("SetSeed")]
		[StaticAccessor("GetScriptingRand()", StaticAccessorType.Dot)]
		public static void InitState(int seed)
		{
		}

		[FreeFunction]
		public static float Range(float minInclusive, float maxInclusive)
		{
			return 0f;
		}

		public static int Range(int minInclusive, int maxExclusive)
		{
			return 0;
		}

		[FreeFunction]
		private static int RandomRangeInt(int minInclusive, int maxExclusive)
		{
			return 0;
		}

		[FreeFunction]
		private static void GetRandomUnitCircle(out Vector2 output)
		{
			output = default(Vector2);
		}

		[SpecialName]
		private static void get_insideUnitSphere_Injected(out Vector3 ret)
		{
			ret = default(Vector3);
		}
	}
}
