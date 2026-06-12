using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	[ComVisible(true)]
	public abstract class KeyedHashAlgorithm : HashAlgorithm
	{
		protected byte[] KeyValue;

		public virtual byte[] Key
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override void Dispose(bool disposing)
		{
		}

		public new static KeyedHashAlgorithm Create()
		{
			return null;
		}

		public new static KeyedHashAlgorithm Create(string algName)
		{
			return null;
		}
	}
}
