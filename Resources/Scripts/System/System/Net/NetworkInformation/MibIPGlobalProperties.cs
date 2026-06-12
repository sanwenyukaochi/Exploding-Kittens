namespace System.Net.NetworkInformation
{
	internal class MibIPGlobalProperties : UnixIPGlobalProperties
	{
		public readonly string StatisticsFile;

		public readonly string StatisticsFileIPv6;

		public readonly string TcpFile;

		public readonly string Tcp6File;

		public readonly string UdpFile;

		public readonly string Udp6File;

		private static readonly char[] wsChars;

		public MibIPGlobalProperties(string procDir)
		{
		}
	}
}
