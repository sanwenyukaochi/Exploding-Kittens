namespace MGS.Storage.Serializers
{
	public abstract class Serializer<T>
	{
		public abstract byte[] Serialize(T data);
	}
}
