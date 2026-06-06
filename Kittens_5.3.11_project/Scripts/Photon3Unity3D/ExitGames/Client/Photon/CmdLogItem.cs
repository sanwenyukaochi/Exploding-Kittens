namespace ExitGames.Client.Photon
{
	internal class CmdLogItem
	{
		public int TimeInt;

		public int Channel;

		public int SequenceNumber;

		public int Rtt;

		public int Variance;

		public CmdLogItem()
		{
		}

		public CmdLogItem(NCommand command, int timeInt, int rtt, int variance)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
