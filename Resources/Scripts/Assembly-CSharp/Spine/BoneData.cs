namespace Spine
{
	public class BoneData
	{
		internal BoneData parent;

		internal string name;

		internal float length;

		internal float x;

		internal float y;

		internal float rotation;

		internal float scaleX;

		internal float scaleY;

		internal bool flipX;

		internal bool flipY;

		internal bool inheritScale;

		internal bool inheritRotation;

		public BoneData Parent => null;

		public string Name => null;

		public float Length
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float X
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Y
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Rotation
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float ScaleX
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float ScaleY
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool FlipX
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool FlipY
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool InheritScale
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool InheritRotation
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public BoneData(string name, BoneData parent)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
