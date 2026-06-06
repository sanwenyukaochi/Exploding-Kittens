using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace System
{
	[CLSCompliant(false)]
	[ComVisible(true)]
	[NonVersionable]
	public ref struct TypedReference
	{
		private RuntimeTypeHandle type;

		private IntPtr Value;

		private IntPtr Type;

		internal bool IsNull => false;

		[CLSCompliant(false)]
		public static TypedReference MakeTypedReference(object target, FieldInfo[] flds)
		{
			return default(TypedReference);
		}

		private unsafe static void InternalMakeTypedReference(void* result, object target, IntPtr[] flds, RuntimeType lastFieldType)
		{
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object o)
		{
			return false;
		}

		[CLSCompliant(false)]
		public static void SetTypedReference(TypedReference target, object value)
		{
		}
	}
}
