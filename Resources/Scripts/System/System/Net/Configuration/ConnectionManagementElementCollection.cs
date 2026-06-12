using System.Configuration;
using System.Runtime.CompilerServices;

namespace System.Net.Configuration
{
	[ConfigurationCollection(typeof(ConnectionManagementElement))]
	public sealed class ConnectionManagementElementCollection : ConfigurationElementCollection
	{
		public ConnectionManagementElement this[string name]
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
		public ConnectionManagementElement get_Item(int index)
		{
			return null;
		}

		[SpecialName]
		public void set_Item(int index, ConnectionManagementElement value)
		{
		}

		public void Add(ConnectionManagementElement element)
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

		public int IndexOf(ConnectionManagementElement element)
		{
			return 0;
		}

		public void Remove(ConnectionManagementElement element)
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
