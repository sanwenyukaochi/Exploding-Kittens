using System.Collections.Generic;
using Unity.Services.Core.Internal;
using UnityEngine.LowLevel;

namespace Unity.Services.Core.Scheduler.Internal
{
	internal class ActionScheduler : IActionScheduler, IServiceComponent
	{
		internal readonly PlayerLoopSystem SchedulerLoopSystem;

		private readonly ITimeProvider m_TimeProvider;

		private readonly object m_Lock;

		private readonly MinimumBinaryHeap<ScheduledInvocation> m_ScheduledActions;

		private readonly Dictionary<long, ScheduledInvocation> m_IdScheduledInvocationMap;

		private readonly List<ScheduledInvocation> m_ExpiredActions;

		private long m_NextId;

		public ActionScheduler()
		{
		}

		public ActionScheduler(ITimeProvider timeProvider)
		{
		}

		internal void ExecuteExpiredActions()
		{
		}

		internal static void UpdateCurrentPlayerLoopWith(List<PlayerLoopSystem> subSystemList, PlayerLoopSystem currentPlayerLoop)
		{
		}

		public void JoinPlayerLoopSystem()
		{
		}
	}
}
