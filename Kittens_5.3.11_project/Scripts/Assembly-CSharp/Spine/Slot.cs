namespace Spine
{
	public class Slot
	{
		internal SlotData data;

		internal Bone bone;

		internal float r;

		internal float g;

		internal float b;

		internal float a;

		internal Attachment attachment;

		internal float attachmentTime;

		internal float[] attachmentVertices;

		internal int attachmentVerticesCount;

		public SlotData Data => null;

		public Bone Bone => null;

		public Skeleton Skeleton => null;

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

		public Attachment Attachment
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float AttachmentTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float[] AttachmentVertices
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int AttachmentVerticesCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Slot(SlotData data, Bone bone)
		{
		}

		internal void SetToSetupPose(int slotIndex)
		{
		}

		public void SetToSetupPose()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
