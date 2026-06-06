using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class PlayMakerProxyBase : MonoBehaviour
{
	public delegate void TriggerEvent(Collider other);

	public delegate void CollisionEvent(Collision collisionInfo);

	public delegate void Trigger2DEvent(Collider2D other);

	public delegate void Collision2DEvent(Collision2D collisionInfo);

	public delegate void ParticleCollisionEvent(GameObject gameObject);

	public delegate void ControllerCollisionEvent(ControllerColliderHit hitCollider);

	public List<PlayMakerFSM> TargetFSMs;

	protected PlayMakerFSM[] playMakerFSMs => null;

	private event TriggerEvent TriggerEventCallback
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private event CollisionEvent CollisionEventCallback
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private event ParticleCollisionEvent ParticleCollisionEventCallback
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private event ControllerCollisionEvent ControllerCollisionEventCallback
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private event Trigger2DEvent Trigger2DEventCallback
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private event Collision2DEvent Collision2DEventCallback
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void AddTarget(PlayMakerFSM fsmTarget)
	{
	}

	public bool HasTriggerEventDelegates()
	{
		return false;
	}

	public void AddTriggerEventCallback(TriggerEvent triggerEvent)
	{
	}

	public void RemoveTriggerEventCallback(TriggerEvent triggerEvent)
	{
	}

	public void DoTriggerEventCallback(Collider other)
	{
	}

	public bool HasTrigger2DEventDelegates()
	{
		return false;
	}

	public void AddTrigger2DEventCallback(Trigger2DEvent triggerEvent)
	{
	}

	public void RemoveTrigger2DEventCallback(Trigger2DEvent triggerEvent)
	{
	}

	public void DoTrigger2DEventCallback(Collider2D other)
	{
	}

	public bool HasCollisionEventDelegates()
	{
		return false;
	}

	public void AddCollisionEventCallback(CollisionEvent collisionEvent)
	{
	}

	public void RemoveCollisionEventCallback(CollisionEvent collisionEvent)
	{
	}

	public void DoCollisionEventCallback(Collision collisionInfo)
	{
	}

	public bool HasCollision2DEventDelegates()
	{
		return false;
	}

	public void AddCollision2DEventCallback(Collision2DEvent collisionEvent)
	{
	}

	public void RemoveCollision2DEventCallback(Collision2DEvent collisionEvent)
	{
	}

	public void DoCollision2DEventCallback(Collision2D collisionInfo)
	{
	}

	public bool HasParticleCollisionEventDelegates()
	{
		return false;
	}

	public void AddParticleCollisionEventCallback(ParticleCollisionEvent collisionEvent)
	{
	}

	public void RemoveParticleCollisionEventCallback(ParticleCollisionEvent collisionEvent)
	{
	}

	public void DoParticleCollisionEventCallback(GameObject go)
	{
	}

	public bool HasControllerCollisionEventDelegates()
	{
		return false;
	}

	public void AddControllerCollisionEventCallback(ControllerCollisionEvent collisionEvent)
	{
	}

	public void RemoveControllerCollisionEventCallback(ControllerCollisionEvent collisionEvent)
	{
	}

	public void DoControllerCollisionEventCallback(ControllerColliderHit hitCollider)
	{
	}
}
