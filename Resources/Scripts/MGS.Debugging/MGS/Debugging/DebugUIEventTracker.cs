using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace MGS.Debugging
{
	public class DebugUIEventTracker
	{
		public delegate void UIEventDelegate(string eventDescription);

		private GameObject m_PreviousSelected;

		private Action unregisterPrevious;

		public event UIEventDelegate OnUIEvent
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

		public void Update()
		{
		}

		public void LogCustomClick(GameObject gameObject, string type)
		{
		}

		private void _OnObjectPressed(GameObject gameObject, string type)
		{
		}

		private void _OnButtonPressed()
		{
		}

		private string _GetGameObjectHierarchyString(GameObject go)
		{
			return null;
		}

		private List<string> _GetGameObjectHierarchyNames(GameObject go, List<string> hierarchy)
		{
			return null;
		}

		private string _GetHierarchyStringFromList(List<string> hierarchy)
		{
			return null;
		}

		private void _OnToggleChanged(bool value)
		{
		}
	}
}
