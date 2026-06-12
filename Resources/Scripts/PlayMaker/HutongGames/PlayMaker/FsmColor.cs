using System;
using UnityEngine;

namespace HutongGames.PlayMaker
{
	[Serializable]
	public class FsmColor : NamedVariable
	{
		[SerializeField]
		private Color value;

		public Color Value
		{
			get
			{
				return default(Color);
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

		public FsmColor()
		{
		}

		public FsmColor(string name)
		{
		}

		public FsmColor(FsmColor source)
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

		public static implicit operator FsmColor(Color value)
		{
			return null;
		}
	}
}
