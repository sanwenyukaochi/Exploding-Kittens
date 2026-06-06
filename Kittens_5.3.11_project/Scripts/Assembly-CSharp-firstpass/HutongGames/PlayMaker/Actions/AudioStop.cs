using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Audio)]
	[Tooltip("Stops playing the Audio Clip played by an Audio Source component on a Game Object.")]
	public class AudioStop : ComponentAction<AudioSource>
	{
		[CompilerGenerated]
		private sealed class _003CVolumeFade_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float fadeDuration;

			public AudioSource audioSource;

			public AudioStop _003C_003E4__this;

			public float endVolume;

			private float _003CstartTime_003E5__2;

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
			public _003CVolumeFade_003Ed__5(int _003C_003E1__state)
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

		[RequiredField]
		[CheckForComponent(typeof(AudioSource))]
		[Tooltip("The GameObject with an AudioSource component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("Audio Stop can make a hard pop sound. A short fade out can fix this glitch.")]
		public FsmFloat fadeTime;

		private float volume;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		[IteratorStateMachine(typeof(_003CVolumeFade_003Ed__5))]
		private IEnumerator VolumeFade(AudioSource audioSource, float endVolume, float fadeDuration)
		{
			return null;
		}
	}
}
