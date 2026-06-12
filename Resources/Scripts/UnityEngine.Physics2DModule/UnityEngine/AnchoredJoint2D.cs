using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Modules/Physics2D/AnchoredJoint2D.h")]
	public class AnchoredJoint2D : Joint2D
	{
		public Vector2 connectedAnchor
		{
			set
			{
			}
		}

		[SpecialName]
		private void set_connectedAnchor_Injected(ref Vector2 value)
		{
		}
	}
}
