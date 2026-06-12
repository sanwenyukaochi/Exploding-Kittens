using UnityEngine;
using UnityEngine.EventSystems;

namespace HutongGames.PlayMaker
{
	[AddComponentMenu("PlayMaker/UI/UI Drag Events")]
	public class PlayMakerUiDragEvents : PlayMakerUiEventBase, IDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler
	{
		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		public void OnDrag(PointerEventData eventData)
		{
		}

		public void OnEndDrag(PointerEventData eventData)
		{
		}
	}
}
