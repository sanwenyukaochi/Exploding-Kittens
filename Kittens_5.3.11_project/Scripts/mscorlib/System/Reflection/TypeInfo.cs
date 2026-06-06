using System.Collections.Generic;

namespace System.Reflection
{
	public abstract class TypeInfo : Type, IReflectableType
	{
		public virtual IEnumerable<Type> ImplementedInterfaces => null;

		TypeInfo IReflectableType.GetTypeInfo()
		{
			return null;
		}
	}
}
