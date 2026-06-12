using System;
using UnityEngine;

[Serializable]
public abstract class CardCommandAction : MonoBehaviour
{
	public abstract void Act(CardCommand cardCommand);
}
