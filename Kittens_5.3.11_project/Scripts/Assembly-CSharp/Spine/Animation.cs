namespace Spine
{
	public class Animation
	{
		internal ExposedList<Timeline> timelines;

		internal float duration;

		internal string name;

		public string Name => null;

		public ExposedList<Timeline> Timelines
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float Duration
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Animation(string name, ExposedList<Timeline> timelines, float duration)
		{
		}

		public void Apply(Skeleton skeleton, float lastTime, float time, bool loop, ExposedList<Event> events)
		{
		}

		public void Mix(Skeleton skeleton, float lastTime, float time, bool loop, ExposedList<Event> events, float alpha)
		{
		}

		internal static int binarySearch(float[] values, float target, int step)
		{
			return 0;
		}

		internal static int binarySearch(float[] values, float target)
		{
			return 0;
		}

		internal static int linearSearch(float[] values, float target, int step)
		{
			return 0;
		}
	}
}
