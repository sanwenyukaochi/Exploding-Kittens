using System;
using UnityEngine;

public abstract class CardDropTarget : MonoBehaviour
{
	public abstract void DropCard(HandCard handCard, Action onFailure);
}
