using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Modules/Animation/Avatar.h")]
	[UsedByNativeCode]
	public class Avatar : Object
	{
		public bool isValid
		{
			[NativeMethod("IsValid")]
			get
			{
				return false;
			}
		}

		public bool isHuman
		{
			[NativeMethod("IsHuman")]
			get
			{
				return false;
			}
		}

		private Avatar()
		{
		}
	}
}
