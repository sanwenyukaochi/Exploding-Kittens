namespace Spine
{
	public class Bone
	{
		public static bool yDown;

		internal BoneData data;

		internal Skeleton skeleton;

		internal Bone parent;

		internal ExposedList<Bone> children;

		internal float x;

		internal float y;

		internal float rotation;

		internal float rotationIK;

		internal float scaleX;

		internal float scaleY;

		internal bool flipX;

		internal bool flipY;

		internal float m00;

		internal float m01;

		internal float m10;

		internal float m11;

		internal float worldX;

		internal float worldY;

		internal float worldRotation;

		internal float worldScaleX;

		internal float worldScaleY;

		internal bool worldFlipX;

		internal bool worldFlipY;

		public BoneData Data => null;

		public Skeleton Skeleton => null;

		public Bone Parent => null;

		public ExposedList<Bone> Children => null;

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

		public float RotationIK
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

		public float M00 => 0f;

		public float M01 => 0f;

		public float M10 => 0f;

		public float M11 => 0f;

		public float WorldX => 0f;

		public float WorldY => 0f;

		public float WorldRotation => 0f;

		public float WorldScaleX => 0f;

		public float WorldScaleY => 0f;

		public bool WorldFlipX
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool WorldFlipY
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Bone(BoneData data, Skeleton skeleton, Bone parent)
		{
		}

		public void UpdateWorldTransform()
		{
		}

		public void SetToSetupPose()
		{
		}

		public void worldToLocal(float worldX, float worldY, out float localX, out float localY)
		{
			localX = default(float);
			localY = default(float);
		}

		public void localToWorld(float localX, float localY, out float worldX, out float worldY)
		{
			worldX = default(float);
			worldY = default(float);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
