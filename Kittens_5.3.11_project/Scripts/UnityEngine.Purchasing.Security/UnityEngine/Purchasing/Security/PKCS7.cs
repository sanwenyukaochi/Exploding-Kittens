using System;
using System.Collections.Generic;
using LipingShare.LCLib.Asn1Processor;

namespace UnityEngine.Purchasing.Security
{
	internal class PKCS7
	{
		private Asn1Node root;

		private bool validStructure;

		public Asn1Node data { get; private set; }

		public List<SignerInfo> sinfos { get; private set; }

		public List<X509Cert> certChain { get; private set; }

		public PKCS7(Asn1Node node)
		{
		}

		public bool Verify(X509Cert cert, DateTime certificateCreationTime)
		{
			return false;
		}

		private X509Cert FindSignCert(SignerInfo sinfo)
		{
			return null;
		}

		private bool IsStoreKitSimulatorData()
		{
			return false;
		}

		private bool VerifyPublicKeyWithSha256OrSha1(X509Cert signCert, SignerInfo sinfo)
		{
			return false;
		}

		private static bool ValidateStoreKitSimulatorCertRoot(X509Cert root, X509Cert cert)
		{
			return false;
		}

		private bool ValidateChain(X509Cert root, X509Cert cert, DateTime certificateCreationTime)
		{
			return false;
		}

		private void CheckStructure()
		{
		}
	}
}
