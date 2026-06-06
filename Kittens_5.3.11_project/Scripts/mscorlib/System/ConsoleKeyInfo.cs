namespace System
{
	[Serializable]
	public readonly struct ConsoleKeyInfo
	{
		private readonly char _keyChar;

		private readonly ConsoleKey _key;

		private readonly ConsoleModifiers _mods;

		public char KeyChar => '\0';

		public ConsoleKey Key => default(ConsoleKey);

		public ConsoleKeyInfo(char keyChar, ConsoleKey key, bool shift, bool alt, bool control)
		{
			_keyChar = '\0';
			_key = default(ConsoleKey);
			_mods = default(ConsoleModifiers);
		}

		public override bool Equals(object value)
		{
			return false;
		}

		public bool Equals(ConsoleKeyInfo obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
