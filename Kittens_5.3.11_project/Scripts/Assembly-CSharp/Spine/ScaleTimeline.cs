namespace Spine
{
	public class ScaleTimeline : TranslateTimeline
	{
		public ScaleTimeline(int frameCount)
			: base(0)
		{
		}

		public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha)
		{
		}
	}
}
