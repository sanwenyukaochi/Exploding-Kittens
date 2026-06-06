using UnityEngine.Bindings;

namespace UnityEngine.Tilemaps
{
	[NativeType(Header = "Modules/Tilemap/Public/TilemapRenderer.h")]
	[NativeHeader("Modules/Tilemap/Public/TilemapMarshalling.h")]
	[NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
	[RequireComponent(typeof(Tilemap))]
	[NativeHeader("Modules/Tilemap/TilemapRendererJobs.h")]
	public sealed class TilemapRenderer : Renderer
	{
	}
}
