using UnityEngine;

public class SpineSlot : PropertyAttribute
{
	public string startsWith;

	public string dataField;

	public bool containsBoundingBoxes;

	public SpineSlot(string startsWith = "", string dataField = "", bool containsBoundingBoxes = false)
	{
	}
}
