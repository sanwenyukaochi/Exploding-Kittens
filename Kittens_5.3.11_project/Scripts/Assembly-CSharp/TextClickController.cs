using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(TextPic))]
public class TextClickController : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	public Camera UICamera;

	private TextPic textComp;

	private void Start()
	{
	}

	public void OnPointerClick(PointerEventData eventData)
	{
	}
}
