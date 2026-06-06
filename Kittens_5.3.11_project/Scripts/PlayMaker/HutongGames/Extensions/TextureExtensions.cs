using UnityEngine;

namespace HutongGames.Extensions
{
	public static class TextureExtensions
	{
		public struct Point
		{
			public short x;

			public short y;

			public Point(short aX, short aY)
			{
				x = 0;
				y = 0;
			}

			public Point(int aX, int aY)
			{
				x = 0;
				y = 0;
			}
		}

		public static void FloodFillArea(this Texture2D aTex, int aX, int aY, Color32 aFillColor)
		{
		}
	}
}
