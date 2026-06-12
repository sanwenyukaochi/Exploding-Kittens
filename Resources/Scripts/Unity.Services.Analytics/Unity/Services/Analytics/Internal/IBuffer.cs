using System;

namespace Unity.Services.Analytics.Internal
{
	internal interface IBuffer
	{
		int Length { get; }

		byte[] Serialize();

		void PushStartEvent(string name, DateTime datetime, long? eventVersion, bool addPlayerIdsToEventBody = false);

		void PushEndEvent();

		void PushObjectStart(string name = null);

		void PushObjectEnd();

		void PushArrayStart(string name);

		void PushArrayEnd();

		void PushDouble(double val, string name = null);

		void PushFloat(float val, string name = null);

		void PushString(string val, string name = null);

		void PushInt64(long val, string name = null);

		void PushInt(int val, string name = null);

		void PushBool(bool val, string name = null);

		void PushTimestamp(DateTime val, string name = null);

		void FlushToDisk();

		void ClearDiskCache();

		void ClearBuffer();

		void ClearBuffer(long upTo);
	}
}
