using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing.Security
{
	public class GooglePlayReceipt : IPurchaseReceipt
	{
		[CompilerGenerated]
		private string _003CorderID_003Ek__BackingField;

		[CompilerGenerated]
		private string _003CpurchaseToken_003Ek__BackingField;

		[CompilerGenerated]
		private DateTime _003CpurchaseDate_003Ek__BackingField;

		[CompilerGenerated]
		private GooglePurchaseState _003CpurchaseState_003Ek__BackingField;

		public string productID { get; private set; }

		private string orderID
		{
			[CompilerGenerated]
			set
			{
				_003CorderID_003Ek__BackingField = value;
			}
		}

		public string packageName { get; private set; }

		private string purchaseToken
		{
			[CompilerGenerated]
			set
			{
				_003CpurchaseToken_003Ek__BackingField = value;
			}
		}

		private DateTime purchaseDate
		{
			[CompilerGenerated]
			set
			{
				_003CpurchaseDate_003Ek__BackingField = value;
			}
		}

		private GooglePurchaseState purchaseState
		{
			[CompilerGenerated]
			set
			{
				_003CpurchaseState_003Ek__BackingField = value;
			}
		}

		public GooglePlayReceipt(string productID, string orderID, string packageName, string purchaseToken, DateTime purchaseTime, GooglePurchaseState purchaseState)
		{
		}
	}
}
