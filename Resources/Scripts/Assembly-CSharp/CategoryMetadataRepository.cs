using System.Collections.Generic;
using UnityEngine;

public class CategoryMetadataRepository : MonoBehaviour
{
	public List<CategoryMetadata> CategoryMetadataList;

	public static CategoryMetadataRepository instance;

	public static CategoryMetadataRepository Instance => null;

	public CategoryMetadata FindByCategory(CardCategory cardCategory)
	{
		return null;
	}
}
