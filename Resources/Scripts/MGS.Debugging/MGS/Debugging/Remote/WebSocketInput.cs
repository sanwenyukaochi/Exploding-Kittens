using UnityEngine;
using UnityEngine.EventSystems;

namespace MGS.Debugging.Remote
{
	public class WebSocketInput : BaseInput
	{
		private bool m_Down;

		private Vector2 m_Position;

		private bool m_Released;

		public override Vector2 mousePosition => default(Vector2);

		public override int touchCount => 0;

		public void SetInput(Vector2 position)
		{
		}

		public override bool GetMouseButton(int button)
		{
			return false;
		}

		public override bool GetMouseButtonDown(int button)
		{
			return false;
		}

		public override bool GetMouseButtonUp(int button)
		{
			return false;
		}

		public override Touch GetTouch(int index)
		{
			return default(Touch);
		}

		public void Release()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
