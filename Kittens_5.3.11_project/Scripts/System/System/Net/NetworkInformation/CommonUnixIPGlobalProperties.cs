using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation
{
	internal abstract class CommonUnixIPGlobalProperties : IPGlobalProperties
	{
		public override string DomainName => null;

		[PreserveSig]
		private static extern int getdomainname(byte[] name, int len);
	}
}
