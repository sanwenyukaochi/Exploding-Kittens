using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[UsedByNativeCode]
	public struct CharacterInfo
	{
		public int index;

		[Obsolete("CharacterInfo.uv is deprecated. Use uvBottomLeft, uvBottomRight, uvTopRight or uvTopLeft instead.")]
		public Rect uv;

		[Obsolete("CharacterInfo.vert is deprecated. Use minX, maxX, minY, maxY instead.")]
		public Rect vert;

		[NativeName("advance")]
		[Obsolete("CharacterInfo.width is deprecated. Use advance instead.")]
		public float width;

		public int size;

		public FontStyle style;

		[Obsolete("CharacterInfo.flipped is deprecated. Use uvBottomLeft, uvBottomRight, uvTopRight or uvTopLeft instead, which will be correct regardless of orientation.")]
		public bool flipped;

		public int advance => 0;

		public int minY => 0;

		public int maxY => 0;

		public int minX => 0;

		public int maxX => 0;

		internal Vector2 uvBottomLeftUnFlipped => default(Vector2);

		internal Vector2 uvBottomRightUnFlipped => default(Vector2);

		internal Vector2 uvTopRightUnFlipped => default(Vector2);

		internal Vector2 uvTopLeftUnFlipped => default(Vector2);

		public Vector2 uvBottomLeft => default(Vector2);

		public Vector2 uvBottomRight => default(Vector2);

		public Vector2 uvTopRight => default(Vector2);

		public Vector2 uvTopLeft => default(Vector2);
	}
}
