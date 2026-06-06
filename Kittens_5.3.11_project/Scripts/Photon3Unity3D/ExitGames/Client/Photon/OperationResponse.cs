using System.Collections.Generic;

namespace ExitGames.Client.Photon
{
	public class OperationResponse
	{
		public byte OperationCode;

		public short ReturnCode;

		public string DebugMessage;

		public Dictionary<byte, object> Parameters;

		public object this[byte parameterCode] => null;

		public override string ToString()
		{
			return null;
		}

		public string ToStringFull()
		{
			return null;
		}
	}
}
