using Spine;
using UnityEngine;

public class SpriteAttacher : MonoBehaviour
{
	public bool attachOnStart;

	public bool keepLoaderInMemory;

	public Sprite sprite;

	[SpineSlot(null, null, false)]
	public string slot;

	private SpriteAttachmentLoader loader;

	private RegionAttachment attachment;

	private void Start()
	{
	}

	public void Attach()
	{
	}
}
