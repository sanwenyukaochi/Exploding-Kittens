namespace Spine
{
	public class AttachmentTimeline : Timeline
	{
		internal int slotIndex;

		internal float[] frames;

		private string[] attachmentNames;

		public int SlotIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float[] Frames
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string[] AttachmentNames
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int FrameCount => 0;

		public AttachmentTimeline(int frameCount)
		{
		}

		public void SetFrame(int frameIndex, float time, string attachmentName)
		{
		}

		public void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha)
		{
		}
	}
}
