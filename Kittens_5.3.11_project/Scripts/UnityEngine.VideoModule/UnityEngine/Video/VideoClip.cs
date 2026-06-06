using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Video
{
	[NativeHeader("Modules/Video/Public/VideoClip.h")]
	[RequiredByNativeCode]
	public sealed class VideoClip : Object
	{
		public string originalPath => null;

		public ulong frameCount => 0uL;

		public double frameRate => 0.0;

		[NativeName("Duration")]
		public double length => 0.0;

		public uint width => 0u;

		public uint height => 0u;

		public ushort audioTrackCount => 0;

		private VideoClip()
		{
		}
	}
}
