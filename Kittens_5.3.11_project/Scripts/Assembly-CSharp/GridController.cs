using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(UIGrid))]
public class GridController : MonoBehaviour
{
	public UIGrid grid;

	private int itemCount;

	private Dictionary<object, GameObject> currentItems;

	private void Awake()
	{
	}

	public GameObject FindItemForKey(object key)
	{
		return null;
	}

	public GameObject AddItemForKey(object key, GameObject newItem)
	{
		return null;
	}

	public bool ContainsKey(object key)
	{
		return false;
	}

	public void RemoveItemForKey(object key)
	{
	}

	public void Clear()
	{
	}

	private void RepositionAlphabetically()
	{
	}
}
