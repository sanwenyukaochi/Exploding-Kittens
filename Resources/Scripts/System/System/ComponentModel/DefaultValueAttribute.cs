namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.All)]
	public class DefaultValueAttribute : Attribute
	{
		private object _value;

		private static object s_convertFromInvariantString;

		public virtual object Value => null;

		public DefaultValueAttribute(Type type, string value)
		{
		}

		public DefaultValueAttribute(char value)
		{
		}

		public DefaultValueAttribute(byte value)
		{
		}

		public DefaultValueAttribute(short value)
		{
		}

		public DefaultValueAttribute(int value)
		{
		}

		public DefaultValueAttribute(long value)
		{
		}

		public DefaultValueAttribute(float value)
		{
		}

		public DefaultValueAttribute(double value)
		{
		}

		public DefaultValueAttribute(bool value)
		{
		}

		public DefaultValueAttribute(string value)
		{
		}

		public DefaultValueAttribute(object value)
		{
		}

		[CLSCompliant(false)]
		public DefaultValueAttribute(sbyte value)
		{
		}

		[CLSCompliant(false)]
		public DefaultValueAttribute(ushort value)
		{
		}

		[CLSCompliant(false)]
		public DefaultValueAttribute(uint value)
		{
		}

		[CLSCompliant(false)]
		public DefaultValueAttribute(ulong value)
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		protected void SetValue(object value)
		{
		}
	}
}
