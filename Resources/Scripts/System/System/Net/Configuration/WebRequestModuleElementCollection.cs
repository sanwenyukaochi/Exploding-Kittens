using System.Configuration;
using System.Runtime.CompilerServices;

namespace System.Net.Configuration
{
	[ConfigurationCollection(typeof(WebRequestModuleElement))]
	public sealed class WebRequestModuleElementCollection : ConfigurationElementCollection
	{
		public WebRequestModuleElement this[string name]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[SpecialName]
		public WebRequestModuleElement get_Item(int index)
		{
			return null;
		}

		[SpecialName]
		public void set_Item(int index, WebRequestModuleElement value)
		{
		}

		public void Add(WebRequestModuleElement element)
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

		public int IndexOf(WebRequestModuleElement element)
		{
			return 0;
		}

		public void Remove(WebRequestModuleElement element)
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
