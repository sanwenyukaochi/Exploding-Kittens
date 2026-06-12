using UnityEngine;

public class GenericProvider<T> : MonoBehaviour
{
	private T myValue;

	public GenericProviderValueChangedEvent ValueChanged;

	public virtual T Value
	{
		get
		{
			return default(T);
		}
		set
		{
		}
	}

	public void OnValueAssigned(GenericProviderValueChangedEvent action)
	{
	}
}
