namespace Spine
{
	public class FlipXTimeline : Timeline
	{
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

		public int FrameCount => 0;

		public FlipXTimeline(int frameCount)
		{
		}

		public void SetFrame(int frameIndex, float time, bool flip)
		{
		}

		public void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha)
		{
		}

		protected virtual void SetFlip(Bone bone, bool flip)
		{
		}
	}
}
