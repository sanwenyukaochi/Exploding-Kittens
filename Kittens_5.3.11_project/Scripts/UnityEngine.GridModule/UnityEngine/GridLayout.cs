using UnityEngine.Bindings;

namespace UnityEngine
{
	[RequireComponent(typeof(Transform))]
	[NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
	[NativeType(Header = "Modules/Grid/Public/Grid.h")]
	public class GridLayout : Behaviour
	{
	}
}
