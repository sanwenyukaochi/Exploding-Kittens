using UnityEngine;

public abstract class MessageBoxDisplayer : MonoBehaviour
{
	public abstract void Show(MessageBoxModal modal);

	public abstract void Hide(MessageBoxModal modal);
}
