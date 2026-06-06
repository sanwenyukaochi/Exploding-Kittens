namespace Unity.Services.Analytics
{
	public interface IAnalyticsService
	{
		long ConvertCurrencyToMinorUnits(string currencyCode, double value);
	}
}
