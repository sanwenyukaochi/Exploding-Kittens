using System.Diagnostics;

namespace System.Configuration
{
	[DebuggerDisplay("Count = {Count}")]
	public abstract class ConfigurationElementCollection : ConfigurationElement
	{
		protected virtual bool ThrowOnDuplicate => false;

		protected abstract ConfigurationElement CreateNewElement();

		protected abstract object GetElementKey(ConfigurationElement element);
	}
}
