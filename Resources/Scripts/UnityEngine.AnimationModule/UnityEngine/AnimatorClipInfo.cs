using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Modules/Animation/AnimatorInfo.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
	[UsedByNativeCode]
	public struct AnimatorClipInfo
	{
		private int m_ClipInstanceID;

		private float m_Weight;

		public AnimationClip clip => null;

		public float weight => 0f;

		[FreeFunction("AnimationBindings::InstanceIDToAnimationClipPPtr")]
		private static AnimationClip InstanceIDToAnimationClipPPtr(int instanceID)
		{
			return null;
		}
	}
}
