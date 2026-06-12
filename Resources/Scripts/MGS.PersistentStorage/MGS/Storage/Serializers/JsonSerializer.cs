using Newtonsoft.Json;

namespace MGS.Storage.Serializers
{
	public class JsonSerializer<T> : Serializer<T>
	{
		private JsonSerializerSettings m_JsonSettings;

		public JsonSerializer(JsonSerializerSettings settings = null)
		{
		}

		public override byte[] Serialize(T data)
		{
			return null;
		}
	}
}
