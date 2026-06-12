using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Spine;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class SkeletonAnimator : SkeletonRenderer, ISkeletonAnimation
{
	public enum MixMode
	{
		AlwaysMix = 0,
		MixNext = 1,
		SpineStyle = 2
	}

	public MixMode[] layerMixModes;

	private Dictionary<int, Spine.Animation> animationTable;

	private Dictionary<AnimationClip, int> clipNameHashCodeTable;

	private Animator animator;

	private float lastTime;

	public Skeleton Skeleton => null;

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

	public Skeleton GetSkeleton()
	{
		return null;
	}

	public override void Reset()
	{
	}

	private void Update()
	{
	}

	private int GetAnimationClipNameHashCode(AnimationClip clip)
	{
		return 0;
	}
}
