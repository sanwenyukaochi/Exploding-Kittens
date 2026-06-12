namespace ExitGames.Client.Photon
{
	internal class CmdLogReceivedReliable : CmdLogItem
	{
		public int TimeSinceLastSend;

		public int TimeSinceLastSendAck;

		public CmdLogReceivedReliable(NCommand command, int timeInt, int rtt, int variance, int timeSinceLastSend, int timeSinceLastSendAck)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
