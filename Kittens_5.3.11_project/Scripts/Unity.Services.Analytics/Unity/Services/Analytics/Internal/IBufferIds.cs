namespace Unity.Services.Analytics.Internal
{
	internal interface IBufferIds
	{
		string UserId { get; }

		string InstallId { get; }

		string PlayerId { get; }

		string SessionId { get; }
	}
}
