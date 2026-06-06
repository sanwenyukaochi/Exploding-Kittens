namespace Spine
{
	public class FFDTimeline : CurveTimeline
	{
		internal int slotIndex;

		internal float[] frames;

		private float[][] frameVertices;

		internal Attachment attachment;

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

		public float[][] Vertices
		{
			get
			{
				return null;
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

		public FFDTimeline(int frameCount)
			: base(0)
		{
		}

		public void SetFrame(int frameIndex, float time, float[] vertices)
		{
		}

		public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha)
		{
		}
	}
}
