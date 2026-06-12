using UnityEngine;

namespace Unity.Services.Analytics
{
	internal class AnalyticsContainer : MonoBehaviour, IAnalyticsContainer
	{
		private const float k_AutoFlushPeriod = 60f;

		private const float k_GameRunningPeriod = 60f;

		private static bool s_Created;

		private static GameObject s_Container;

		private float m_AutoFlushTime;

		private float m_GameRunningTime;

		private AnalyticsServiceInstance m_Service;

		private float AutoFlushPeriod => 0f;

		internal static AnalyticsContainer Instance { get; private set; }

		internal float TimeUntilHeartbeat => 0f;

		internal static AnalyticsContainer CreateContainer()
		{
			return null;
		}

		public void Initialize(AnalyticsServiceInstance service)
		{
		}

		public void Enable()
		{
		}

		public void Disable()
		{
		}

		private void Update()
		{
		}

		private void OnApplicationPause(bool paused)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
