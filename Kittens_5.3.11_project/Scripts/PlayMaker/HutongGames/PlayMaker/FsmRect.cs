using System;
using UnityEngine;

namespace HutongGames.PlayMaker
{
	[Serializable]
	public class FsmRect : NamedVariable
	{
		[SerializeField]
		private Rect value;

		public Rect Value
		{
			get
			{
				return default(Rect);
			}
			set
			{
			}
		}

		public override object RawValue
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override VariableType VariableType => default(VariableType);

		public FsmRect()
		{
		}

		public FsmRect(string name)
		{
		}

		public FsmRect(FsmRect source)
		{
		}

		public override NamedVariable Clone()
		{
			return null;
		}

		public override void Clear()
		{
		}

		public override string ToString()
		{
			return null;
		}

		public static implicit operator FsmRect(Rect value)
		{
			return null;
		}
	}
}
