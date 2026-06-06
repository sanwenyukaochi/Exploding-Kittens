using System;
using UnityEngine;

namespace TMPro
{
	[Serializable]
	public struct VertexGradient
	{
		public Color topLeft;

		public Color topRight;

		public Color bottomLeft;

		public Color bottomRight;

		public VertexGradient(Color color)
		{
			topLeft = default(Color);
			topRight = default(Color);
			bottomLeft = default(Color);
			bottomRight = default(Color);
		}
	}
}
