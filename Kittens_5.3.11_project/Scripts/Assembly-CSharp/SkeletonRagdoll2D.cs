using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using UnityEngine;

[RequireComponent(typeof(SkeletonRenderer))]
public class SkeletonRagdoll2D : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSmoothMixCoroutine_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkeletonRagdoll2D _003C_003E4__this;

		public float target;

		public float duration;

		private float _003CstartTime_003E5__2;

		private float _003CstartMix_003E5__3;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CSmoothMixCoroutine_003Ed__31(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CStart_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkeletonRagdoll2D _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CStart_003Ed__29(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private static Transform helper;

	[SpineBone(null, null)]
	[Header("Hierarchy")]
	public string startingBoneName;

	[SpineBone(null, null)]
	public List<string> stopBoneNames;

	[Header("Parameters")]
	public bool applyOnStart;

	[Tooltip("Set RootRigidbody IsKinematic to true when Apply is called.")]
	public bool pinStartBone;

	public float gravityScale;

	[Tooltip("Warning!  You will have to re-enable and tune mix values manually if attempting to remove the ragdoll system.")]
	public bool disableIK;

	[Tooltip("If no BoundingBox Attachment is attached to a bone, this becomes the default Width or Radius of a Bone's ragdoll Rigidbody")]
	public float thickness;

	[Tooltip("Default rotational limit value.  Min is negative this value, Max is this value.")]
	public float rotationLimit;

	public float rootMass;

	[Range(0.01f, 1f)]
	[Tooltip("If your ragdoll seems unstable or uneffected by limits, try lowering this value.")]
	public float massFalloffFactor;

	[Tooltip("The layer assigned to all of the rigidbody parts.")]
	public int colliderLayer;

	[Range(0f, 1f)]
	public float mix;

	private Rigidbody2D rootRigidbody;

	private ISkeletonAnimation skeletonAnim;

	private Skeleton skeleton;

	private Dictionary<Bone, Transform> boneTable;

	private Bone startingBone;

	private Transform ragdollRoot;

	private Vector2 rootOffset;

	private bool isActive;

	public Rigidbody2D RootRigidbody => null;

	public Vector3 RootOffset => default(Vector3);

	public Vector3 EstimatedSkeletonPosition => default(Vector3);

	public bool IsActive => false;

	[IteratorStateMachine(typeof(_003CStart_003Ed__29))]
	private IEnumerator Start()
	{
		return null;
	}

	public Coroutine SmoothMix(float target, float duration)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CSmoothMixCoroutine_003Ed__31))]
	private IEnumerator SmoothMixCoroutine(float target, float duration)
	{
		return null;
	}

	public void SetSkeletonPosition(Vector3 worldPosition)
	{
	}

	public Rigidbody2D[] GetRigidbodyArray()
	{
		return null;
	}

	public Rigidbody2D GetRigidbody(string boneName)
	{
		return null;
	}

	public void Remove()
	{
	}

	public void Apply()
	{
	}

	private void RecursivelyCreateBoneProxies(Bone b)
	{
	}

	private List<Collider2D> AttachBoundingBoxRagdollColliders(Bone b)
	{
		return null;
	}

	private void UpdateWorld(SkeletonRenderer skeletonRenderer)
	{
	}

	private float GetCompensatedRotationIK(Bone b)
	{
		return 0f;
	}

	private void OnDrawGizmosSelected()
	{
	}
}
