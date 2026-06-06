using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace HutongGames.PlayMaker
{
	public static class ReflectionUtils
	{
		private static List<string> assemblyNames;

		private static Assembly[] loadedAssemblies;

		private static readonly Dictionary<string, Type> typeLookup;

		public static Assembly[] GetLoadedAssemblies()
		{
			return null;
		}

		[Localizable(false)]
		public static Type GetGlobalType(string typeName)
		{
			return null;
		}

		public static Type GetPropertyType(Type type, string path)
		{
			return null;
		}

		public static MemberInfo[] GetMemberInfo(Type type, string path)
		{
			return null;
		}

		public static bool CanReadMemberValue(MemberInfo member)
		{
			return false;
		}

		public static bool CanSetMemberValue(MemberInfo member)
		{
			return false;
		}

		public static bool CanGetMemberValue(MemberInfo member)
		{
			return false;
		}

		public static Type GetMemberUnderlyingType(MemberInfo member)
		{
			return null;
		}

		public static object GetMemberValue(MemberInfo[] memberInfo, object target)
		{
			return null;
		}

		public static object GetMemberValue(MemberInfo member, object target)
		{
			return null;
		}

		public static void SetMemberValue(MemberInfo member, object target, object value)
		{
		}

		public static void SetMemberValue(MemberInfo[] memberInfo, object target, object value)
		{
		}

		public static void SetBoxedMemberValue(object parent, MemberInfo targetInfo, object target, MemberInfo propertyInfo, object value)
		{
		}

		public static List<MemberInfo> GetFieldsAndProperties<T>(BindingFlags bindingAttr)
		{
			return null;
		}

		public static List<MemberInfo> GetFieldsAndProperties(Type type, BindingFlags bindingAttr)
		{
			return null;
		}

		public static FieldInfo[] GetPublicFields(this Type type)
		{
			return null;
		}

		public static PropertyInfo[] GetPublicProperties(this Type type)
		{
			return null;
		}

		public static bool ImplementsMethod(this Type type, string methodName)
		{
			return false;
		}
	}
}
