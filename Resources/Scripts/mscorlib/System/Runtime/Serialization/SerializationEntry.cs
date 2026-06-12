namespace System.Runtime.Serialization
{
	public readonly struct SerializationEntry
	{
		private readonly string _name;

		private readonly object _value;

		private readonly Type _type;

		public object Value => null;

		public string Name => null;

		internal SerializationEntry(string entryName, object entryValue, Type entryType)
		{
			_name = null;
			_value = null;
			_type = null;
		}
	}
}
