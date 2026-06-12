using LipingShare.LCLib.Asn1Processor;

namespace UnityEngine.Purchasing.Security
{
	internal class SignerInfo
	{
		public int Version { get; private set; }

		public string IssuerSerialNumber { get; private set; }

		public byte[] EncryptedDigest { get; private set; }

		public SignerInfo(Asn1Node n)
		{
		}
	}
}
