using UnityEngine.Bindings;

namespace UnityEngine.Tilemaps
{
	[NativeHeader("Runtime/Graphics/SpriteFrame.h")]
	[NativeHeader("Modules/Tilemap/Public/TilemapTile.h")]
	[NativeHeader("Modules/Tilemap/Public/TilemapMarshalling.h")]
	[NativeType(Header = "Modules/Tilemap/Public/Tilemap.h")]
	[RequireComponent(typeof(Transform))]
	[NativeHeader("Modules/Grid/Public/Grid.h")]
	[NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
	public sealed class Tilemap : GridLayout
	{
	}
}
