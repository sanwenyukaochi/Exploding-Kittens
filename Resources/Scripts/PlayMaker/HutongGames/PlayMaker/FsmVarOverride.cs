using System;

namespace HutongGames.PlayMaker
{
	[Serializable]
	public class FsmVarOverride
	{
		public NamedVariable variable;

		public FsmVar fsmVar;

		public bool isEdited;

		public string Name => null;

		public FsmVarOverride(FsmVarOverride source)
		{
		}

		public FsmVarOverride(NamedVariable namedVar)
		{
		}

		public FsmVarOverride(NamedVariable namedVar, string variableName)
		{
		}

		public void Apply(FsmVariables variables)
		{
		}

		public void Update(FsmVariables fromVariables, FsmVariables toVariables)
		{
		}
	}
}
