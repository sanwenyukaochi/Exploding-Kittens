using System.Runtime.InteropServices;

namespace UnityEngine.Android
{
	[StructLayout((LayoutKind)0, Size = 1)]
	public struct Permission
	{
		private static AndroidJavaObject m_Activity;

		internal static AndroidJavaObject GetActivity()
		{
			return null;
		}
	}
}
