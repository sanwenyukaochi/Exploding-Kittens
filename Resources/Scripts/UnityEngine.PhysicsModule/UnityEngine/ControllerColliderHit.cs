using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[StructLayout((LayoutKind)0)]
	[RequiredByNativeCode]
	public class ControllerColliderHit
	{
		internal CharacterController m_Controller;

		internal Collider m_Collider;

		internal Vector3 m_Point;

		internal Vector3 m_Normal;

		internal Vector3 m_MoveDirection;

		internal float m_MoveLength;

		internal int m_Push;

		public Collider collider => null;

		public GameObject gameObject => null;

		public Vector3 point => default(Vector3);

		public Vector3 normal => default(Vector3);

		public Vector3 moveDirection => default(Vector3);

		public float moveLength => 0f;
	}
}
