using System;
using UnityEngine;

namespace HutongGames.PlayMaker
{
	[Serializable]
	public class FsmFloat : NamedVariable
	{
		[SerializeField]
		private float value;

		public float Value
		{
			get
			{
				return 0f;
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

		public FsmFloat()
		{
		}

		public FsmFloat(string name)
		{
		}

		public FsmFloat(FsmFloat source)
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

		public override string DebugString()
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

		public static implicit operator FsmFloat(float value)
		{
			return null;
		}
	}
}
