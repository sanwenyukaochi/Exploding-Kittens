using System;
using UnityEngine;

namespace HutongGames.PlayMaker
{
	[Serializable]
	public class FsmMaterial : FsmObject
	{
		public override Type ObjectType => null;

		public new Material Value
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

		public FsmMaterial()
		{
		}

		public FsmMaterial(string name)
		{
		}

		public FsmMaterial(FsmObject source)
		{
		}

		public override NamedVariable Clone()
		{
			return null;
		}

		public override bool TestTypeConstraint(VariableType variableType, Type _objectType = null)
		{
			return false;
		}
	}
}
