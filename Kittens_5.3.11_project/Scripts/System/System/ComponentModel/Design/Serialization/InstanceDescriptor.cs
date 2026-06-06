using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.ComponentModel.Design.Serialization
{
	public sealed class InstanceDescriptor
	{
		[CompilerGenerated]
		private readonly bool _003CIsComplete_003Ek__BackingField;

		public ICollection Arguments { get; }

		public MemberInfo MemberInfo { get; }

		public InstanceDescriptor(MemberInfo member, ICollection arguments)
		{
		}

		public InstanceDescriptor(MemberInfo member, ICollection arguments, bool isComplete)
		{
		}

		public object Invoke()
		{
			return null;
		}
	}
}
