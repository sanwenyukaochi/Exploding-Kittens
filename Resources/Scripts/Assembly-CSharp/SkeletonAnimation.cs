using System.Runtime.CompilerServices;
using Spine;
using UnityEngine;

[AddComponentMenu("Spine/SkeletonAnimation")]
[ExecuteInEditMode]
public class SkeletonAnimation : SkeletonRenderer, ISkeletonAnimation
{
	public float timeScale;

	public bool loop;

	public Spine.AnimationState state;

	[SerializeField]
	private string _animationName;

	public Skeleton Skeleton => null;

	public string AnimationName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public event UpdateBonesDelegate UpdateLocal
	{
		add
		{
		}
		remove
		{
		}
	}

	public event UpdateBonesDelegate UpdateWorld
	{
		add
		{
		}
		remove
		{
		}
	}

	public event UpdateBonesDelegate UpdateComplete
	{
		add
		{
		}
		remove
		{
		}
	}

	protected event UpdateBonesDelegate _UpdateLocal
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

	protected event UpdateBonesDelegate _UpdateWorld
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

	protected event UpdateBonesDelegate _UpdateComplete
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

	public override void Reset()
	{
	}

	public virtual void Update()
	{
	}

	public virtual void Update(float deltaTime)
	{
	}
}
