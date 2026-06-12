using System;
using UnityEngine;

namespace HutongGames.PlayMaker
{
	[Serializable]
	public class FsmVector3 : NamedVariable
	{
		[SerializeField]
		private Vector3 value;

		public Vector3 Value
		{
			get
			{
				return default(Vector3);
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

		public FsmVector3()
		{
		}

		public FsmVector3(string name)
		{
		}

		public FsmVector3(FsmVector3 source)
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

		public static implicit operator FsmVector3(Vector3 value)
		{
			return null;
		}
	}
}
