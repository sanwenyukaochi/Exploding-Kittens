using System.Reflection;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Modules/Animation/AnimatorOverrideController.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
	[DefaultMember("Item")]
	[UsedByNativeCode]
	public class AnimatorOverrideController : RuntimeAnimatorController
	{
		internal delegate void OnOverrideControllerDirtyCallback();

		internal OnOverrideControllerDirtyCallback OnOverrideControllerDirty;

		[RequiredByNativeCode]
		[NativeConditional("UNITY_EDITOR")]
		internal static void OnInvalidateOverrideController(AnimatorOverrideController controller)
		{
		}
	}
}
