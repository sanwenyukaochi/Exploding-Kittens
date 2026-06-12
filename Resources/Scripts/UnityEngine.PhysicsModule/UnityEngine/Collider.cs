using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Modules/Physics/Collider.h")]
	[RequireComponent(typeof(Transform))]
	[RequiredByNativeCode]
	public class Collider : Component
	{
		public bool enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Rigidbody attachedRigidbody
		{
			[NativeMethod("GetRigidbody")]
			get
			{
				return null;
			}
		}

		public bool isTrigger
		{
			set
			{
			}
		}

		public PhysicMaterial material
		{
			[NativeMethod("GetClonedMaterial")]
			get
			{
				return null;
			}
		}

		private RaycastHit Raycast(Ray ray, float maxDistance, ref bool hasHit)
		{
			return default(RaycastHit);
		}

		public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance)
		{
			hitInfo = default(RaycastHit);
			return false;
		}

		private void Raycast_Injected(ref Ray ray, float maxDistance, ref bool hasHit, out RaycastHit ret)
		{
			ret = default(RaycastHit);
		}
	}
}
