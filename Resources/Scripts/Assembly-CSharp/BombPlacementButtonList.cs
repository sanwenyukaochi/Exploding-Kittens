using System.Collections.Generic;
using UnityEngine;

public class BombPlacementButtonList : MonoBehaviour
{
	public Transform ButtonContainer;

	public GameObject Prefab;

	public Vector3 ButtonOffset;

	public BombPlacementOptionsProvider BombPlacementOptionsProvider;

	public void Clear()
	{
	}

	public void AddButtons(RadioButtonDelegate<int> OnSelect)
	{
	}

	private void CreateNewRadioButtons(List<IntegerRadioOption> options, RadioButtonDelegate<int> OnSelect)
	{
	}

	public void CreateRadioButton(IntegerRadioOption radioOption, Vector3 position, RadioButtonDelegate<int> OnSelect)
	{
	}
}
