namespace System.Collections.Specialized
{
	[Serializable]
	public class StringDictionary : IEnumerable
	{
		internal Hashtable contents;

		public virtual string this[string key] => null;

		public virtual IEnumerator GetEnumerator()
		{
			return null;
		}
	}
}
