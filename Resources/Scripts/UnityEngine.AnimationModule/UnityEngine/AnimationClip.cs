using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationClip.bindings.h")]
	[NativeType("Modules/Animation/AnimationClip.h")]
	public sealed class AnimationClip : Motion
	{
		[NativeProperty("Length", false, TargetType.Function)]
		public float length => 0f;

		[FreeFunction("AnimationClipBindings::Internal_CreateAnimationClip")]
		private static void Internal_CreateAnimationClip([Writable] AnimationClip self)
		{
		}

		[FreeFunction("AnimationClipBindings::Internal_SetCurve", HasExplicitThis = true)]
		public void SetCurve([NotNull("ArgumentNullException")] string relativePath, [NotNull("ArgumentNullException")] Type type, [NotNull("ArgumentNullException")] string propertyName, AnimationCurve curve)
		{
		}
	}
}
