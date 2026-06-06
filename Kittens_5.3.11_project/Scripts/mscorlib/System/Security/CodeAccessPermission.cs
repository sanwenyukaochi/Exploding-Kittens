using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.Security
{
	[Serializable]
	[MonoTODO("CAS support is experimental (and unsupported).")]
	[ComVisible(true)]
	public abstract class CodeAccessPermission : IPermission, ISecurityEncodable
	{
		[Conditional("MONO_FEATURE_CAS")]
		public void Demand()
		{
		}

		[ComVisible(false)]
		public override bool Equals(object obj)
		{
			return false;
		}

		[ComVisible(false)]
		public override int GetHashCode()
		{
			return 0;
		}

		public abstract bool IsSubsetOf(IPermission target);

		public override string ToString()
		{
			return null;
		}

		public abstract SecurityElement ToXml();

		internal static PermissionState CheckPermissionState(PermissionState state, bool allowUnrestricted)
		{
			return default(PermissionState);
		}

		void IPermission.Demand()
		{
		}
	}
}
