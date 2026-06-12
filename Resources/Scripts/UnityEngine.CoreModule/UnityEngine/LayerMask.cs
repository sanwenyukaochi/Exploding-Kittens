using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeClass("BitField", "struct BitField;")]
	[NativeHeader("Runtime/BaseClasses/TagManager.h")]
	[NativeHeader("Runtime/BaseClasses/BitField.h")]
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	public struct LayerMask
	{
		[NativeName("m_Bits")]
		private int m_Mask;

		public static implicit operator int(LayerMask mask)
		{
			return 0;
		}

		public static implicit operator LayerMask(int intVal)
		{
			return default(LayerMask);
		}

		[NativeMethod("StringToLayer")]
		[StaticAccessor("GetTagManager()", StaticAccessorType.Dot)]
		public static int NameToLayer(string layerName)
		{
			return 0;
		}
	}
}
