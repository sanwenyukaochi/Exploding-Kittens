using UnityEngine;

public abstract class WindowController : MonoBehaviour
{
	public bool IsBackDisabled;

	public abstract void OnLoad();

	public virtual void OnUnload()
	{
	}
}
