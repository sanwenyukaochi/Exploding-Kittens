namespace ExitGames.Client.Photon
{
	public class TrafficStatsGameLevel
	{
		private int timeOfLastDispatchCall;

		private int timeOfLastSendCall;

		public int OperationByteCount { get; set; }

		public int OperationCount { get; set; }

		public int ResultByteCount { get; set; }

		public int ResultCount { get; set; }

		public int EventByteCount { get; set; }

		public int EventCount { get; set; }

		public int LongestOpResponseCallback { get; set; }

		public byte LongestOpResponseCallbackOpCode { get; set; }

		public int LongestEventCallback { get; set; }

		public int LongestMessageCallback { get; set; }

		public int LongestRawMessageCallback { get; set; }

		public byte LongestEventCallbackCode { get; set; }

		public int LongestDeltaBetweenDispatching { get; set; }

		public int LongestDeltaBetweenSending { get; set; }

		public int DispatchIncomingCommandsCalls { get; set; }

		public int SendOutgoingCommandsCalls { get; set; }

		public int TotalMessageCount => 0;

		public int TotalIncomingMessageCount => 0;

		public int TotalOutgoingMessageCount => 0;

		internal void CountOperation(int operationBytes)
		{
		}

		internal void CountResult(int resultBytes)
		{
		}

		internal void CountEvent(int eventBytes)
		{
		}

		internal void TimeForResponseCallback(byte code, int time)
		{
		}

		internal void TimeForEventCallback(byte code, int time)
		{
		}

		internal void TimeForMessageCallback(int time)
		{
		}

		internal void TimeForRawMessageCallback(int time)
		{
		}

		internal void DispatchIncomingCommandsCalled()
		{
		}

		internal void SendOutgoingCommandsCalled()
		{
		}

		public override string ToString()
		{
			return null;
		}

		public string ToStringVitalStats()
		{
			return null;
		}
	}
}
