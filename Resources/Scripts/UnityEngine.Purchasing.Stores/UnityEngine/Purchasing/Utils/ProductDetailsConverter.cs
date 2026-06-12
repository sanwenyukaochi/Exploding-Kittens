using System.Collections.Generic;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;

namespace UnityEngine.Purchasing.Utils
{
	internal class ProductDetailsConverter : IProductDetailsConverter
	{
		public List<ProductDescription> ConvertOnQueryProductDetailsResponse(IEnumerable<AndroidJavaObject> productDetails)
		{
			return null;
		}

		private static ProductDescription ToProductDescription(AndroidJavaObject productDetails)
		{
			return null;
		}

		internal static ProductDescription BuildProductDescription(AndroidJavaObject productDetails)
		{
			return null;
		}
	}
}
