using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.Security
{
	[Serializable]
	[ComVisible(true)]
	public sealed class NamedPermissionSet : PermissionSet
	{
		private string name;

		private string description;

		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal NamedPermissionSet()
		{
		}

		public NamedPermissionSet(string name, PermissionState state)
		{
		}

		public NamedPermissionSet(string name)
		{
		}

		public override SecurityElement ToXml()
		{
			return null;
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
	}
}
