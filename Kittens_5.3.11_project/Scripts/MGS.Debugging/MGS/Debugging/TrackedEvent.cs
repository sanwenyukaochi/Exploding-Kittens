using System;

namespace MGS.Debugging
{
	public struct TrackedEvent
	{
		public DateTime time;

		public string eventName;

		public TrackedEvent(DateTime time, string eventName)
		{
			this.time = default(DateTime);
			this.eventName = null;
		}
	}
}
