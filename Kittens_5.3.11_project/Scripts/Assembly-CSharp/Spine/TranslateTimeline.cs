namespace Spine
{
	public class TranslateTimeline : CurveTimeline
	{
		protected const int PREV_FRAME_TIME = -3;

		protected const int FRAME_X = 1;

		protected const int FRAME_Y = 2;

		internal int boneIndex;

		internal float[] frames;

		public int BoneIndex
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

		public TranslateTimeline(int frameCount)
			: base(0)
		{
		}

		public void SetFrame(int frameIndex, float time, float x, float y)
		{
		}

		public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha)
		{
		}
	}
}
