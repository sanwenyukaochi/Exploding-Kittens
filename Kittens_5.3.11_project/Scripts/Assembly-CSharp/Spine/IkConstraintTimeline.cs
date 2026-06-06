namespace Spine
{
	public class IkConstraintTimeline : CurveTimeline
	{
		private const int PREV_FRAME_TIME = -3;

		private const int PREV_FRAME_MIX = -2;

		private const int PREV_FRAME_BEND_DIRECTION = -1;

		private const int FRAME_MIX = 1;

		internal int ikConstraintIndex;

		internal float[] frames;

		public int IkConstraintIndex
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

		public IkConstraintTimeline(int frameCount)
			: base(0)
		{
		}

		public void SetFrame(int frameIndex, float time, float mix, int bendDirection)
		{
		}

		public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha)
		{
		}
	}
}
