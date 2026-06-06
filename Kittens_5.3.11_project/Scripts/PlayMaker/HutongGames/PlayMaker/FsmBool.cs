using System;
using UnityEngine;

namespace HutongGames.PlayMaker
{
	[Serializable]
	public class FsmBool : NamedVariable
	{
		[SerializeField]
		private bool value;

		public bool Value
		{
			get
			{
				return false;
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

		public FsmBool()
		{
		}

		public FsmBool(string name)
		{
		}

		public FsmBool(FsmBool source)
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

		public override int ToInt()
		{
			return 0;
		}

		public override void Clear()
		{
		}

		public static implicit operator FsmBool(bool value)
		{
			return null;
		}
	}
}
