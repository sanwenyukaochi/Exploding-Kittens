using System;
using UnityEngine;

namespace HutongGames.PlayMaker
{
	[Serializable]
	public class FsmVector2 : NamedVariable
	{
		[SerializeField]
		private Vector2 value;

		public Vector2 Value
		{
			get
			{
				return default(Vector2);
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

		public FsmVector2()
		{
		}

		public FsmVector2(string name)
		{
		}

		public FsmVector2(FsmVector2 source)
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

		public static implicit operator FsmVector2(Vector2 value)
		{
			return null;
		}
	}
}
