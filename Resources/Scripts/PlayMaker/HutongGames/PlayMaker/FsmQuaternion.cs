using System;
using UnityEngine;

namespace HutongGames.PlayMaker
{
	[Serializable]
	public class FsmQuaternion : NamedVariable
	{
		[SerializeField]
		private Quaternion value;

		public Quaternion Value
		{
			get
			{
				return default(Quaternion);
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

		public FsmQuaternion()
		{
		}

		public FsmQuaternion(string name)
		{
		}

		public FsmQuaternion(FsmQuaternion source)
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

		public static implicit operator FsmQuaternion(Quaternion value)
		{
			return null;
		}
	}
}
