using System;
using UnityEngine.Bindings;
using UnityEngineInternal;

namespace UnityEngine
{
	[NativeHeader("Runtime/Misc/ResourceManagerUtility.h")]
	[NativeHeader("Runtime/Export/Resources/Resources.bindings.h")]
	internal static class ResourcesAPIInternal
	{
		[FreeFunction("Resources_Bindings::FindObjectsOfTypeAll")]
		[TypeInferenceRule(TypeInferenceRules.ArrayOfTypeReferencedByFirstArgument)]
		public static Object[] FindObjectsOfTypeAll(Type type)
		{
			return null;
		}

		[FreeFunction("GetShaderNameRegistry().FindShader")]
		public static Shader FindShaderByName(string name)
		{
			return null;
		}

		[TypeInferenceRule(TypeInferenceRules.TypeReferencedBySecondArgument)]
		[NativeThrows]
		[FreeFunction("Resources_Bindings::Load")]
		public static Object Load(string path, [NotNull("ArgumentNullException")] Type systemTypeInstance)
		{
			return null;
		}

		[FreeFunction("Resources_Bindings::LoadAsyncInternal")]
		internal static ResourceRequest LoadAsyncInternal(string path, Type type)
		{
			return null;
		}

		[FreeFunction("Scripting::UnloadAssetFromScripting")]
		public static void UnloadAsset(Object assetToUnload)
		{
		}
	}
}
