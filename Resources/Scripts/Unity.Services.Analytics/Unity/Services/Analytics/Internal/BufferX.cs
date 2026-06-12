using System;
using System.Collections.Generic;
using System.IO;

namespace Unity.Services.Analytics.Internal
{
	internal class BufferX : IBuffer
	{
		private readonly byte[] k_WorkingBuffer;

		private readonly char[] k_WorkingCharacterBuffer;

		private readonly byte[] k_BufferHeader;

		private readonly byte[] k_HeaderEventName;

		private readonly byte[] k_HeaderUserName;

		private readonly byte[] k_HeaderSessionID;

		private readonly byte[] k_HeaderEventUUID;

		private readonly byte[] k_HeaderTimestamp;

		private readonly byte[] k_HeaderEventVersion;

		private readonly byte[] k_HeaderInstallationID;

		private readonly byte[] k_HeaderPlayerID;

		private readonly byte[] k_HeaderOpenEventParams;

		private readonly byte[] k_CloseEvent;

		private readonly byte k_Quote;

		private readonly byte[] k_QuoteColon;

		private readonly byte[] k_QuoteComma;

		private readonly byte[] k_Comma;

		private readonly byte[] k_OpenBrace;

		private readonly byte[] k_CloseBraceComma;

		private readonly byte[] k_OpenBracket;

		private readonly byte[] k_CloseBracketComma;

		private readonly byte[] k_True;

		private readonly byte[] k_False;

		private readonly IBufferSystemCalls m_SystemCalls;

		private readonly IDiskCache m_DiskCache;

		private IBufferIds m_Ids;

		private readonly List<int> m_EventEnds;

		private MemoryStream m_SpareBuffer;

		private MemoryStream m_Buffer;

		public int Length => 0;

		public BufferX(IBufferSystemCalls eventIdGenerator, IDiskCache diskCache)
		{
		}

		public void InjectIds(IBufferIds ids)
		{
		}

		private void WriteString(in string value)
		{
		}

		private void WriteByte(in byte value)
		{
		}

		private void WriteBytes(in byte[] bytes)
		{
		}

		private void WriteName(string name)
		{
		}

		public void PushStartEvent(string name, DateTime datetime, long? eventVersion, bool addPlayerIdsToEventBody)
		{
		}

		private void StripTrailingCommaIfNecessary()
		{
		}

		public void PushEndEvent()
		{
		}

		public void PushObjectStart(string name = null)
		{
		}

		public void PushObjectEnd()
		{
		}

		public void PushArrayStart(string name)
		{
		}

		public void PushArrayEnd()
		{
		}

		public void PushDouble(double val, string name = null)
		{
		}

		public void PushFloat(float val, string name = null)
		{
		}

		public void PushString(string value, string name = null)
		{
		}

		public void PushInt64(long val, string name = null)
		{
		}

		public void PushInt(int val, string name = null)
		{
		}

		public void PushBool(bool val, string name = null)
		{
		}

		public void PushTimestamp(DateTime val, string name)
		{
		}

		public byte[] Serialize()
		{
			return null;
		}

		public void ClearBuffer()
		{
		}

		public void ClearBuffer(long upTo)
		{
		}

		public void FlushToDisk()
		{
		}

		public void ClearDiskCache()
		{
		}

		internal static string SerializeDateTime(DateTime dateTime)
		{
			return null;
		}
	}
}
