namespace UnityEngine.Purchasing.Interfaces
{
	internal interface IGoogleLastKnownProductService
	{
		string? LastKnownOldProductId { get; set; }

		string? LastKnownProductId { get; set; }

		GooglePlayReplacementMode? LastKnownReplacementMode { get; set; }
	}
}
