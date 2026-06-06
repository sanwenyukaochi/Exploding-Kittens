using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Runtime/BaseClasses/TagManager.h")]
	public struct SortingLayer
	{
		private int m_Id;

		[FreeFunction("GetTagManager().GetSortingLayerValueFromUniqueID")]
		public static int GetLayerValueFromID(int id)
		{
			return 0;
		}
	}
}
