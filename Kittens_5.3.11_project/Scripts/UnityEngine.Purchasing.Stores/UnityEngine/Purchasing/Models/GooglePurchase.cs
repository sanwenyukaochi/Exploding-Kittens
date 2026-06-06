using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.Interfaces;

namespace UnityEngine.Purchasing.Models
{
	internal class GooglePurchase : IGooglePurchase
	{
		[CompilerGenerated]
		private readonly string _003CorderId_003Ek__BackingField;

		[CompilerGenerated]
		private readonly string? _003CobfuscatedAccountId_003Ek__BackingField;

		[CompilerGenerated]
		private readonly string _003CobfuscatedProfileId_003Ek__BackingField;

		public bool isAcknowledged { get; }

		public int purchaseState { get; }

		public List<string> skus { get; }

		public string receipt { get; }

		public string signature { get; }

		public string originalJson { get; }

		public string purchaseToken { get; }

		public string? sku => null;

		internal GooglePurchase(AndroidJavaObject purchase, IEnumerable<AndroidJavaObject> productDetailsEnum)
		{
		}

		public virtual bool IsAcknowledged()
		{
			return false;
		}

		public virtual bool IsPurchased()
		{
			return false;
		}

		public virtual bool IsPending()
		{
			return false;
		}
	}
}
