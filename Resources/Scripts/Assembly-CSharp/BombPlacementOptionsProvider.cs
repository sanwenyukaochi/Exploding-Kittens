using System.Collections.Generic;
using UnityEngine;

public class BombPlacementOptionsProvider : MonoBehaviour
{
	public List<IntegerRadioOption> StandardOptions;

	public GameDeck GameDeck;

	public List<IntegerRadioOption> List => null;

	public IntegerRadioOption RandomOption => null;

	private IntegerRadioOption BottomOption => null;

	private int CardsRemaining => 0;
}
