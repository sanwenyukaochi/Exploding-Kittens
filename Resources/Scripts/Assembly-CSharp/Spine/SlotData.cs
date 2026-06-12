namespace Spine
{
	public class SlotData
	{
		internal string name;

		internal BoneData boneData;

		internal float r;

		internal float g;

		internal float b;

		internal float a;

		internal string attachmentName;

		internal BlendMode blendMode;

		public string Name => null;

		public BoneData BoneData => null;

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

		public string AttachmentName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public BlendMode BlendMode
		{
			get
			{
				return default(BlendMode);
			}
			set
			{
			}
		}

		public SlotData(string name, BoneData boneData)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
