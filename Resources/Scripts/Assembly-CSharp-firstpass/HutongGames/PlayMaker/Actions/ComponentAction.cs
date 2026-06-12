using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	public abstract class ComponentAction<T> : FsmStateAction where T : Component
	{
		protected GameObject cachedGameObject;

		protected T cachedComponent;

		public Transform cachedTransform { get; private set; }

		protected Rigidbody rigidbody => null;

		protected Rigidbody2D rigidbody2d => null;

		protected Renderer renderer => null;

		protected Animation animation => null;

		protected AudioSource audio => null;

		protected Camera camera => null;

		protected Light light => null;

		protected bool UpdateCache(GameObject go)
		{
			return false;
		}

		protected bool UpdateCachedTransform(GameObject go)
		{
			return false;
		}

		protected bool UpdateCacheAndTransform(GameObject go)
		{
			return false;
		}

		protected bool UpdateCacheAddComponent(GameObject go)
		{
			return false;
		}

		protected void SendEvent(FsmEventTarget eventTarget, FsmEvent fsmEvent)
		{
		}
	}
	public abstract class ComponentAction<T1, T2> : FsmStateAction where T1 : Component where T2 : Component
	{
		protected GameObject cachedGameObject1;

		protected GameObject cachedGameObject2;

		protected T1 cachedComponent1;

		protected T2 cachedComponent2;

		protected Transform cachedTransform2;

		protected bool UpdateCache(GameObject go1, GameObject go2)
		{
			return false;
		}
	}
}
