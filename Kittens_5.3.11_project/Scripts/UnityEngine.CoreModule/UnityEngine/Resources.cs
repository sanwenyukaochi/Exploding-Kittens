using System;
using UnityEngine.Bindings;
using UnityEngineInternal;

namespace UnityEngine
{
	[NativeHeader("Runtime/Misc/ResourceManagerUtility.h")]
	[NativeHeader("Runtime/Export/Resources/Resources.bindings.h")]
	public sealed class Resources
	{
		internal static T[] ConvertObjects<T>(Object[] rawObjects) where T : Object
		{
			return null;
		}

		public static Object[] FindObjectsOfTypeAll(Type type)
		{
			return null;
		}

		public static Object Load(string path)
		{
			return null;
		}

		public static T Load<T>(string path) where T : Object
		{
			return null;
		}

		public static Object Load(string path, Type systemTypeInstance)
		{
			return null;
		}

		public static ResourceRequest LoadAsync(string path)
		{
			return null;
		}

		public static ResourceRequest LoadAsync(string path, Type type)
		{
			return null;
		}

		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		[FreeFunction("GetScriptingBuiltinResource", ThrowsException = true)]
		public static Object GetBuiltinResource([NotNull("ArgumentNullException")] Type type, string path)
		{
			return null;
		}

		public static T GetBuiltinResource<T>(string path) where T : Object
		{
			return null;
		}

		public static void UnloadAsset(Object assetToUnload)
		{
		}
	}
}
