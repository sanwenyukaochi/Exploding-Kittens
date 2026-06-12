using System.Threading.Tasks;

namespace System.Xml
{
	public abstract class XmlResolver
	{
		public abstract object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn);

		public virtual Uri ResolveUri(Uri baseUri, string relativeUri)
		{
			return null;
		}

		public virtual bool SupportsType(Uri absoluteUri, Type type)
		{
			return false;
		}

		public virtual Task<object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn)
		{
			return null;
		}
	}
}
