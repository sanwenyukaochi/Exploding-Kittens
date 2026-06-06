using System.Net.Sockets;
using System.Runtime.CompilerServices;

namespace System.Net
{
	[Serializable]
	public class IPAddress
	{
		private sealed class ReadOnlyIPAddress : IPAddress
		{
			public ReadOnlyIPAddress(long newAddress)
				: base(0L)
			{
			}
		}

		public static readonly IPAddress Any;

		public static readonly IPAddress Loopback;

		public static readonly IPAddress Broadcast;

		public static readonly IPAddress None;

		internal const long LoopbackMask = 255L;

		public static readonly IPAddress IPv6Any;

		public static readonly IPAddress IPv6Loopback;

		public static readonly IPAddress IPv6None;

		private uint _addressOrScopeId;

		private readonly ushort[] _numbers;

		private string _toString;

		private int _hashCode;

		internal const int NumberOfLabels = 8;

		private bool IsIPv4 => false;

		private bool IsIPv6 => false;

		private uint PrivateAddress
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		private uint PrivateScopeId
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public AddressFamily AddressFamily => default(AddressFamily);

		public long ScopeId => 0L;

		public IPAddress(long newAddress)
		{
		}

		public IPAddress(byte[] address, long scopeid)
		{
		}

		public IPAddress(ReadOnlySpan<byte> address, long scopeid)
		{
		}

		internal unsafe IPAddress(ushort* numbers, int numbersLength, uint scopeid)
		{
		}

		private IPAddress(ushort[] numbers, uint scopeid)
		{
		}

		public static bool TryParse(string ipString, out IPAddress address)
		{
			address = null;
			return false;
		}

		public static IPAddress Parse(string ipString)
		{
			return null;
		}

		public bool TryWriteBytes(Span<byte> destination, out int bytesWritten)
		{
			bytesWritten = default(int);
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void WriteIPv6Bytes(Span<byte> destination)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void WriteIPv4Bytes(Span<byte> destination)
		{
		}

		public byte[] GetAddressBytes()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public static bool IsLoopback(IPAddress address)
		{
			return false;
		}

		internal bool Equals(object comparandObj, bool compareScopeId)
		{
			return false;
		}

		public override bool Equals(object comparand)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public IPAddress MapToIPv6()
		{
			return null;
		}

		private static byte[] ThrowAddressNullException()
		{
			return null;
		}
	}
}
