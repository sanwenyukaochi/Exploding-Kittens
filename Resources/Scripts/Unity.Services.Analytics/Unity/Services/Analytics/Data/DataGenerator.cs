using System;
using Unity.Services.Analytics.Internal;

namespace Unity.Services.Analytics.Data
{
	internal class DataGenerator : IDataGenerator
	{
		internal enum SessionEndState
		{
			PAUSED = 0,
			KILLEDINBACKGROUND = 1,
			KILLEDINFOREGROUND = 2,
			QUIT = 3
		}

		private IBuffer m_Buffer;

		public void SetBuffer(IBuffer buffer)
		{
		}

		public void GameRunning(DateTime datetime, StdCommonParams commonParams, string callingMethodIdentifier)
		{
		}

		public void GameEnded(DateTime datetime, StdCommonParams commonParams, string callingMethodIdentifier, SessionEndState quitState)
		{
		}
	}
}
