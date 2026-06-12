using System;
using UnityEngine;

namespace HutongGames.PlayMaker
{
	[Serializable]
	public class FsmTransition : IEquatable<FsmTransition>
	{
		public enum CustomLinkStyle : byte
		{
			Default = 0,
			Bezier = 1,
			Circuit = 2,
			Direct = 3
		}

		public enum CustomLinkConstraint : byte
		{
			None = 0,
			LockLeft = 1,
			LockRight = 2
		}

		public enum CustomLinkTarget : byte
		{
			None = 0,
			LockLeft = 1,
			LockRight = 2
		}

		[SerializeField]
		private FsmEvent fsmEvent;

		[SerializeField]
		private string toState;

		[SerializeField]
		private CustomLinkStyle linkStyle;

		[SerializeField]
		private CustomLinkConstraint linkConstraint;

		[SerializeField]
		private CustomLinkTarget linkTarget;

		[SerializeField]
		private byte colorIndex;

		[NonSerialized]
		private FsmState toFsmState;

		public FsmEvent FsmEvent
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string ToState
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FsmState ToFsmState
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CustomLinkStyle LinkStyle
		{
			get
			{
				return default(CustomLinkStyle);
			}
			set
			{
			}
		}

		public CustomLinkConstraint LinkConstraint
		{
			get
			{
				return default(CustomLinkConstraint);
			}
			set
			{
			}
		}

		public CustomLinkTarget LinkTarget
		{
			get
			{
				return default(CustomLinkTarget);
			}
			set
			{
			}
		}

		public int ColorIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string EventName => null;

		public FsmTransition()
		{
		}

		public FsmTransition(FsmTransition source)
		{
		}

		public bool Equals(FsmTransition other)
		{
			return false;
		}
	}
}
