using System.Configuration;
using System.Runtime.CompilerServices;

namespace System.Net.Configuration
{
	[ConfigurationCollection(typeof(AuthenticationModuleElement))]
	public sealed class AuthenticationModuleElementCollection : ConfigurationElementCollection
	{
		public AuthenticationModuleElement this[string name]
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
		public AuthenticationModuleElement get_Item(int index)
		{
			return null;
		}

		[SpecialName]
		public void set_Item(int index, AuthenticationModuleElement value)
		{
		}

		public void Add(AuthenticationModuleElement element)
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

		public int IndexOf(AuthenticationModuleElement element)
		{
			return 0;
		}

		public void Remove(AuthenticationModuleElement element)
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
