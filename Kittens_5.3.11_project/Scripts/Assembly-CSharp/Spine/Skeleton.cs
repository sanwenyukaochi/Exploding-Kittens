namespace Spine
{
	public class Skeleton
	{
		internal SkeletonData data;

		internal ExposedList<Bone> bones;

		internal ExposedList<Slot> slots;

		internal ExposedList<Slot> drawOrder;

		internal ExposedList<IkConstraint> ikConstraints;

		private ExposedList<ExposedList<Bone>> boneCache;

		internal Skin skin;

		internal float r;

		internal float g;

		internal float b;

		internal float a;

		internal float time;

		internal bool flipX;

		internal bool flipY;

		internal float x;

		internal float y;

		public SkeletonData Data => null;

		public ExposedList<Bone> Bones => null;

		public ExposedList<Slot> Slots => null;

		public ExposedList<Slot> DrawOrder => null;

		public ExposedList<IkConstraint> IkConstraints
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Skin Skin
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float R
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float G
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float B
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float A
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Time
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

		public Bone RootBone => null;

		public Skeleton(SkeletonData data)
		{
		}

		public void UpdateCache()
		{
		}

		public void UpdateWorldTransform()
		{
		}

		public void SetToSetupPose()
		{
		}

		public void SetBonesToSetupPose()
		{
		}

		public void SetSlotsToSetupPose()
		{
		}

		public Bone FindBone(string boneName)
		{
			return null;
		}

		public int FindBoneIndex(string boneName)
		{
			return 0;
		}

		public Slot FindSlot(string slotName)
		{
			return null;
		}

		public int FindSlotIndex(string slotName)
		{
			return 0;
		}

		public void SetSkin(string skinName)
		{
		}

		public void SetSkin(Skin newSkin)
		{
		}

		public Attachment GetAttachment(string slotName, string attachmentName)
		{
			return null;
		}

		public Attachment GetAttachment(int slotIndex, string attachmentName)
		{
			return null;
		}

		public void SetAttachment(string slotName, string attachmentName)
		{
		}

		public IkConstraint FindIkConstraint(string ikConstraintName)
		{
			return null;
		}

		public void Update(float delta)
		{
		}
	}
}
