namespace Spine
{
	public class RotateTimeline : CurveTimeline
	{
		protected const int PREV_FRAME_TIME = -2;

		protected const int FRAME_VALUE = 1;

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

		public RotateTimeline(int frameCount)
			: base(0)
		{
		}

		public void SetFrame(int frameIndex, float time, float angle)
		{
		}

		public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha)
		{
		}
	}
}
