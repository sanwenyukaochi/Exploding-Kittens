using System;
using UnityEngine;

namespace HutongGames.PlayMaker
{
	[Serializable]
	public class FsmTexture : FsmObject
	{
		public override Type ObjectType => null;

		public new Texture Value
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

		public FsmTexture()
		{
		}

		public FsmTexture(string name)
		{
		}

		public FsmTexture(FsmObject source)
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
