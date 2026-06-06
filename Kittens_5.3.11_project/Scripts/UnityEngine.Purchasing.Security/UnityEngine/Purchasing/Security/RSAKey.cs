using System.Security.Cryptography;
using LipingShare.LCLib.Asn1Processor;

namespace UnityEngine.Purchasing.Security
{
	internal class RSAKey
	{
		public RSACryptoServiceProvider rsa { get; private set; }

		public RSAKey(Asn1Node n)
		{
		}

		public RSAKey(byte[] data)
		{
		}

		public bool VerifySha1(byte[] message, byte[] signature)
		{
			return false;
		}

		public bool VerifySha256(byte[] message, byte[] signature)
		{
			return false;
		}

		private RSACryptoServiceProvider ParseNode(Asn1Node n)
		{
			return null;
		}

		private string ToXML(string modulus, string exponent)
		{
			return null;
		}
	}
}
