using System.Collections;
using System.Runtime.Serialization;

namespace System.Data
{
	[Serializable]
	public class PropertyCollection : Hashtable, ICloneable
	{
		public PropertyCollection()
		{
		}

		protected PropertyCollection(SerializationInfo info, StreamingContext context)
		{
		}

		public override object Clone()
		{
			return null;
		}
	}
}
