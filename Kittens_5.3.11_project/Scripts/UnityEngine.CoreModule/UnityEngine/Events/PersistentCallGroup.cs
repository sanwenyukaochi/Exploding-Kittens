using System;
using System.Collections.Generic;
using UnityEngine.Serialization;

namespace UnityEngine.Events
{
	[Serializable]
	internal class PersistentCallGroup
	{
		[FormerlySerializedAs("m_Listeners")]
		[SerializeField]
		private List<PersistentCall> m_Calls;

		public void Initialize(InvokableCallList invokableList, UnityEventBase unityEventBase)
		{
		}
	}
}
