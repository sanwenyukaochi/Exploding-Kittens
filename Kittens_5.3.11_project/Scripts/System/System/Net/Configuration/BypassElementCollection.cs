using System.Configuration;
using System.Runtime.CompilerServices;

namespace System.Net.Configuration
{
	[ConfigurationCollection(typeof(BypassElement))]
	public sealed class BypassElementCollection : ConfigurationElementCollection
	{
		public BypassElement this[string name]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override bool ThrowOnDuplicate => false;

		[SpecialName]
		public BypassElement get_Item(int index)
		{
			return null;
		}

		[SpecialName]
		public void set_Item(int index, BypassElement value)
		{
		}

		public void Add(BypassElement element)
		{
		}

		public void Clear()
		{
		}

		protected override ConfigurationElement CreateNewElement()
		{
			return null;
		}

		protected override object GetElementKey(ConfigurationElement element)
		{
			return null;
		}

		public int IndexOf(BypassElement element)
		{
			return 0;
		}

		public void Remove(BypassElement element)
		{
		}

		public void Remove(string name)
		{
		}

		public void RemoveAt(int index)
		{
		}
	}
}
