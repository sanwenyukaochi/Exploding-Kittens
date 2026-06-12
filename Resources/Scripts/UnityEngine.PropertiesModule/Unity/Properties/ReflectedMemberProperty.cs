using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Unity.Properties
{
	public class ReflectedMemberProperty<TContainer, TValue> : Property<TContainer, TValue>
	{
		private delegate TValue GetStructValueAction(ref TContainer container);

		private delegate void SetStructValueAction(ref TContainer container, TValue value);

		private delegate TValue GetClassValueAction(TContainer container);

		private delegate void SetClassValueAction(TContainer container, TValue value);

		private readonly IMemberInfo m_Info;

		private readonly bool m_IsStructContainerType;

		private GetStructValueAction m_GetStructValueAction;

		private SetStructValueAction m_SetStructValueAction;

		private GetClassValueAction m_GetClassValueAction;

		private SetClassValueAction m_SetClassValueAction;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly bool _003CIsReadOnly_003Ek__BackingField;

		public override string Name { get; }

		internal ReflectedMemberProperty(IMemberInfo info, string name)
		{
		}
	}
}
