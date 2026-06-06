namespace Spine
{
	public class ColorTimeline : CurveTimeline
	{
		protected const int PREV_FRAME_TIME = -5;

		protected const int FRAME_R = 1;

		protected const int FRAME_G = 2;

		protected const int FRAME_B = 3;

		protected const int FRAME_A = 4;

		internal int slotIndex;

		internal float[] frames;

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

		public ColorTimeline(int frameCount)
			: base(0)
		{
		}

		public void SetFrame(int frameIndex, float time, float r, float g, float b, float a)
		{
		}

		public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha)
		{
		}
	}
}
