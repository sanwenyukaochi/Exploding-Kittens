namespace ExitGames.Client.Photon
{
	internal class CmdLogSentReliable : CmdLogItem
	{
		public int Resend;

		public int RoundtripTimeout;

		public int Timeout;

		public bool TriggeredTimeout;

		public CmdLogSentReliable(NCommand command, int timeInt, int rtt, int variance, bool triggeredTimeout = false)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
