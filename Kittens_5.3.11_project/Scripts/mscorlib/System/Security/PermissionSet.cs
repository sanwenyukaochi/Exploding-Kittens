using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Security
{
	[Serializable]
	[MonoTODO("CAS support is experimental (and unsupported).")]
	[ComVisible(true)]
	public class PermissionSet : ISecurityEncodable, ICollection, IEnumerable, IDeserializationCallback
	{
		private static object[] psUnrestricted;

		private PermissionState state;

		private ArrayList list;

		private bool _declsec;

		private bool[] _ignored;

		private static object[] action;

		public virtual int Count => 0;

		public virtual bool IsSynchronized => false;

		public virtual object SyncRoot => null;

		internal PermissionSet()
		{
		}

		public PermissionSet(PermissionState state)
		{
		}

		internal PermissionSet(IPermission perm)
		{
		}

		public virtual void CopyTo(Array array, int index)
		{
		}

		public void Demand()
		{
		}

		internal void CasOnlyDemand(int skip)
		{
		}

		public IEnumerator GetEnumerator()
		{
			return null;
		}

		public bool IsEmpty()
		{
			return false;
		}

		public bool IsUnrestricted()
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}

		public virtual SecurityElement ToXml()
		{
			return null;
		}

		[MonoTODO("may not be required")]
		void IDeserializationCallback.OnDeserialization(object sender)
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
	}
}
