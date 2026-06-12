namespace ExitGames.Client.Photon
{
	internal class CmdLogReceivedAck : CmdLogItem
	{
		public int ReceivedSentTime;

		public CmdLogReceivedAck(NCommand command, int timeInt, int rtt, int variance)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
