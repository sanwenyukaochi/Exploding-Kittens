using UnityEngine;

public class InitializablePrefabFactory<T> : MonoBehaviour where T : IInitializable
{
	public GameObject Prefab;

	public GameObject Container;

	public bool CreateOnStart;

	private void Start()
	{
	}

	public T Create()
	{
		return default(T);
	}
}
