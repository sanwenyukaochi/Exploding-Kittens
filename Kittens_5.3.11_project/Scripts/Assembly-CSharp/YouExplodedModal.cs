using System.Runtime.CompilerServices;
using UnityEngine;

public class YouExplodedModal : MonoBehaviour, IModal
{
	public PlayMakerFSM AnimationFsm;

	private bool ExplosionSoundPlayed;

	public event ModalDelegate OnDone
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

	public void Show()
	{
	}

	public void DoneAnimating()
	{
	}

	public void DoneAnimatingSoundFinished()
	{
	}
}
