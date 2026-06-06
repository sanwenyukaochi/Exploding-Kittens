using UnityEngine;

public class InnocuousWordRepository : MonoBehaviour
{
	public TextAssetBackedRepository TextAssetBackedRepository;

	public static InnocuousWordRepository Instance;

	public string RandomSample => null;

	private void Awake()
	{
	}
}
