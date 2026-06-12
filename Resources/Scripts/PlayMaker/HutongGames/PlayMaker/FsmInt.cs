using System;
using UnityEngine;

namespace HutongGames.PlayMaker
{
	[Serializable]
	public class FsmInt : NamedVariable
	{
		[SerializeField]
		private int value;

		public int Value
		{
			get
			{
				return 0;
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

		public override void SafeAssign(object val)
		{
		}

		public FsmInt()
		{
		}

		public FsmInt(string name)
		{
		}

		public FsmInt(FsmInt source)
		{
		}

		public override NamedVariable Clone()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public override float ToFloat()
		{
			return 0f;
		}

		public override int ToInt()
		{
			return 0;
		}

		public override void Clear()
		{
		}

		public static implicit operator FsmInt(int value)
		{
			return null;
		}
	}
}
