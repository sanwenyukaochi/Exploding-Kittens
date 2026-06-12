using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[UsedByNativeCode]
	[NativeHeader("Modules/Animation/AnimationState.h")]
	public sealed class AnimationState : TrackedReference
	{
		public bool enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float weight
		{
			set
			{
			}
		}

		public WrapMode wrapMode
		{
			get
			{
				return default(WrapMode);
			}
			set
			{
			}
		}

		public float time
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float normalizedTime
		{
			set
			{
			}
		}

		public float speed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float length => 0f;

		public int layer
		{
			set
			{
			}
		}

		public string name => null;

		public AnimationBlendMode blendMode
		{
			set
			{
			}
		}

		[ExcludeFromDocs]
		public void AddMixingTransform(Transform mix)
		{
		}

		public void AddMixingTransform([NotNull("NullExceptionObject")] Transform mix, [DefaultValue("true")] bool recursive)
		{
		}
	}
}
