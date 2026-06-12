using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace HutongGames.PlayMaker
{
	[Serializable]
	public class FsmGameObject : NamedVariable
	{
		[SerializeField]
		private GameObject value;

		public GameObject Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override Type ObjectType => null;

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

		public event Action OnChange
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public override void SafeAssign(object val)
		{
		}

		public FsmGameObject()
		{
		}

		public FsmGameObject(string name)
		{
		}

		public FsmGameObject(FsmGameObject source)
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

		public static implicit operator FsmGameObject(GameObject value)
		{
			return null;
		}
	}
}
