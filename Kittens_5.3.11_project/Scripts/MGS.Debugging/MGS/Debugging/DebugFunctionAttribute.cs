using System;

namespace MGS.Debugging
{
	[AttributeUsage(AttributeTargets.Method)]
	public class DebugFunctionAttribute : Attribute
	{
		private string m_Description;

		public DebugFunctionAttribute(string description)
		{
		}

		public string GetDescription()
		{
			return null;
		}
	}
}
