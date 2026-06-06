using System.Diagnostics;
using System.Globalization;

namespace System.Reflection
{
	[Serializable]
	public abstract class PropertyInfo : MemberInfo
	{
		public override MemberTypes MemberType => default(MemberTypes);

		public abstract Type PropertyType { get; }

		public abstract bool CanRead { get; }

		public abstract bool CanWrite { get; }

		public virtual MethodInfo GetMethod => null;

		public abstract ParameterInfo[] GetIndexParameters();

		public MethodInfo GetGetMethod()
		{
			return null;
		}

		public abstract MethodInfo GetGetMethod(bool nonPublic);

		public MethodInfo GetSetMethod()
		{
			return null;
		}

		public abstract MethodInfo GetSetMethod(bool nonPublic);

		[DebuggerHidden]
		[DebuggerStepThrough]
		public object GetValue(object obj)
		{
			return null;
		}

		[DebuggerStepThrough]
		[DebuggerHidden]
		public virtual object GetValue(object obj, object[] index)
		{
			return null;
		}

		public abstract object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

		[DebuggerHidden]
		[DebuggerStepThrough]
		public void SetValue(object obj, object value)
		{
		}

		[DebuggerStepThrough]
		[DebuggerHidden]
		public virtual void SetValue(object obj, object value, object[] index)
		{
		}

		public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(PropertyInfo left, PropertyInfo right)
		{
			return false;
		}

		public static bool operator !=(PropertyInfo left, PropertyInfo right)
		{
			return false;
		}
	}
}
