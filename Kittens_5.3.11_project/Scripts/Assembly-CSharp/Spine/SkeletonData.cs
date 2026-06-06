namespace Spine
{
	public class SkeletonData
	{
		internal string name;

		internal ExposedList<BoneData> bones;

		internal ExposedList<SlotData> slots;

		internal ExposedList<Skin> skins;

		internal Skin defaultSkin;

		internal ExposedList<EventData> events;

		internal ExposedList<Animation> animations;

		internal ExposedList<IkConstraintData> ikConstraints;

		internal float width;

		internal float height;

		internal string version;

		internal string hash;

		internal string imagesPath;

		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ExposedList<BoneData> Bones => null;

		public ExposedList<SlotData> Slots => null;

		public ExposedList<Skin> Skins
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Skin DefaultSkin
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ExposedList<EventData> Events
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ExposedList<Animation> Animations
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ExposedList<IkConstraintData> IkConstraints
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float Width
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Height
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public string Version
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Hash
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public BoneData FindBone(string boneName)
		{
			return null;
		}

		public int FindBoneIndex(string boneName)
		{
			return 0;
		}

		public SlotData FindSlot(string slotName)
		{
			return null;
		}

		public int FindSlotIndex(string slotName)
		{
			return 0;
		}

		public Skin FindSkin(string skinName)
		{
			return null;
		}

		public EventData FindEvent(string eventDataName)
		{
			return null;
		}

		public Animation FindAnimation(string animationName)
		{
			return null;
		}

		public IkConstraintData FindIkConstraint(string ikConstraintName)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
