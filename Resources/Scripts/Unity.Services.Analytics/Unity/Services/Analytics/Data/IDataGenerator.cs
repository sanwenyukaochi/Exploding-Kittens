using System;
using Unity.Services.Analytics.Internal;

namespace Unity.Services.Analytics.Data
{
	internal interface IDataGenerator
	{
		void SetBuffer(IBuffer buffer);

		void GameRunning(DateTime datetime, StdCommonParams commonParams, string callingMethodIdentifier);

		void GameEnded(DateTime datetime, StdCommonParams commonParams, string callingMethodIdentifier, DataGenerator.SessionEndState quitState);
	}
}
