using System;
using UnityEngine;

namespace HutongGames.PlayMaker
{
	[Serializable]
	public class NamedVariable : INameable, INamedVariable, IComparable
	{
		[SerializeField]
		private bool useVariable;

		[SerializeField]
		private string name;

		[SerializeField]
		[TextArea(0, 10)]
		private string tooltip;

		[SerializeField]
		private bool showInInspector;

		[SerializeField]
		private bool networkSync;

		[NonSerialized]
		protected object obj;

		public NamedVariable CastVariable
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual VariableType VariableType => default(VariableType);

		public virtual Type ObjectType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual VariableType TypeConstraint => default(VariableType);

		public virtual object RawValue
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Tooltip
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool UseVariable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ShowInInspector
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool NetworkSync
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsNone => false;

		public bool UsesVariable => false;

		public void SetName(string newName)
		{
		}

		public static bool IsNullOrNone(NamedVariable variable)
		{
			return false;
		}

		public NamedVariable()
		{
		}

		public NamedVariable(string name)
		{
		}

		public NamedVariable(NamedVariable source)
		{
		}

		public virtual void Init()
		{
		}

		public virtual bool TestTypeConstraint(VariableType variableType, Type objectType = null)
		{
			return false;
		}

		public virtual void SafeAssign(object val)
		{
		}

		public virtual NamedVariable Clone()
		{
			return null;
		}

		public NamedVariable Copy()
		{
			return null;
		}

		public string GetDisplayName()
		{
			return null;
		}

		public virtual float ToFloat()
		{
			return 0f;
		}

		public virtual int ToInt()
		{
			return 0;
		}

		public virtual string DebugString()
		{
			return null;
		}

		public virtual void Clear()
		{
		}

		public int CompareTo(object target)
		{
			return 0;
		}
	}
}
