using System;

namespace UnityEngine
{
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
	public class UnityAPICompatibilityVersionAttribute : Attribute
	{
		private string _version;

		public UnityAPICompatibilityVersionAttribute(string version, bool checkOnlyUnityVersion)
		{
		}
	}
}
