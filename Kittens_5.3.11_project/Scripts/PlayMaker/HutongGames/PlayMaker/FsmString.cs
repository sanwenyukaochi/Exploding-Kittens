using System;
using UnityEngine;

namespace HutongGames.PlayMaker
{
	[Serializable]
	public class FsmString : NamedVariable
	{
		[SerializeField]
		private string value;

		public string Value
		{
			get
			{
				return null;
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

		public FsmString()
		{
		}

		public FsmString(string name)
		{
		}

		public FsmString(FsmString source)
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

		public override float ToFloat()
		{
			return 0f;
		}

		public static implicit operator FsmString(string value)
		{
			return null;
		}

		public static bool IsNullOrEmpty(FsmString fsmString)
		{
			return false;
		}
	}
}
