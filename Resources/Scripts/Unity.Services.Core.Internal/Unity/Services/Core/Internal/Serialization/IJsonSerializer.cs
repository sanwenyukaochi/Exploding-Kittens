namespace Unity.Services.Core.Internal.Serialization
{
	internal interface IJsonSerializer
	{
		T DeserializeObject<T>(string value);
	}
}
