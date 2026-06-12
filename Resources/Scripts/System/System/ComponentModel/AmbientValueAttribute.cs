namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.All)]
	public sealed class AmbientValueAttribute : Attribute
	{
		public object Value { get; }

		public AmbientValueAttribute(Type type, string value)
		{
		}

		public AmbientValueAttribute(char value)
		{
		}

		public AmbientValueAttribute(byte value)
		{
		}

		public AmbientValueAttribute(short value)
		{
		}

		public AmbientValueAttribute(int value)
		{
		}

		public AmbientValueAttribute(long value)
		{
		}

		public AmbientValueAttribute(float value)
		{
		}

		public AmbientValueAttribute(double value)
		{
		}

		public AmbientValueAttribute(bool value)
		{
		}

		public AmbientValueAttribute(string value)
		{
		}

		public AmbientValueAttribute(object value)
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
	}
}
